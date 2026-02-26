
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AssetReceiver<>
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.AssetReceiver<>")]
public partial class AssetReceiver<A> : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> Reference_Element = new();
public global::System.Boolean Undoable { get => Undoable_Element.Data; set => Undoable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Undoable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
members.Add("Undoable", Undoable_Element.ToLinkField(context));
}

}
}
