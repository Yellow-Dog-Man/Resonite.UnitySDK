using System;
using System.Threading.Tasks;
using UnityEngine;

public class BipedAvatarDescriptor : MonoBehaviour, IConversionPostProcessor
{
    const float AXIS_LENGTH = 0.25f;

    public bool IsValid => Biped != null && HeadReference != null && LeftHandReference != null && RightHandReference != null;

    [NonSerialized]
    public bool AvatarConverted;

    public Animator Biped;

    public Transform HeadReference;
    public Transform LeftHandReference;
    public Transform RightHandReference;

    public Transform LeftFootReference;
    public Transform RightFootReference;
    public Transform HipsReference;

    public bool SetupProtection = true;
    public bool SetupEyes = true;
    public bool SetupFaceTracking = true;
    public bool SetupVolumeMeter = false;

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

        var headSlot = HeadReference.GetSlot();
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
        if (HeadReference != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(HeadReference.position, 0.1f);
            DrawAxes(HeadReference);
        }

        if (LeftHandReference != null)
            DrawHand(LeftHandReference, Color.cyan);

        if (RightHandReference != null)
            DrawHand(RightHandReference, Color.red);
    }

    void DrawHand(Transform transform, Color handColor)
    {
        Gizmos.color = handColor;
        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(0.05f, 0.01f, 0.1f));
        Gizmos.matrix = Matrix4x4.identity;

        DrawAxes(transform);
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
