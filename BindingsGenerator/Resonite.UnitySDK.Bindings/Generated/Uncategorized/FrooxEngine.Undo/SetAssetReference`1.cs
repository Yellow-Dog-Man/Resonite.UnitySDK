
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetAssetReference<>
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetAssetReference<>")]
public partial class SetAssetReference<A> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> Target_Element = new();
public global::FrooxEngine.IAssetProvider<A> TargetBefore { get => TargetBefore_Element.Data; set => TargetBefore_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> TargetBefore_Element = new();
public global::FrooxEngine.IAssetProvider<A> TargetAfter { get => TargetAfter_Element.Data; set => TargetAfter_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> TargetAfter_Element = new();
public global::System.Boolean _performed { get => _performed_Element.Data; set => _performed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _performed_Element = new();
public global::System.String _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _description_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("TargetBefore", TargetBefore_Element.Data.ToResoniteReference(context));
members.Add("TargetAfter", TargetAfter_Element.Data.ToResoniteReference(context));
members.Add("_performed", _performed_Element.Data.ToResoniteLinkField());
members.Add("_description", _description_Element.Data.ToResoniteLinkField());
}

}
}
