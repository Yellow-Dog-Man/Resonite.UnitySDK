
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+References
// Generated on: čtvrtek 26. února 2026 12:28:10
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
    public partial class IKSolverVR
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+References")]
public partial class References : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot root { get => root_Element.Data; set => root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> root_Element = new();
public global::FrooxEngine.Slot pelvis { get => pelvis_Element.Data; set => pelvis_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> pelvis_Element = new();
public global::FrooxEngine.Slot spine { get => spine_Element.Data; set => spine_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> spine_Element = new();
public global::FrooxEngine.Slot chest { get => chest_Element.Data; set => chest_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> chest_Element = new();
public global::FrooxEngine.Slot neck { get => neck_Element.Data; set => neck_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> neck_Element = new();
public global::FrooxEngine.Slot head { get => head_Element.Data; set => head_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> head_Element = new();
public global::FrooxEngine.Slot leftShoulder { get => leftShoulder_Element.Data; set => leftShoulder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftShoulder_Element = new();
public global::FrooxEngine.Slot leftUpperArm { get => leftUpperArm_Element.Data; set => leftUpperArm_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftUpperArm_Element = new();
public global::FrooxEngine.Slot leftForearm { get => leftForearm_Element.Data; set => leftForearm_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftForearm_Element = new();
public global::FrooxEngine.Slot leftHand { get => leftHand_Element.Data; set => leftHand_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftHand_Element = new();
public global::FrooxEngine.Slot rightShoulder { get => rightShoulder_Element.Data; set => rightShoulder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightShoulder_Element = new();
public global::FrooxEngine.Slot rightUpperArm { get => rightUpperArm_Element.Data; set => rightUpperArm_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightUpperArm_Element = new();
public global::FrooxEngine.Slot rightForearm { get => rightForearm_Element.Data; set => rightForearm_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightForearm_Element = new();
public global::FrooxEngine.Slot rightHand { get => rightHand_Element.Data; set => rightHand_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightHand_Element = new();
public global::FrooxEngine.Slot leftThigh { get => leftThigh_Element.Data; set => leftThigh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftThigh_Element = new();
public global::FrooxEngine.Slot leftCalf { get => leftCalf_Element.Data; set => leftCalf_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftCalf_Element = new();
public global::FrooxEngine.Slot leftFoot { get => leftFoot_Element.Data; set => leftFoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftFoot_Element = new();
public global::FrooxEngine.Slot leftToes { get => leftToes_Element.Data; set => leftToes_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> leftToes_Element = new();
public global::FrooxEngine.Slot rightThigh { get => rightThigh_Element.Data; set => rightThigh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightThigh_Element = new();
public global::FrooxEngine.Slot rightCalf { get => rightCalf_Element.Data; set => rightCalf_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightCalf_Element = new();
public global::FrooxEngine.Slot rightFoot { get => rightFoot_Element.Data; set => rightFoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightFoot_Element = new();
public global::FrooxEngine.Slot rightToes { get => rightToes_Element.Data; set => rightToes_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> rightToes_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("root", root_Element.ToLinkReference(context));
members.Add("pelvis", pelvis_Element.ToLinkReference(context));
members.Add("spine", spine_Element.ToLinkReference(context));
members.Add("chest", chest_Element.ToLinkReference(context));
members.Add("neck", neck_Element.ToLinkReference(context));
members.Add("head", head_Element.ToLinkReference(context));
members.Add("leftShoulder", leftShoulder_Element.ToLinkReference(context));
members.Add("leftUpperArm", leftUpperArm_Element.ToLinkReference(context));
members.Add("leftForearm", leftForearm_Element.ToLinkReference(context));
members.Add("leftHand", leftHand_Element.ToLinkReference(context));
members.Add("rightShoulder", rightShoulder_Element.ToLinkReference(context));
members.Add("rightUpperArm", rightUpperArm_Element.ToLinkReference(context));
members.Add("rightForearm", rightForearm_Element.ToLinkReference(context));
members.Add("rightHand", rightHand_Element.ToLinkReference(context));
members.Add("leftThigh", leftThigh_Element.ToLinkReference(context));
members.Add("leftCalf", leftCalf_Element.ToLinkReference(context));
members.Add("leftFoot", leftFoot_Element.ToLinkReference(context));
members.Add("leftToes", leftToes_Element.ToLinkReference(context));
members.Add("rightThigh", rightThigh_Element.ToLinkReference(context));
members.Add("rightCalf", rightCalf_Element.ToLinkReference(context));
members.Add("rightFoot", rightFoot_Element.ToLinkReference(context));
members.Add("rightToes", rightToes_Element.ToLinkReference(context));
}

}
            }
}
