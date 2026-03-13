using System;
using System.Threading.Tasks;
using UnityEngine;

[ExecuteInEditMode]
public class BipedAvatarDescriptor : MonoBehaviour, IConversionPostProcessor
{
    const float EYE_SEPARATION = 0.065f; // 65 mm
    const float AXIS_LENGTH = 0.25f;

    public bool IsValid => Biped != null && ViewpointReference != null && LeftHandReference != null && RightHandReference != null;

    [NonSerialized]
    public bool AvatarConverted;

    [Header("Required References")]
    public Animator Biped;

    public Transform ViewpointReference;
    public Transform LeftHandReference;
    public Transform RightHandReference;

    [Header("Optional References")]
    public Transform LeftFootReference;
    public Transform RightFootReference;
    public Transform HipsReference;

    [Header("Additional Setup Options")]
    public bool SetupProtection = true;
    public bool SetupEyes = true;
    public bool SetupFaceTracking = true;
    public bool SetupVolumeMeter = false;

    [ExecuteInEditMode]
    void Awake()
    {
        // If biped has already been assigned, do not run the auto setup
        if (Biped != null)
            return;

        // Try to initialize the biped on attach
        Biped = GetComponent<Animator>();

        // Initialize references
        if (ViewpointReference == null && LeftHandReference == null && RightHandReference == null)
        {
            var references = new GameObject("References");
            references.transform.SetParent(transform, false);

            var viewpoint = new GameObject("Viewpoint");
            viewpoint.transform.SetParent(references.transform, false);
            ViewpointReference = viewpoint.transform;

            var leftHand = new GameObject("Left Hand");
            leftHand.transform.SetParent(references.transform, false);
            LeftHandReference = leftHand.transform;

            var rightHand = new GameObject("Right Hand");
            rightHand.transform.SetParent(references.transform, false);
            RightHandReference = rightHand.transform;

            // TODO!!! Try position the references automatically
        }
    }

    public void PostProcessConversion(IConversionContext context)
    {
        // If it's not valid, we can't do any conversion post processing
        if (!IsValid)
            return;

       // We've already converted the avatar
        if (AvatarConverted)
            return;

        var wrapper = Biped.transform.GetComponent<FrooxEngine.BipedRigWrapper>();

        if(wrapper == null)
        {
            Debug.LogWarning($"Could not find BipedRig on the Biped reference. Cannot setup avatar");
            return;
        }

        var headSlot = ViewpointReference.GetSlot();
        var leftHandSlot = LeftHandReference.GetSlot();
        var rightHandSlot = RightHandReference.GetSlot();

        var leftFootSlot = LeftFootReference.GetSlot();
        var rightFootSlot = RightFootReference.GetSlot();
        var hipsSlot = HipsReference.GetSlot();

        Task.Run(async () =>
        {
            await FrooxEngine.AvatarCreator.CreateBipedAvatar(wrapper.Data,
            headSlot, leftHandSlot, rightHandSlot,
            leftFootSlot, rightFootSlot, hipsSlot,

            SetupEyes, SetupProtection, SetupVolumeMeter, SetupFaceTracking, context);

        }).Wait();

        AvatarConverted = true;
    }

    void OnDrawGizmos()
    {
        if (ViewpointReference != null)
        {
            // We want to ignore the scale of this, so do the transformations
            var viewPos = ViewpointReference.position;
            var viewRot = ViewpointReference.rotation;

            Vector3 ComputePoint(Vector3 offset) => viewPos + viewRot * offset;

            // Eyes
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(ComputePoint(Vector3.left * EYE_SEPARATION * 0.5f), 0.025f);

            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ComputePoint(Vector3.right * EYE_SEPARATION * 0.5f), 0.025f);

            // Head
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(ComputePoint((Vector3.back + Vector3.down) * 0.05f), 0.1f);

            // View frustum
            Gizmos.matrix = Matrix4x4.TRS(ViewpointReference.position, ViewpointReference.rotation, Vector3.one);
            Gizmos.DrawFrustum(Vector3.zero, 90f, 1f, 0.05f, 1f);
            Gizmos.matrix = Matrix4x4.identity;

            DrawAxes(ViewpointReference);
        }

        if (LeftHandReference != null)
            DrawHand(LeftHandReference, Color.cyan, false);

        if (RightHandReference != null)
            DrawHand(RightHandReference, Color.red, true);

        if (LeftFootReference != null)
            DrawFoot(LeftFootReference, Color.cyan);

        if (RightFootReference != null)
            DrawFoot(RightFootReference, Color.red);

        if(HipsReference != null)
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireSphere(HipsReference.position, 0.1f);

            DrawAxes(HipsReference);
        }
    }

    void DrawHand(Transform transform, Color handColor, bool isRight)
    {
        var sideMul = isRight ? 1 : -1;

        Gizmos.color = handColor;

        DrawCube(transform, new Vector3(0.05f, 0.02f, 0.05f));

        // Crude fingers. This is just to better indicate that it's supposed to represent a hand
        for (int i = 0; i < 4; i++)
        {
            var offset = (i / 4.0f) - 0.4f;
            DrawCube(transform, new Vector3(0.0075f, 0.0075f, 0.05f), new Vector3(offset * 0.05f, 0f, 0.05f), Quaternion.identity);
        }

        // Thumb
        DrawCube(transform, new Vector3(0.015f, 0.015f, 0.04f), new Vector3(-0.025f * sideMul, 0f, 0.01f), Quaternion.AngleAxis(-45f * sideMul, Vector3.up));
        
        DrawAxes(transform);
    }

    void DrawFoot(Transform transform, Color footColor)
    {
        Gizmos.color = footColor;
        DrawCube(transform, new Vector3(0.075f, 0.04f, 0.15f));

        DrawAxes(transform);
    }

    void DrawCube(Transform transform, Vector3 size) => DrawCube(transform, size, Vector3.zero, Quaternion.identity);
    void DrawCube(Transform transform, Vector3 size, Vector3 offset, Quaternion rotationOffset)
    {
        var rotation = transform.rotation * rotationOffset;
        offset = transform.rotation * offset;

        // We want to move the cube along the forward axis, because the transform represents the "root"
        var axisOffset = rotation * Vector3.forward * size.z * 0.4f;

        Gizmos.matrix = Matrix4x4.TRS(transform.position + offset + axisOffset, rotation, Vector3.one);

        Gizmos.DrawWireCube(Vector3.zero, size);
        Gizmos.matrix = Matrix4x4.identity;
    }

    void DrawAxes(Transform transform)
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * AXIS_LENGTH);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.up * AXIS_LENGTH);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * AXIS_LENGTH);
    }
}
