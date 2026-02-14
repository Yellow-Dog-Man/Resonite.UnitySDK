
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIK
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.VRIK")]
public partial class VRIK : global::FrooxEngine.Component

{
    public global::System.Boolean AutoUpdate;
public global::System.Boolean FixTransformsEnabled;
public global::FrooxEngine.FinalIK.IKSolverVR Solver;
public global::System.Boolean componentInitiated;
public System.Collections.Generic.List<global::FrooxEngine.FinalIK.VRIK.BoneDrive> _drives;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdate", AutoUpdate.ToResoniteLinkField());
members.Add("FixTransformsEnabled", FixTransformsEnabled.ToResoniteLinkField());
members.Add("Solver", new ResoniteLink.SyncObject() { Members = Solver.CollectMembers(context) });
members.Add("componentInitiated", componentInitiated.ToResoniteLinkField());
members.Add("_drives", new ResoniteLink.SyncList()
{
    Elements = _drives.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
