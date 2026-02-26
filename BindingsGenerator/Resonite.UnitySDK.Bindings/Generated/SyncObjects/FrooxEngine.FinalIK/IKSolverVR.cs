
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR
// Generated on: čtvrtek 26. února 2026 12:28:11
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR")]
public partial class IKSolverVR : global::FrooxEngine.FinalIK.IKSolver

{
    public global::FrooxEngine.FinalIK.IKSolverVR.References BoneReferences = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> defaultLocalPositions = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Quaternion>, UnityEngine.Quaternion> defaultLocalRotations = new();
public global::System.Boolean DebugVisuals { get => DebugVisuals_Element.Data; set => DebugVisuals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DebugVisuals_Element = new();
public global::System.Boolean PlantFeet { get => PlantFeet_Element.Data; set => PlantFeet_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PlantFeet_Element = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Spine spine = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Arm leftArm = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Arm rightArm = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Leg leftLeg = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Leg rightLeg = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Locomotion locomotion = new();
public global::System.Boolean ForwardFlipped { get => ForwardFlipped_Element.Data; set => ForwardFlipped_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForwardFlipped_Element = new();
public global::System.Nullable<global::System.Single> ForceRootHeight { get => ForceRootHeight_Element.Data; set => ForceRootHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ForceRootHeight_Element = new();
public UnityEngine.Vector3 LocomotionPositionOffset { get => LocomotionPositionOffset_Element.Data; set => LocomotionPositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocomotionPositionOffset_Element = new();
public UnityEngine.Vector3 DefaultRootPosition { get => DefaultRootPosition_Element.Data; set => DefaultRootPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> DefaultRootPosition_Element = new();
public UnityEngine.Quaternion DefaultRootRotation { get => DefaultRootRotation_Element.Data; set => DefaultRootRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> DefaultRootRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneReferences", BoneReferences.ToLinkSyncObject(context));
members.Add("defaultLocalPositions", defaultLocalPositions.ToLinkArray(context));
members.Add("defaultLocalRotations", defaultLocalRotations.ToLinkArray(context));
members.Add("DebugVisuals", DebugVisuals_Element.ToLinkField(context));
members.Add("PlantFeet", PlantFeet_Element.ToLinkField(context));
members.Add("spine", spine.ToLinkSyncObject(context));
members.Add("leftArm", leftArm.ToLinkSyncObject(context));
members.Add("rightArm", rightArm.ToLinkSyncObject(context));
members.Add("leftLeg", leftLeg.ToLinkSyncObject(context));
members.Add("rightLeg", rightLeg.ToLinkSyncObject(context));
members.Add("locomotion", locomotion.ToLinkSyncObject(context));
members.Add("ForwardFlipped", ForwardFlipped_Element.ToLinkField(context));
members.Add("ForceRootHeight", ForceRootHeight_Element.ToLinkField(context));
members.Add("LocomotionPositionOffset", LocomotionPositionOffset_Element.ToLinkField(context));
members.Add("DefaultRootPosition", DefaultRootPosition_Element.ToLinkField(context));
members.Add("DefaultRootRotation", DefaultRootRotation_Element.ToLinkField(context));
}

}
}
