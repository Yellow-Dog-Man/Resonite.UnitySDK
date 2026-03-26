using System;
using System.Linq;
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

    void CreateOptionalReferenceSlots(Transform referencesParent)
    {
        if (Biped == null || Biped.avatar == null || !Biped.avatar.isHuman)
            return;

        // TODO!!! This is currently not used, because the computation is wrong for most avatars
        // The references need to have the Z axis be actual forward, but they just take the transform of the bone
        // which is not guaranteed to have Z be actual forward
        // The purpose of the referecens is to tell the system what the actual alignment of the bone is, so using
        // the bone alignment works if and only if the bone is already perfectly aligned
        // This needs to be reworked to actually compute the directions and then compute proper alignment from that

        var skeletonUp = ComputeSkeletonUp();
        var skeletonForward = ComputeSkeletonForward(skeletonUp);

        if (LeftFootReference == null)
        {
            var leftFoot = new GameObject("Left Foot");
            leftFoot.transform.SetParent(referencesParent, false);
            LeftFootReference = leftFoot.transform;
            AlignReferenceSlotToSkeleton(LeftFootReference, HumanBodyBones.LeftFoot, skeletonUp, skeletonForward);
        }

        if (RightFootReference == null)
        {
            var rightFoot = new GameObject("Right Foot");
            rightFoot.transform.SetParent(referencesParent, false);
            RightFootReference = rightFoot.transform;
            AlignReferenceSlotToSkeleton(RightFootReference, HumanBodyBones.RightFoot, skeletonUp, skeletonForward);
        }

        if (HipsReference == null)
        {
            var hips = new GameObject("Hips");
            hips.transform.SetParent(referencesParent, false);
            HipsReference = hips.transform;
            AlignReferenceSlotToSkeleton(HipsReference, HumanBodyBones.Hips, skeletonUp, skeletonForward);
        }
    }

    Vector3 ComputeSkeletonUp()
    {
        var hipsBone = Biped.GetBoneTransform(HumanBodyBones.Hips);
        var spineBone = Biped.GetBoneTransform(HumanBodyBones.Spine);

        if (hipsBone != null && spineBone != null)
            return (spineBone.position - hipsBone.position).normalized;

        return Vector3.up;
    }

    Vector3 ComputeSkeletonForward(Vector3 skeletonUp)
    {
        var headBone = Biped.GetBoneTransform(HumanBodyBones.Head);
        if (headBone == null)
            return Vector3.forward;

        var leftEye = Biped.GetBoneTransform(HumanBodyBones.LeftEye);
        var rightEye = Biped.GetBoneTransform(HumanBodyBones.RightEye);

        Vector3 headForward;
        if (leftEye != null && rightEye != null)
        {
            var averageEyePosition = (leftEye.position + rightEye.position) * 0.5f;
            headForward = averageEyePosition - headBone.position;
        }
        else
        {
            headForward = headBone.forward;
        }

        var flattenedForward = Vector3.ProjectOnPlane(headForward, skeletonUp).normalized;
        if (flattenedForward.sqrMagnitude < 0.001f)
            return Vector3.forward;

        return flattenedForward;
    }

    void AlignReferenceSlotToSkeleton(Transform referenceSlot, HumanBodyBones bone, Vector3 skeletonUp, Vector3 skeletonForward)
    {
        var boneTransform = Biped.GetBoneTransform(bone);
        if (boneTransform == null) return;

        referenceSlot.position = boneTransform.position;
        referenceSlot.rotation = Quaternion.LookRotation(skeletonForward, skeletonUp);
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

    public void RepositionOptionalReference(Transform generatedSlot, Transform targetBone)
    {
        if (generatedSlot == null || targetBone == null)
            return;

        if (generatedSlot == targetBone)
            return;

        generatedSlot.position = targetBone.position;
    }

    public void TryAutoPositionToolAnchors()
    {
        if (Biped == null || Biped.avatar == null || !Biped.avatar.isHuman)
            return;

        if (LeftHandReference != null)
            PositionHandToolAnchors(LeftHandReference, isRightHand: false);

        if (RightHandReference != null)
            PositionHandToolAnchors(RightHandReference, isRightHand: true);
    }

    void PositionHandToolAnchors(Transform handReferenceRoot, bool isRightHand)
    {
        var indexDistal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexDistal : HumanBodyBones.LeftIndexDistal);
        var middleDistal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightMiddleDistal : HumanBodyBones.LeftMiddleDistal);
        var ringDistal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightRingDistal : HumanBodyBones.LeftRingDistal);
        var pinkyDistal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightLittleDistal : HumanBodyBones.LeftLittleDistal);

        var indexProximal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexProximal : HumanBodyBones.LeftIndexProximal);
        var middleProximal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightMiddleProximal : HumanBodyBones.LeftMiddleProximal);
        var ringProximal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightRingProximal : HumanBodyBones.LeftRingProximal);
        var pinkyProximal = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightLittleProximal : HumanBodyBones.LeftLittleProximal);

        var indexIntermediate = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightIndexIntermediate : HumanBodyBones.LeftIndexIntermediate);
        var handBone = Biped.GetBoneTransform(isRightHand ? HumanBodyBones.RightHand : HumanBodyBones.LeftHand);

        PositionTooltipAtIndexFingertip(handReferenceRoot, indexDistal, indexIntermediate, indexProximal, handBone);
        PositionGrabberAtPalmCenter(handReferenceRoot, handBone,
            new[] { indexDistal, middleDistal, ringDistal, pinkyDistal },
            new[] { indexProximal, middleProximal, ringProximal, pinkyProximal });
        PositionShelfAboveGrabber(handReferenceRoot);
    }

    void PositionTooltipAtIndexFingertip(Transform handReferenceRoot, Transform indexDistalBone, Transform indexIntermediateBone, Transform indexProximalBone, Transform handBone)
    {
        var tooltip = handReferenceRoot.Find("Tooltip");
        if (tooltip == null || indexDistalBone == null)
            return;

        Vector3 fingerForward;

        if (indexIntermediateBone != null)
        {
            fingerForward = (indexDistalBone.position - indexIntermediateBone.position).normalized;
            float distalLength = Vector3.Distance(indexIntermediateBone.position, indexDistalBone.position);
            tooltip.position = indexDistalBone.position + fingerForward * distalLength;
        }
        else if (indexProximalBone != null)
        {
            fingerForward = (indexDistalBone.position - indexProximalBone.position).normalized;
            tooltip.position = indexDistalBone.position;
        }
        else
        {
            fingerForward = indexDistalBone.forward;
            tooltip.position = indexDistalBone.position;
        }

        var upDirection = handBone != null ? handBone.up : Vector3.up;
        if (Mathf.Abs(Vector3.Dot(fingerForward, upDirection)) > 0.95f)
            upDirection = handBone != null ? handBone.forward : Vector3.forward;

        tooltip.rotation = Quaternion.LookRotation(fingerForward, upDirection);
    }

    void PositionGrabberAtPalmCenter(Transform handReferenceRoot, Transform handBone, Transform[] fingerTips, Transform[] fingerBases)
    {
        var grabber = handReferenceRoot.Find("Grabber");
        if (grabber == null || handBone == null)
            return;

        var validTips = fingerTips.Where(b => b != null).ToArray();
        var validBases = fingerBases.Where(b => b != null).ToArray();

        if (validTips.Length > 0 && validBases.Length > 0)
        {
            var averageTipPosition = validTips.Aggregate(Vector3.zero, (sum, b) => sum + b.position) / validTips.Length;
            var averageBasePosition = validBases.Aggregate(Vector3.zero, (sum, b) => sum + b.position) / validBases.Length;

            grabber.position = Vector3.Lerp(averageTipPosition, averageBasePosition, 0.65f);
            var palmToFingers = (averageTipPosition - averageBasePosition).normalized;
            grabber.rotation = Quaternion.LookRotation(palmToFingers, Vector3.up);
        }
        else
        {
            grabber.position = handBone.position + handBone.forward * 0.05f;
        }
    }

    void PositionShelfAboveGrabber(Transform handReferenceRoot)
    {
        var shelf = handReferenceRoot.Find("Shelf");
        var grabber = handReferenceRoot.Find("Grabber");
        if (shelf == null || grabber == null)
            return;

        shelf.position = grabber.position + Vector3.up * 0.04f - grabber.forward * 0.03f;
        shelf.rotation = grabber.rotation;
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
