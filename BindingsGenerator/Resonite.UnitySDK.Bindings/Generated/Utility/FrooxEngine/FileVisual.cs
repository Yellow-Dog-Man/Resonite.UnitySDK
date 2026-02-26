
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileVisual
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileVisual")]
public partial class FileVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.FileMetadata MetadataSource { get => MetadataSource_Element.Data; set => MetadataSource_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.FileMetadata>, global::FrooxEngine.FileMetadata> MetadataSource_Element = new();
public global::FrooxEngine.TextRenderer TypeLabel { get => TypeLabel_Element.Data; set => TypeLabel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> TypeLabel_Element = new();
public global::FrooxEngine.TextRenderer NameLabel { get => NameLabel_Element.Data; set => NameLabel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> NameLabel_Element = new();
public global::FrooxEngine.PBS_DualSidedMetallic FillMaterial { get => FillMaterial_Element.Data; set => FillMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_DualSidedMetallic>, global::FrooxEngine.PBS_DualSidedMetallic> FillMaterial_Element = new();
public global::FrooxEngine.PBS_DualSidedMetallic OutlineMaterial { get => OutlineMaterial_Element.Data; set => OutlineMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_DualSidedMetallic>, global::FrooxEngine.PBS_DualSidedMetallic> OutlineMaterial_Element = new();
public global::FrooxEngine.PBS_DualSidedMetallic TypeMaterial { get => TypeMaterial_Element.Data; set => TypeMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_DualSidedMetallic>, global::FrooxEngine.PBS_DualSidedMetallic> TypeMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MetadataSource", MetadataSource_Element.ToLinkReference(context));
members.Add("TypeLabel", TypeLabel_Element.ToLinkReference(context));
members.Add("NameLabel", NameLabel_Element.ToLinkReference(context));
members.Add("FillMaterial", FillMaterial_Element.ToLinkReference(context));
members.Add("OutlineMaterial", OutlineMaterial_Element.ToLinkReference(context));
members.Add("TypeMaterial", TypeMaterial_Element.ToLinkReference(context));
}

}
}
