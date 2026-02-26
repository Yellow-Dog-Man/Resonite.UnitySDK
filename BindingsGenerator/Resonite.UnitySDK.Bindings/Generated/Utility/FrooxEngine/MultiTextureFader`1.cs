
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiTextureFader<>
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiTextureFader<>")]
public partial class MultiTextureFader<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.ITexture

{
    public global::FrooxEngine.AssetRef<A> FirstTexture { get => FirstTexture_Element.Data; set => FirstTexture_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> FirstTexture_Element = new();
public global::FrooxEngine.AssetRef<A> SecondTexture { get => SecondTexture_Element.Data; set => SecondTexture_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> SecondTexture_Element = new();
public global::FrooxEngine.IField<global::System.Single> Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Lerp_Element = new();
public global::System.Single Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Position_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<A>, global::FrooxEngine.IAssetProvider<A>, Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>>> Textures = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FirstTexture", FirstTexture_Element.ToLinkReference(context));
members.Add("SecondTexture", SecondTexture_Element.ToLinkReference(context));
members.Add("Lerp", Lerp_Element.ToLinkReference(context));
members.Add("Position", Position_Element.ToLinkField(context));
members.Add("Textures", Textures.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
