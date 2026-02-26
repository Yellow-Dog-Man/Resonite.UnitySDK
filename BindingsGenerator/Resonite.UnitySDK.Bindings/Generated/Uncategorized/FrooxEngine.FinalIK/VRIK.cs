
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIK
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.VRIK")]
public partial class VRIK : global::FrooxEngine.Component

{
    public global::System.Boolean AutoUpdate { get => AutoUpdate_Element.Data; set => AutoUpdate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoUpdate_Element = new();
public global::System.Boolean FixTransformsEnabled { get => FixTransformsEnabled_Element.Data; set => FixTransformsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FixTransformsEnabled_Element = new();
public global::FrooxEngine.FinalIK.IKSolverVR Solver = new();
public global::System.Boolean componentInitiated { get => componentInitiated_Element.Data; set => componentInitiated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> componentInitiated_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FinalIK.VRIK.BoneDrive>, global::FrooxEngine.FinalIK.VRIK.BoneDrive> _drives = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdate", AutoUpdate_Element.ToLinkField(context));
members.Add("FixTransformsEnabled", FixTransformsEnabled_Element.ToLinkField(context));
members.Add("Solver", Solver.ToLinkSyncObject(context));
members.Add("componentInitiated", componentInitiated_Element.ToLinkField(context));
members.Add("_drives", _drives.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
