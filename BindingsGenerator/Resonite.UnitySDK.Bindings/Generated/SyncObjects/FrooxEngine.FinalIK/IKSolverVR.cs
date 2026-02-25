
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR
// Generated on: středa 25. února 2026 16:14:38
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
    public global::FrooxEngine.FinalIK.IKSolverVR.References BoneReferences;
public UnityEngine.Vector3[] defaultLocalPositions;
public UnityEngine.Quaternion[] defaultLocalRotations;
public global::System.Boolean DebugVisuals;
public global::System.Boolean PlantFeet;
public global::FrooxEngine.FinalIK.IKSolverVR.Spine spine;
public global::FrooxEngine.FinalIK.IKSolverVR.Arm leftArm;
public global::FrooxEngine.FinalIK.IKSolverVR.Arm rightArm;
public global::FrooxEngine.FinalIK.IKSolverVR.Leg leftLeg;
public global::FrooxEngine.FinalIK.IKSolverVR.Leg rightLeg;
public global::FrooxEngine.FinalIK.IKSolverVR.Locomotion locomotion;
public global::System.Boolean ForwardFlipped;
public global::System.Nullable<global::System.Single> ForceRootHeight;
public UnityEngine.Vector3 LocomotionPositionOffset;
public UnityEngine.Vector3 DefaultRootPosition;
public UnityEngine.Quaternion DefaultRootRotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneReferences", new ResoniteLink.SyncObject() { Members = BoneReferences.CollectMembers(context) });
members.Add("defaultLocalPositions", defaultLocalPositions.ToResoniteLinkArray());
members.Add("defaultLocalRotations", defaultLocalRotations.ToResoniteLinkArray());
members.Add("DebugVisuals", DebugVisuals.ToResoniteLinkField());
members.Add("PlantFeet", PlantFeet.ToResoniteLinkField());
members.Add("spine", new ResoniteLink.SyncObject() { Members = spine.CollectMembers(context) });
members.Add("leftArm", new ResoniteLink.SyncObject() { Members = leftArm.CollectMembers(context) });
members.Add("rightArm", new ResoniteLink.SyncObject() { Members = rightArm.CollectMembers(context) });
members.Add("leftLeg", new ResoniteLink.SyncObject() { Members = leftLeg.CollectMembers(context) });
members.Add("rightLeg", new ResoniteLink.SyncObject() { Members = rightLeg.CollectMembers(context) });
members.Add("locomotion", new ResoniteLink.SyncObject() { Members = locomotion.CollectMembers(context) });
members.Add("ForwardFlipped", ForwardFlipped.ToResoniteLinkField());
members.Add("ForceRootHeight", ForceRootHeight.ToResoniteLinkField());
members.Add("LocomotionPositionOffset", LocomotionPositionOffset.ToResoniteLinkField());
members.Add("DefaultRootPosition", DefaultRootPosition.ToResoniteLinkField());
members.Add("DefaultRootRotation", DefaultRootRotation.ToResoniteLinkField());
}

}
}
