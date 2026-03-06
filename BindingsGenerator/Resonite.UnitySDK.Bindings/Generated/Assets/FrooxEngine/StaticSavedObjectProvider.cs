
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticSavedObjectProvider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticSavedObjectProvider")]
public partial class StaticSavedObjectProvider : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.SavedObject,global::Elements.Assets.DummyMetadata,global::FrooxEngine.SingleVariantDescriptor>

{
    public global::System.Boolean PreGather { get => PreGather_Element.Data; set => PreGather_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreGather_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PreGather", PreGather_Element.ToLinkField(context));
}

}
}
