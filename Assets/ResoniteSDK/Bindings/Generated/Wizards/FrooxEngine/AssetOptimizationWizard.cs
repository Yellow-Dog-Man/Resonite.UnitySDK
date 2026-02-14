
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetOptimizationWizard
// Generated on: sobota 14. února 2026 8:58:51
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("IgnoreNonpersistentUsers", IgnoreNonpersistentUsers.ToResoniteLinkField());
members.Add("_maxResolution", _maxResolution.ToResoniteReference(context));
members.Add("_message", _message.ToResoniteReference(context));
}

}
}
