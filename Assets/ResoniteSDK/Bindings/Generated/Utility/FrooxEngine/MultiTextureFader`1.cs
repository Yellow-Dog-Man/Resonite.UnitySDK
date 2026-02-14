
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiTextureFader<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiTextureFader<>")]
public partial class MultiTextureFader<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.ITexture

{
    public global::FrooxEngine.AssetRef<A> FirstTexture;
public global::FrooxEngine.AssetRef<A> SecondTexture;
public global::FrooxEngine.IField<global::System.Single> Lerp;
public global::System.Single Position;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<A>> Textures;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FirstTexture", FirstTexture.ToResoniteReference(context));
members.Add("SecondTexture", SecondTexture.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteReference(context));
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Textures", new ResoniteLink.SyncList()
{
    Elements = Textures.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
