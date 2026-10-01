
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigTool
// Generated on: pátek 14. srpna 2026 21:57:42
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RigTool")]
public partial class RigTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.Rig CurrentRig { get => CurrentRig_Element.Data; set => CurrentRig_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Rig>, global::FrooxEngine.Rig> CurrentRig_Element = new();
public global::FrooxEngine.FABRIK_Chain IK_Chain { get => IK_Chain_Element.Data; set => IK_Chain_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FABRIK_Chain>, global::FrooxEngine.FABRIK_Chain> IK_Chain_Element = new();
public global::FrooxEngine.TrigonometricIK TrigIK { get => TrigIK_Element.Data; set => TrigIK_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrigonometricIK>, global::FrooxEngine.TrigonometricIK> TrigIK_Element = new();
public global::FrooxEngine.RigBoneProxy SelectedBone { get => SelectedBone_Element.Data; set => SelectedBone_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RigBoneProxy>, global::FrooxEngine.RigBoneProxy> SelectedBone_Element = new();
public global::FrooxEngine.Slot IK_EffectorTemplate { get => IK_EffectorTemplate_Element.Data; set => IK_EffectorTemplate_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> IK_EffectorTemplate_Element = new();
public global::FrooxEngine.Slot _newBone { get => _newBone_Element.Data; set => _newBone_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _newBone_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentRig", CurrentRig_Element.ToLinkReference(context));
members.Add("IK_Chain", IK_Chain_Element.ToLinkReference(context));
members.Add("TrigIK", TrigIK_Element.ToLinkReference(context));
members.Add("SelectedBone", SelectedBone_Element.ToLinkReference(context));
members.Add("IK_EffectorTemplate", IK_EffectorTemplate_Element.ToLinkReference(context));
members.Add("_newBone", _newBone_Element.ToLinkReference(context));
}

}
}
