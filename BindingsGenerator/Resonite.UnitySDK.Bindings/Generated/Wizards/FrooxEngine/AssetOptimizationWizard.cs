
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetOptimizationWizard
// Generated on: čtvrtek 26. února 2026 10:04:51
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Boolean IgnoreNonpersistentUsers { get => IgnoreNonpersistentUsers_Element.Data; set => IgnoreNonpersistentUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreNonpersistentUsers_Element = new();
public global::FrooxEngine.IntTextEditorParser _maxResolution { get => _maxResolution_Element.Data; set => _maxResolution_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> _maxResolution_Element = new();
public global::FrooxEngine.UIX.Text _message { get => _message_Element.Data; set => _message_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _message_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.Data.ToResoniteReference(context));
members.Add("IgnoreNonpersistentUsers", IgnoreNonpersistentUsers_Element.Data.ToResoniteLinkField());
members.Add("_maxResolution", _maxResolution_Element.Data.ToResoniteReference(context));
members.Add("_message", _message_Element.Data.ToResoniteReference(context));
}

}
}
