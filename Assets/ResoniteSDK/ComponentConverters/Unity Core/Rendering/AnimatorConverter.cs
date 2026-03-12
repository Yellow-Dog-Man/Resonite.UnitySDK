using FrooxEngine;
using Renderite.Shared;
using UnityEngine;

public static class BipedRigHelper
{
    public static void SetFrom(this BipedRig rig, UnityEngine.Animator animator)
    {
        var avatar = animator.avatar;

        if (!avatar.isValid)
            throw new System.ArgumentException("Avatar must be valid");

        if (!avatar.isHuman)
            throw new System.ArgumentException("Avatar must be a humanoid");

        var human = avatar.humanDescription;

        void TrySetBone(BodyNode engine, HumanBodyBones unity)
        {
            var bone = animator.GetBoneTransform(unity);

            if (bone == null)
                rig.Bones.Remove(engine);
            else
                rig.Bones.GetOrAdd(engine).Data = bone.GetSlot();
        }

        TrySetBone(BodyNode.Hips, HumanBodyBones.Hips);
        TrySetBone(BodyNode.Spine, HumanBodyBones.Spine);
        TrySetBone(BodyNode.Chest, HumanBodyBones.Chest);
        TrySetBone(BodyNode.UpperChest, HumanBodyBones.UpperChest);
        TrySetBone(BodyNode.Neck, HumanBodyBones.Neck);
        TrySetBone(BodyNode.Head, HumanBodyBones.Head);

        TrySetBone(BodyNode.Jaw, HumanBodyBones.Jaw);

        TrySetBone(BodyNode.LeftEye, HumanBodyBones.LeftEye);
        TrySetBone(BodyNode.RightEye, HumanBodyBones.RightEye);

        TrySetBone(BodyNode.LeftShoulder, HumanBodyBones.LeftShoulder);
        TrySetBone(BodyNode.LeftUpperArm, HumanBodyBones.LeftUpperArm);
        TrySetBone(BodyNode.LeftLowerArm, HumanBodyBones.LeftLowerArm);
        TrySetBone(BodyNode.LeftHand, HumanBodyBones.LeftHand);

        TrySetBone(BodyNode.RightShoulder, HumanBodyBones.RightShoulder);
        TrySetBone(BodyNode.RightUpperArm, HumanBodyBones.RightUpperArm);
        TrySetBone(BodyNode.RightLowerArm, HumanBodyBones.RightLowerArm);
        TrySetBone(BodyNode.RightHand, HumanBodyBones.RightHand);

        TrySetBone(BodyNode.LeftUpperLeg, HumanBodyBones.LeftUpperLeg);
        TrySetBone(BodyNode.LeftLowerLeg, HumanBodyBones.LeftLowerLeg);
        TrySetBone(BodyNode.LeftFoot, HumanBodyBones.LeftFoot);
        TrySetBone(BodyNode.LeftToes, HumanBodyBones.LeftToes);

        TrySetBone(BodyNode.RightUpperLeg, HumanBodyBones.RightUpperLeg);
        TrySetBone(BodyNode.RightLowerLeg, HumanBodyBones.RightLowerLeg);
        TrySetBone(BodyNode.RightFoot, HumanBodyBones.RightFoot);
        TrySetBone(BodyNode.RightToes, HumanBodyBones.RightToes);

        // TODO!!! We don't have Intermediate thumb body node, because this bone doesn't really exist
        // Should we handle it somehow? Do fallback or something?

        TrySetBone(BodyNode.LeftThumb_Proximal, HumanBodyBones.LeftThumbProximal);
        TrySetBone(BodyNode.LeftThumb_Distal, HumanBodyBones.LeftThumbDistal);

        TrySetBone(BodyNode.LeftIndexFinger_Proximal, HumanBodyBones.LeftIndexProximal);
        TrySetBone(BodyNode.LeftIndexFinger_Intermediate, HumanBodyBones.LeftIndexIntermediate);
        TrySetBone(BodyNode.LeftIndexFinger_Distal, HumanBodyBones.LeftIndexDistal);

        TrySetBone(BodyNode.LeftMiddleFinger_Proximal, HumanBodyBones.LeftMiddleProximal);
        TrySetBone(BodyNode.LeftMiddleFinger_Intermediate, HumanBodyBones.LeftMiddleIntermediate);
        TrySetBone(BodyNode.LeftMiddleFinger_Distal, HumanBodyBones.LeftMiddleDistal);

        TrySetBone(BodyNode.LeftRingFinger_Proximal, HumanBodyBones.LeftRingProximal);
        TrySetBone(BodyNode.LeftRingFinger_Intermediate, HumanBodyBones.LeftRingIntermediate);
        TrySetBone(BodyNode.LeftRingFinger_Distal, HumanBodyBones.LeftRingDistal);

        TrySetBone(BodyNode.LeftPinky_Proximal, HumanBodyBones.LeftLittleProximal);
        TrySetBone(BodyNode.LeftPinky_Intermediate, HumanBodyBones.LeftLittleIntermediate);
        TrySetBone(BodyNode.LeftPinky_Distal, HumanBodyBones.LeftLittleDistal);

        // Right
        TrySetBone(BodyNode.RightThumb_Proximal, HumanBodyBones.RightThumbProximal);
        TrySetBone(BodyNode.RightThumb_Distal, HumanBodyBones.RightThumbDistal);

        TrySetBone(BodyNode.RightIndexFinger_Proximal, HumanBodyBones.RightIndexProximal);
        TrySetBone(BodyNode.RightIndexFinger_Intermediate, HumanBodyBones.RightIndexIntermediate);
        TrySetBone(BodyNode.RightIndexFinger_Distal, HumanBodyBones.RightIndexDistal);

        TrySetBone(BodyNode.RightMiddleFinger_Proximal, HumanBodyBones.RightMiddleProximal);
        TrySetBone(BodyNode.RightMiddleFinger_Intermediate, HumanBodyBones.RightMiddleIntermediate);
        TrySetBone(BodyNode.RightMiddleFinger_Distal, HumanBodyBones.RightMiddleDistal);

        TrySetBone(BodyNode.RightRingFinger_Proximal, HumanBodyBones.RightRingProximal);
        TrySetBone(BodyNode.RightRingFinger_Intermediate, HumanBodyBones.RightRingIntermediate);
        TrySetBone(BodyNode.RightRingFinger_Distal, HumanBodyBones.RightRingDistal);

        TrySetBone(BodyNode.RightPinky_Proximal, HumanBodyBones.RightLittleProximal);
        TrySetBone(BodyNode.RightPinky_Intermediate, HumanBodyBones.RightLittleIntermediate);
        TrySetBone(BodyNode.RightPinky_Distal, HumanBodyBones.RightLittleDistal);
    }
}

public class AnimatorConverter : ResoniteComponentConverter<UnityEngine.Animator>
{
    public BipedRigWrapper BipedRig;

    protected override void UpdateConversion(UnityEngine.Animator target, IConversionContext context)
    {
        if (target.avatar != null && target.avatar.isValid && target.avatar.isHuman)
        {
            if (BipedRig == null)
                BipedRig = gameObject.AddComponent<BipedRigWrapper>();

            BipedRig.Data.SetFrom(target);
        }
        else if (BipedRig != null)
            DestroyImmediate(BipedRig);
    }

    protected override void Cleanup()
    {
        if (BipedRig != null)
            DestroyImmediate(BipedRig);
    }
}