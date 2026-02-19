
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetOptimizationWizard
// Generated on: čtvrtek 19. února 2026 8:00:34
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
