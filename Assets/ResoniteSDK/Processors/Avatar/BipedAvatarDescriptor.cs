using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BipedAvatarDescriptor : MonoBehaviour, IResoniteLinkPostProcessor
{
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
}
