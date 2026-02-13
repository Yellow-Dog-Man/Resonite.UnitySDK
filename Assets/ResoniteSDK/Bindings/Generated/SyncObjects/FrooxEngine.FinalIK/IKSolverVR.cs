
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BoneReferences", new ResoniteLink.SyncObject() { Members = BoneReferences.CollectMembers() });
members.Add("defaultLocalPositions", defaultLocalPositions.ToResoniteLinkArray());
members.Add("defaultLocalRotations", defaultLocalRotations.ToResoniteLinkArray());
members.Add("DebugVisuals", DebugVisuals.ToResoniteLinkField());
members.Add("PlantFeet", PlantFeet.ToResoniteLinkField());
members.Add("spine", new ResoniteLink.SyncObject() { Members = spine.CollectMembers() });
members.Add("leftArm", new ResoniteLink.SyncObject() { Members = leftArm.CollectMembers() });
members.Add("rightArm", new ResoniteLink.SyncObject() { Members = rightArm.CollectMembers() });
members.Add("leftLeg", new ResoniteLink.SyncObject() { Members = leftLeg.CollectMembers() });
members.Add("rightLeg", new ResoniteLink.SyncObject() { Members = rightLeg.CollectMembers() });
members.Add("locomotion", new ResoniteLink.SyncObject() { Members = locomotion.CollectMembers() });
members.Add("ForwardFlipped", ForwardFlipped.ToResoniteLinkField());
members.Add("ForceRootHeight", ForceRootHeight.ToResoniteLinkField());
members.Add("LocomotionPositionOffset", LocomotionPositionOffset.ToResoniteLinkField());
members.Add("DefaultRootPosition", DefaultRootPosition.ToResoniteLinkField());
members.Add("DefaultRootRotation", DefaultRootRotation.ToResoniteLinkField());
}

}
}
