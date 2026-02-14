
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileVisual
// Generated on: sobota 14. února 2026 8:58:50
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileVisual")]
public partial class FileVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.FileMetadata MetadataSource;
public global::FrooxEngine.TextRenderer TypeLabel;
public global::FrooxEngine.TextRenderer NameLabel;
public global::FrooxEngine.PBS_DualSidedMetallic FillMaterial;
public global::FrooxEngine.PBS_DualSidedMetallic OutlineMaterial;
public global::FrooxEngine.PBS_DualSidedMetallic TypeMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MetadataSource", MetadataSource.ToResoniteReference(context));
members.Add("TypeLabel", TypeLabel.ToResoniteReference(context));
members.Add("NameLabel", NameLabel.ToResoniteReference(context));
members.Add("FillMaterial", FillMaterial.ToResoniteReference(context));
members.Add("OutlineMaterial", OutlineMaterial.ToResoniteReference(context));
members.Add("TypeMaterial", TypeMaterial.ToResoniteReference(context));
}

}
}
