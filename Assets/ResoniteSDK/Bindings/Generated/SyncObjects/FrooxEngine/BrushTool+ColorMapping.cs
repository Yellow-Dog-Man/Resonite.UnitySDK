
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrushTool+ColorMapping
// Generated on: sobota 14. února 2026 8:58:38
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
    public partial class BrushTool
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrushTool+ColorMapping")]
public partial class ColorMapping : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> Field;
public global::System.Single HueOffset;
public global::System.Single ValueOffset;
public global::System.Single SaturationOffset;
public global::System.Single AlphaMultiplier;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field.ToResoniteReference(context));
members.Add("HueOffset", HueOffset.ToResoniteLinkField());
members.Add("ValueOffset", ValueOffset.ToResoniteLinkField());
members.Add("SaturationOffset", SaturationOffset.ToResoniteLinkField());
members.Add("AlphaMultiplier", AlphaMultiplier.ToResoniteLinkField());
}

}
            }
}
