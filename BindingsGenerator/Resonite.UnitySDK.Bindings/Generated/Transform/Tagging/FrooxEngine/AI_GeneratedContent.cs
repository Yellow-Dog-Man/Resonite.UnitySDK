
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AI_GeneratedContent
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AI_GeneratedContent")]
public partial class AI_GeneratedContent : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::System.String Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Source_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkField(context));
}

}
}
