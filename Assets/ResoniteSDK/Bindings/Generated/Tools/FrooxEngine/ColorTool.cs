
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorTool
// Generated on: čtvrtek 19. února 2026 8:00:21
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorTool")]
public partial class ColorTool : global::FrooxEngine.Tool

{
    public UnityEngine.ColorX Color;
public global::System.Boolean EnsureUniqueMaterial;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> ColorIndicators;
public global::FrooxEngine.ColorDialogInterface _colorDialog;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("EnsureUniqueMaterial", EnsureUniqueMaterial.ToResoniteLinkField());
members.Add("ColorIndicators", new ResoniteLink.SyncList()
{
    Elements = ColorIndicators.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_colorDialog", _colorDialog.ToResoniteReference(context));
}

}
}
