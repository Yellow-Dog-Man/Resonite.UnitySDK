
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanAssetDriver<>
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanAssetDriver<>")]
public partial class BooleanAssetDriver<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::System.Boolean State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> State_Element = new();
public global::FrooxEngine.AssetRef<A> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> Target_Element = new();
public global::FrooxEngine.IAssetProvider<A> FalseTarget { get => FalseTarget_Element.Data; set => FalseTarget_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> FalseTarget_Element = new();
public global::FrooxEngine.IAssetProvider<A> TrueTarget { get => TrueTarget_Element.Data; set => TrueTarget_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> TrueTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State_Element.ToLinkField(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("FalseTarget", FalseTarget_Element.ToLinkReference(context));
members.Add("TrueTarget", TrueTarget_Element.ToLinkReference(context));
}

}
}
