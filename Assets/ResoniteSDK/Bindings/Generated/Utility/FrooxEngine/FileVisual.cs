
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileVisual
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileVisual")]
public partial class FileVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.FileMetadata MetadataSource;
public global::FrooxEngine.TextRenderer TypeLabel;
public global::FrooxEngine.TextRenderer NameLabel;
public global::FrooxEngine.PBS_DualSidedMetallic FillMaterial;
public global::FrooxEngine.PBS_DualSidedMetallic OutlineMaterial;
public global::FrooxEngine.PBS_DualSidedMetallic TypeMaterial;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MetadataSource", new ResoniteLink.Reference() { });
members.Add("TypeLabel", new ResoniteLink.Reference() { });
members.Add("NameLabel", new ResoniteLink.Reference() { });
members.Add("FillMaterial", new ResoniteLink.Reference() { });
members.Add("OutlineMaterial", new ResoniteLink.Reference() { });
members.Add("TypeMaterial", new ResoniteLink.Reference() { });
}

}
}
