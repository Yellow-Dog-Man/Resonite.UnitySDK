
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticAssetProvider<,,>
// Generated on: pátek 6. března 2026 14:18:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticAssetProvider<,,>")]
public abstract partial class StaticAssetProvider<A,M,D> : global::FrooxEngine.AssetProvider<A>, global::FrooxEngine.IStaticAssetProvider
	where D : class, global::FrooxEngine.IEngineAssetVariantDescriptor
	where M : class, global::Elements.Assets.IAssetMetadata
	where A : global::FrooxEngine.Asset

{
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkField(context));
}

}
}
