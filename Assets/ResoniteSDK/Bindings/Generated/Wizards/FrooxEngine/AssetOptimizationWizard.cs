
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetOptimizationWizard
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetOptimizationWizard")]
public partial class AssetOptimizationWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root;
public global::System.Boolean IgnoreNonpersistentUsers;
public global::FrooxEngine.IntTextEditorParser _maxResolution;
public global::FrooxEngine.UIX.Text _message;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("IgnoreNonpersistentUsers", IgnoreNonpersistentUsers.ToResoniteLinkField());
members.Add("_maxResolution", new ResoniteLink.Reference() { });
members.Add("_message", new ResoniteLink.Reference() { });
}

}
}
