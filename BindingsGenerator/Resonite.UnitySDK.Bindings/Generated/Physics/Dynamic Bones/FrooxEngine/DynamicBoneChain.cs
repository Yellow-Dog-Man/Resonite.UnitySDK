
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBoneChain
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBoneChain")]
public partial class DynamicBoneChain : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget, global::FrooxEngine.IDestroyBlock, global::FrooxEngine.IInteractionBlock, global::FrooxEngine.IDuplicateBlock

{
    public global::System.Single Inertia;
public global::System.Single InertiaForce;
public global::System.Single Damping;
public global::System.Single Elasticity;
public global::System.Single Stiffness;
public global::System.Boolean SimulateTerminalBones;
public global::System.Single BaseBoneRadius;
public global::System.Boolean DynamicPlayerCollision;
public global::System.Boolean CollideWithOwnBody;
public global::FrooxEngine.VibratePreset HandCollisionVibration;
public global::System.Boolean CollideWithHead;
public global::System.Boolean CollideWithBody;
public global::System.Boolean CollideWithLeftHand;
public global::System.Boolean CollideWithRightHand;
public UnityEngine.Vector3 Gravity;
public global::FrooxEngine.RootSpace GravitySpace;
public global::System.Boolean UseUserGravityDirection;
public UnityEngine.Vector3 LocalForce;
public global::System.Single GlobalStretch;
public global::System.Single MaxStretchRatio;
public global::System.Single CurrentStretchRatio;
public global::System.Single StretchRestoreSpeed;
public global::System.Boolean UseLocalUserSpace;
public global::FrooxEngine.RootSpace SimulationSpace;
public System.Collections.Generic.List<global::FrooxEngine.IDynamicBoneCollider> StaticColliders;
public global::System.Boolean VisualizeColliders;
public global::System.Boolean VisualizeBones;
public global::System.Boolean IsGrabbable;
public global::System.Boolean ActiveUserRootOnly;
public global::System.Boolean AllowSteal;
public global::System.Int32 GrabPriority;
public global::System.Boolean IgnoreGrabOnFirstBone;
public global::System.Single GrabRadiusTolerance;
public global::System.Single GrabReleaseDistance;
public global::System.Boolean GrabSlipping;
public global::System.Boolean GrabTerminalBones;
public global::FrooxEngine.VibratePreset GrabVibration;
public global::System.Boolean IgnoreOwnLeftHand;
public global::System.Boolean IgnoreOwnRightHand;
public global::FrooxEngine.Slot EffectorTarget;
public global::System.Int32 EffectorBoneIndex;
public UnityEngine.Vector3 EffectorBoneOffset;
public global::FrooxEngine.Grabber _activeGrabber;
public System.Collections.Generic.List<global::FrooxEngine.DynamicBoneChain.Bone> Bones;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Inertia", Inertia.ToResoniteLinkField());
members.Add("InertiaForce", InertiaForce.ToResoniteLinkField());
members.Add("Damping", Damping.ToResoniteLinkField());
members.Add("Elasticity", Elasticity.ToResoniteLinkField());
members.Add("Stiffness", Stiffness.ToResoniteLinkField());
members.Add("SimulateTerminalBones", SimulateTerminalBones.ToResoniteLinkField());
members.Add("BaseBoneRadius", BaseBoneRadius.ToResoniteLinkField());
members.Add("DynamicPlayerCollision", DynamicPlayerCollision.ToResoniteLinkField());
members.Add("CollideWithOwnBody", CollideWithOwnBody.ToResoniteLinkField());
members.Add("HandCollisionVibration", HandCollisionVibration.ToResoniteLinkField());
members.Add("CollideWithHead", CollideWithHead.ToResoniteLinkField());
members.Add("CollideWithBody", CollideWithBody.ToResoniteLinkField());
members.Add("CollideWithLeftHand", CollideWithLeftHand.ToResoniteLinkField());
members.Add("CollideWithRightHand", CollideWithRightHand.ToResoniteLinkField());
members.Add("Gravity", Gravity.ToResoniteLinkField());
members.Add("GravitySpace", new ResoniteLink.SyncObject() { Members = GravitySpace.CollectMembers(context) });
members.Add("UseUserGravityDirection", UseUserGravityDirection.ToResoniteLinkField());
members.Add("LocalForce", LocalForce.ToResoniteLinkField());
members.Add("GlobalStretch", GlobalStretch.ToResoniteLinkField());
members.Add("MaxStretchRatio", MaxStretchRatio.ToResoniteLinkField());
members.Add("CurrentStretchRatio", CurrentStretchRatio.ToResoniteLinkField());
members.Add("StretchRestoreSpeed", StretchRestoreSpeed.ToResoniteLinkField());
members.Add("UseLocalUserSpace", UseLocalUserSpace.ToResoniteLinkField());
members.Add("SimulationSpace", new ResoniteLink.SyncObject() { Members = SimulationSpace.CollectMembers(context) });
members.Add("StaticColliders", new ResoniteLink.SyncList()
{
    Elements = StaticColliders.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("VisualizeColliders", VisualizeColliders.ToResoniteLinkField());
members.Add("VisualizeBones", VisualizeBones.ToResoniteLinkField());
members.Add("IsGrabbable", IsGrabbable.ToResoniteLinkField());
members.Add("ActiveUserRootOnly", ActiveUserRootOnly.ToResoniteLinkField());
members.Add("AllowSteal", AllowSteal.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority.ToResoniteLinkField());
members.Add("IgnoreGrabOnFirstBone", IgnoreGrabOnFirstBone.ToResoniteLinkField());
members.Add("GrabRadiusTolerance", GrabRadiusTolerance.ToResoniteLinkField());
members.Add("GrabReleaseDistance", GrabReleaseDistance.ToResoniteLinkField());
members.Add("GrabSlipping", GrabSlipping.ToResoniteLinkField());
members.Add("GrabTerminalBones", GrabTerminalBones.ToResoniteLinkField());
members.Add("GrabVibration", GrabVibration.ToResoniteLinkField());
members.Add("IgnoreOwnLeftHand", IgnoreOwnLeftHand.ToResoniteLinkField());
members.Add("IgnoreOwnRightHand", IgnoreOwnRightHand.ToResoniteLinkField());
members.Add("EffectorTarget", EffectorTarget.ToResoniteReference(context));
members.Add("EffectorBoneIndex", EffectorBoneIndex.ToResoniteLinkField());
members.Add("EffectorBoneOffset", EffectorBoneOffset.ToResoniteLinkField());
members.Add("_activeGrabber", _activeGrabber.ToResoniteReference(context));
members.Add("Bones", new ResoniteLink.SyncList()
{
    Elements = Bones.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
