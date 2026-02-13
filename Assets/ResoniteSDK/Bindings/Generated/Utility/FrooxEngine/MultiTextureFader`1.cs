
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiTextureFader<>
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FirstTexture", new ResoniteLink.Reference() { });
members.Add("SecondTexture", new ResoniteLink.Reference() { });
members.Add("Lerp", new ResoniteLink.Reference() { });
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Textures", new ResoniteLink.SyncList()
{
    Elements = Textures.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
