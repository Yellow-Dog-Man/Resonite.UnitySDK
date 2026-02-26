
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR
// Generated on: čtvrtek 26. února 2026 10:04:45
// Resonite version: 2026.2.25.455
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
members.Add("BoneReferences", new ResoniteLink.SyncObject() { Members = BoneReferences.CollectMembers(context) });
members.Add("defaultLocalPositions", defaultLocalPositions.Data.ToResoniteLinkArray());
members.Add("defaultLocalRotations", defaultLocalRotations.Data.ToResoniteLinkArray());
members.Add("DebugVisuals", DebugVisuals_Element.Data.ToResoniteLinkField());
members.Add("PlantFeet", PlantFeet_Element.Data.ToResoniteLinkField());
members.Add("spine", new ResoniteLink.SyncObject() { Members = spine.CollectMembers(context) });
members.Add("leftArm", new ResoniteLink.SyncObject() { Members = leftArm.CollectMembers(context) });
members.Add("rightArm", new ResoniteLink.SyncObject() { Members = rightArm.CollectMembers(context) });
members.Add("leftLeg", new ResoniteLink.SyncObject() { Members = leftLeg.CollectMembers(context) });
members.Add("rightLeg", new ResoniteLink.SyncObject() { Members = rightLeg.CollectMembers(context) });
members.Add("locomotion", new ResoniteLink.SyncObject() { Members = locomotion.CollectMembers(context) });
members.Add("ForwardFlipped", ForwardFlipped_Element.Data.ToResoniteLinkField());
members.Add("ForceRootHeight", ForceRootHeight_Element.Data.ToResoniteLinkField());
members.Add("LocomotionPositionOffset", LocomotionPositionOffset_Element.Data.ToResoniteLinkField());
members.Add("DefaultRootPosition", DefaultRootPosition_Element.Data.ToResoniteLinkField());
members.Add("DefaultRootRotation", DefaultRootRotation_Element.Data.ToResoniteLinkField());
}

}
}
