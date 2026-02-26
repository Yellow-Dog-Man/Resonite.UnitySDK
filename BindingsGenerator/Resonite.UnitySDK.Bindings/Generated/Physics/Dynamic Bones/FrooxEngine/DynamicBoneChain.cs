
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBoneChain
// Generated on: čtvrtek 26. února 2026 15:08:03
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single Inertia { get => Inertia_Element.Data; set => Inertia_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Inertia_Element = new();
public global::System.Single InertiaForce { get => InertiaForce_Element.Data; set => InertiaForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InertiaForce_Element = new();
public global::System.Single Damping { get => Damping_Element.Data; set => Damping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Damping_Element = new();
public global::System.Single Elasticity { get => Elasticity_Element.Data; set => Elasticity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Elasticity_Element = new();
public global::System.Single Stiffness { get => Stiffness_Element.Data; set => Stiffness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Stiffness_Element = new();
public global::System.Boolean SimulateTerminalBones { get => SimulateTerminalBones_Element.Data; set => SimulateTerminalBones_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SimulateTerminalBones_Element = new();
public global::System.Single BaseBoneRadius { get => BaseBoneRadius_Element.Data; set => BaseBoneRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseBoneRadius_Element = new();
public global::System.Boolean DynamicPlayerCollision { get => DynamicPlayerCollision_Element.Data; set => DynamicPlayerCollision_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DynamicPlayerCollision_Element = new();
public global::System.Boolean CollideWithOwnBody { get => CollideWithOwnBody_Element.Data; set => CollideWithOwnBody_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CollideWithOwnBody_Element = new();
public global::FrooxEngine.VibratePreset HandCollisionVibration { get => HandCollisionVibration_Element.Data; set => HandCollisionVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> HandCollisionVibration_Element = new();
public global::System.Boolean CollideWithHead { get => CollideWithHead_Element.Data; set => CollideWithHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CollideWithHead_Element = new();
public global::System.Boolean CollideWithBody { get => CollideWithBody_Element.Data; set => CollideWithBody_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CollideWithBody_Element = new();
public global::System.Boolean CollideWithLeftHand { get => CollideWithLeftHand_Element.Data; set => CollideWithLeftHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CollideWithLeftHand_Element = new();
public global::System.Boolean CollideWithRightHand { get => CollideWithRightHand_Element.Data; set => CollideWithRightHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CollideWithRightHand_Element = new();
public UnityEngine.Vector3 Gravity { get => Gravity_Element.Data; set => Gravity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Gravity_Element = new();
public global::FrooxEngine.RootSpace GravitySpace = new();
public global::System.Boolean UseUserGravityDirection { get => UseUserGravityDirection_Element.Data; set => UseUserGravityDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseUserGravityDirection_Element = new();
public UnityEngine.Vector3 LocalForce { get => LocalForce_Element.Data; set => LocalForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalForce_Element = new();
public global::System.Single GlobalStretch { get => GlobalStretch_Element.Data; set => GlobalStretch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GlobalStretch_Element = new();
public global::System.Single MaxStretchRatio { get => MaxStretchRatio_Element.Data; set => MaxStretchRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxStretchRatio_Element = new();
public global::System.Single CurrentStretchRatio { get => CurrentStretchRatio_Element.Data; set => CurrentStretchRatio_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CurrentStretchRatio_Element = new();
public global::System.Single StretchRestoreSpeed { get => StretchRestoreSpeed_Element.Data; set => StretchRestoreSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StretchRestoreSpeed_Element = new();
public global::System.Boolean UseLocalUserSpace { get => UseLocalUserSpace_Element.Data; set => UseLocalUserSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLocalUserSpace_Element = new();
public global::FrooxEngine.RootSpace SimulationSpace = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IDynamicBoneCollider>, global::FrooxEngine.IDynamicBoneCollider, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IDynamicBoneCollider>, global::FrooxEngine.IDynamicBoneCollider>> StaticColliders = new();
public global::System.Boolean VisualizeColliders { get => VisualizeColliders_Element.Data; set => VisualizeColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VisualizeColliders_Element = new();
public global::System.Boolean VisualizeBones { get => VisualizeBones_Element.Data; set => VisualizeBones_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VisualizeBones_Element = new();
public global::System.Boolean IsGrabbable { get => IsGrabbable_Element.Data; set => IsGrabbable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsGrabbable_Element = new();
public global::System.Boolean ActiveUserRootOnly { get => ActiveUserRootOnly_Element.Data; set => ActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ActiveUserRootOnly_Element = new();
public global::System.Boolean AllowSteal { get => AllowSteal_Element.Data; set => AllowSteal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSteal_Element = new();
public global::System.Int32 GrabPriority { get => GrabPriority_Element.Data; set => GrabPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GrabPriority_Element = new();
public global::System.Boolean IgnoreGrabOnFirstBone { get => IgnoreGrabOnFirstBone_Element.Data; set => IgnoreGrabOnFirstBone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreGrabOnFirstBone_Element = new();
public global::System.Single GrabRadiusTolerance { get => GrabRadiusTolerance_Element.Data; set => GrabRadiusTolerance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrabRadiusTolerance_Element = new();
public global::System.Single GrabReleaseDistance { get => GrabReleaseDistance_Element.Data; set => GrabReleaseDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrabReleaseDistance_Element = new();
public global::System.Boolean GrabSlipping { get => GrabSlipping_Element.Data; set => GrabSlipping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GrabSlipping_Element = new();
public global::System.Boolean GrabTerminalBones { get => GrabTerminalBones_Element.Data; set => GrabTerminalBones_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GrabTerminalBones_Element = new();
public global::FrooxEngine.VibratePreset GrabVibration { get => GrabVibration_Element.Data; set => GrabVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> GrabVibration_Element = new();
public global::System.Boolean IgnoreOwnLeftHand { get => IgnoreOwnLeftHand_Element.Data; set => IgnoreOwnLeftHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreOwnLeftHand_Element = new();
public global::System.Boolean IgnoreOwnRightHand { get => IgnoreOwnRightHand_Element.Data; set => IgnoreOwnRightHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreOwnRightHand_Element = new();
public global::FrooxEngine.Slot EffectorTarget { get => EffectorTarget_Element.Data; set => EffectorTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> EffectorTarget_Element = new();
public global::System.Int32 EffectorBoneIndex { get => EffectorBoneIndex_Element.Data; set => EffectorBoneIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EffectorBoneIndex_Element = new();
public UnityEngine.Vector3 EffectorBoneOffset { get => EffectorBoneOffset_Element.Data; set => EffectorBoneOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> EffectorBoneOffset_Element = new();
public global::FrooxEngine.Grabber _activeGrabber { get => _activeGrabber_Element.Data; set => _activeGrabber_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _activeGrabber_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DynamicBoneChain.Bone>, global::FrooxEngine.DynamicBoneChain.Bone> Bones = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Inertia", Inertia_Element.ToLinkField(context));
members.Add("InertiaForce", InertiaForce_Element.ToLinkField(context));
members.Add("Damping", Damping_Element.ToLinkField(context));
members.Add("Elasticity", Elasticity_Element.ToLinkField(context));
members.Add("Stiffness", Stiffness_Element.ToLinkField(context));
members.Add("SimulateTerminalBones", SimulateTerminalBones_Element.ToLinkField(context));
members.Add("BaseBoneRadius", BaseBoneRadius_Element.ToLinkField(context));
members.Add("DynamicPlayerCollision", DynamicPlayerCollision_Element.ToLinkField(context));
members.Add("CollideWithOwnBody", CollideWithOwnBody_Element.ToLinkField(context));
members.Add("HandCollisionVibration", HandCollisionVibration_Element.ToLinkField(context));
members.Add("CollideWithHead", CollideWithHead_Element.ToLinkField(context));
members.Add("CollideWithBody", CollideWithBody_Element.ToLinkField(context));
members.Add("CollideWithLeftHand", CollideWithLeftHand_Element.ToLinkField(context));
members.Add("CollideWithRightHand", CollideWithRightHand_Element.ToLinkField(context));
members.Add("Gravity", Gravity_Element.ToLinkField(context));
members.Add("GravitySpace", GravitySpace.ToLinkSyncObject(context));
members.Add("UseUserGravityDirection", UseUserGravityDirection_Element.ToLinkField(context));
members.Add("LocalForce", LocalForce_Element.ToLinkField(context));
members.Add("GlobalStretch", GlobalStretch_Element.ToLinkField(context));
members.Add("MaxStretchRatio", MaxStretchRatio_Element.ToLinkField(context));
members.Add("CurrentStretchRatio", CurrentStretchRatio_Element.ToLinkField(context));
members.Add("StretchRestoreSpeed", StretchRestoreSpeed_Element.ToLinkField(context));
members.Add("UseLocalUserSpace", UseLocalUserSpace_Element.ToLinkField(context));
members.Add("SimulationSpace", SimulationSpace.ToLinkSyncObject(context));
members.Add("StaticColliders", StaticColliders.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("VisualizeColliders", VisualizeColliders_Element.ToLinkField(context));
members.Add("VisualizeBones", VisualizeBones_Element.ToLinkField(context));
members.Add("IsGrabbable", IsGrabbable_Element.ToLinkField(context));
members.Add("ActiveUserRootOnly", ActiveUserRootOnly_Element.ToLinkField(context));
members.Add("AllowSteal", AllowSteal_Element.ToLinkField(context));
members.Add("GrabPriority", GrabPriority_Element.ToLinkField(context));
members.Add("IgnoreGrabOnFirstBone", IgnoreGrabOnFirstBone_Element.ToLinkField(context));
members.Add("GrabRadiusTolerance", GrabRadiusTolerance_Element.ToLinkField(context));
members.Add("GrabReleaseDistance", GrabReleaseDistance_Element.ToLinkField(context));
members.Add("GrabSlipping", GrabSlipping_Element.ToLinkField(context));
members.Add("GrabTerminalBones", GrabTerminalBones_Element.ToLinkField(context));
members.Add("GrabVibration", GrabVibration_Element.ToLinkField(context));
members.Add("IgnoreOwnLeftHand", IgnoreOwnLeftHand_Element.ToLinkField(context));
members.Add("IgnoreOwnRightHand", IgnoreOwnRightHand_Element.ToLinkField(context));
members.Add("EffectorTarget", EffectorTarget_Element.ToLinkReference(context));
members.Add("EffectorBoneIndex", EffectorBoneIndex_Element.ToLinkField(context));
members.Add("EffectorBoneOffset", EffectorBoneOffset_Element.ToLinkField(context));
members.Add("_activeGrabber", _activeGrabber_Element.ToLinkReference(context));
members.Add("Bones", Bones.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
