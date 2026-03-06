
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicAssetProvider<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicAssetProvider<>")]
public abstract partial class DynamicAssetProvider<A> : global::FrooxEngine.AssetProvider<A>
	where A : global::FrooxEngine.Asset

{
    public global::System.Boolean HighPriorityIntegration { get => HighPriorityIntegration_Element.Data; set => HighPriorityIntegration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HighPriorityIntegration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HighPriorityIntegration", HighPriorityIntegration_Element.ToLinkField(context));
}

}
}
