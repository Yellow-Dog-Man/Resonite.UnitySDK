
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorTool
// Generated on: pátek 13. února 2026 23:23:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorTool")]
public partial class ColorTool : global::FrooxEngine.Tool

{
    public UnityEngine.ColorX Color;
public global::System.Boolean EnsureUniqueMaterial;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> ColorIndicators;
public global::FrooxEngine.ColorDialogInterface _colorDialog;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("EnsureUniqueMaterial", EnsureUniqueMaterial.ToResoniteLinkField());
members.Add("ColorIndicators", new ResoniteLink.SyncList()
{
    Elements = ColorIndicators.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_colorDialog", new ResoniteLink.Reference() { });
}

}
}
