
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicSubtitleProvider
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicSubtitleProvider")]
public partial class DynamicSubtitleProvider : global::FrooxEngine.ProceduralAnimation

{
    public System.Uri AssetURL { get => AssetURL_Element.Data; set => AssetURL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> AssetURL_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AssetURL", AssetURL_Element.Data.ToResoniteLinkField());
}

}
}
