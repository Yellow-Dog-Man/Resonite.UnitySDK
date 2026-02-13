
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIK
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AutoUpdate", AutoUpdate.ToResoniteLinkField());
members.Add("FixTransformsEnabled", FixTransformsEnabled.ToResoniteLinkField());
members.Add("Solver", new ResoniteLink.SyncObject() { Members = Solver.CollectMembers() });
members.Add("componentInitiated", componentInitiated.ToResoniteLinkField());
members.Add("_drives", new ResoniteLink.SyncList()
{
    Elements = _drives.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
