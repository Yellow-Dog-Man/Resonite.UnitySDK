
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrushTool+ColorMapping
// Generated on: čtvrtek 26. února 2026 15:09:07
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<UnityEngine.ColorX> Field { get => Field_Element.Data; set => Field_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> Field_Element = new();
public global::System.Single HueOffset { get => HueOffset_Element.Data; set => HueOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HueOffset_Element = new();
public global::System.Single ValueOffset { get => ValueOffset_Element.Data; set => ValueOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ValueOffset_Element = new();
public global::System.Single SaturationOffset { get => SaturationOffset_Element.Data; set => SaturationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SaturationOffset_Element = new();
public global::System.Single AlphaMultiplier { get => AlphaMultiplier_Element.Data; set => AlphaMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaMultiplier_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field_Element.ToLinkReference(context));
members.Add("HueOffset", HueOffset_Element.ToLinkField(context));
members.Add("ValueOffset", ValueOffset_Element.ToLinkField(context));
members.Add("SaturationOffset", SaturationOffset_Element.ToLinkField(context));
members.Add("AlphaMultiplier", AlphaMultiplier_Element.ToLinkField(context));
}

}
            }
}
