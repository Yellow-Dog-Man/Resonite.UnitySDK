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

            SetupAnchors(LeftHandReference);

            var rightHand = new GameObject("Right Hand");
            rightHand.transform.SetParent(references.transform, false);
            RightHandReference = rightHand.transform;

            SetupAnchors(RightHandReference);

            TryPositionReferences();
        }
    }

    void SetupAnchors(Transform root)
    {
        var tooltip = new GameObject("Tooltip");
        tooltip.transform.SetParent(root, false);
        tooltip.transform.localPosition = new Vector3(0, 0, 0.15f);

        var grabber = new GameObject("Grabber");
        grabber.transform.SetParent(root, false);
        grabber.transform.localPosition = new Vector3(0, -0.02f, 0.05f);

        var shelf = new GameObject("Shelf");
        shelf.transform.SetParent(root, false);
        shelf.transform.localPosition = new Vector3(0, 0.02f, 0.02f);
    }

    void TryPositionReferences()
    {
        var avatar = Biped?.avatar;

        if (avatar == null || !avatar.isHuman)
            return;

        var head = Biped.GetBoneTransform(HumanBodyBones.Head);
        var leftHand = Biped.GetBoneTransform(HumanBodyBones.LeftHand);
        var rightHand = Biped.GetBoneTransform(HumanBodyBones.RightHand);

        // Can't do positioning without the head or hands
        if (head == null || leftHand == null || rightHand == null)
            return;

        // We can determine the right direction from the hands - going left to right
        var rightDir = (rightHand.position - leftHand.position).normalized;

        // Assuming the avatar isn't rotated weirdly, which should be relatively same assumption
        var upDir = Vector3.up;

        // Now we can compute forward direction from this
        var forwardDir = Vector3.Cross(rightDir, upDir);

        Vector3 centerPoint;

        // Ideally try position based on the eyes
        var leftEye = Biped.GetBoneTransform(HumanBodyBones.LeftEye);
        var rightEye = Biped.GetBoneTransform(HumanBodyBones.RightEye);

        if(leftEye != null && rightEye != null)
        {
            // Position where the center of the eyes is
            centerPoint = (leftEye.position + rightEye.position) * 0.5f;

            float forwardOffset = 0.025f;

            // Check if the center point is behind the head - some avatars will have eye bones really far back
            var eyeDir = centerPoint - head.position;
            var eyeDot = Vector3.Dot(forwardDir, eyeDir);

            if(eyeDot < 0)
            {
                Debug.Log("Eye bones are behind the head. Guesstimating face position");

                // Get distance on XZ plane (ignoring any Y positioning)
                var dist = Vector2.Distance(new Vector2(centerPoint.x, centerPoint.z), new Vector2(head.position.x, head.position.z));

                // We want to offset the eye position forward by the distance from where eyes are backwards, to the head + a bit extra
                // This is also a guesstimate to get it roughly where it needs to be
                // If we did only "dist", then we'd position it at the where the head itself is, but it needs to go past that
                // towards front of the face
                forwardOffset += dist * 1.5f;
            }

            // Position it slightly forward out of the face
            centerPoint += forwardDir * forwardOffset;
        }
        else
        {
            Debug.Log("Did not detect eyes. Using guesstimated eye position");

            // Guesstimate the viewpoint position without the eyes
            // It doesn't need to be perfect - user can adjust the positioning after
            // We only want to get it roughly where the viewpoint would be

            // This is technically top of the neck typically
            centerPoint = head.position;

            // Move it up a bit
            centerPoint += upDir * 0.1f;

            // And forwards a bit
            centerPoint += forwardDir * 0.05f;
        }

        ViewpointReference.position = centerPoint;
        ViewpointReference.rotation = Quaternion.LookRotation(forwardDir, upDir);

        // Guess the arm direction
        var leftArmBase = Biped.GetBoneTransform(HumanBodyBones.LeftShoulder);

        if (leftArmBase == null)
            leftArmBase = Biped.GetBoneTransform(HumanBodyBones.LeftUpperArm);

        if (leftArmBase == null)
            leftArmBase = Biped.GetBoneTransform(HumanBodyBones.Neck);

        if (leftArmBase == null)
            leftArmBase = head;

        var leftArmForward = (leftHand.position - leftArmBase.position).normalized;

        // Right arm
        var rightArmBase = Biped.GetBoneTransform(HumanBodyBones.RightShoulder);

        if (rightArmBase == null)
            rightArmBase = Biped.GetBoneTransform(HumanBodyBones.RightUpperArm);

        if (rightArmBase == null)
            rightArmBase = Biped.GetBoneTransform(HumanBodyBones.Neck);

        if (rightArmBase == null)
            rightArmBase = head;

        var rightArmForward = (rightHand.position - rightArmBase.position).normalized;

        LeftHandReference.position = leftHand.position;
        LeftHandReference.rotation = Quaternion.LookRotation(leftArmForward, Vector3.up);

        RightHandReference.position = rightHand.position;
        RightHandReference.rotation = Quaternion.LookRotation(rightArmForward, Vector3.up);
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
            Gizmos.DrawWireSphere(ComputePoint((Vector3.back + Vector3.down) * 0.035f), 0.075f);

            // View frustum
            Gizmos.matrix = Matrix4x4.TRS(ViewpointReference.position, ViewpointReference.rotation, Vector3.one);
            Gizmos.DrawFrustum(Vector3.zero, 90f, 1f, 0.01f, 1.25f);
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

        // Draw anchors
        var tooltip = transform.Find("Tooltip");

        if(tooltip != null)
        {
            Gizmos.color = new Color(1f, 0f, 1f);
            Gizmos.DrawLine(tooltip.position, tooltip.position + tooltip.forward * 0.05f);
            Gizmos.DrawSphere(tooltip.position, 0.01f);
        }

        var grabber = transform.Find("Grabber");

        if(grabber != null)
        {
            Gizmos.color = new Color(0.5f, 0f, 1f);
            Gizmos.DrawWireSphere(grabber.position, 0.05f);
        }

        var shelf = transform.Find("Shelf");

        if(shelf != null)
        {
            Gizmos.color = new Color(0.75f, 0f, 1f);
            Gizmos.matrix = Matrix4x4.TRS(shelf.position, shelf.rotation, Vector3.one);
            Gizmos.DrawWireCube(Vector3.zero, new Vector3(0.02f, 0.0025f, 0.04f));
            Gizmos.matrix = Matrix4x4.identity;
        }
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
