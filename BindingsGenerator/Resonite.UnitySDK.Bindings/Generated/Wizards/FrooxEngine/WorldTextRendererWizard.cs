
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldTextRendererWizard
// Generated on: čtvrtek 26. února 2026 15:09:17
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldTextRendererWizard")]
public partial class WorldTextRendererWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font { get => Font_Element.Data; set => Font_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.FontSet>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>> Font_Element = new();
public global::System.Boolean ProcessDisabled { get => ProcessDisabled_Element.Data; set => ProcessDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessDisabled_Element = new();
public global::System.Boolean ProcessStandaloneRenderers { get => ProcessStandaloneRenderers_Element.Data; set => ProcessStandaloneRenderers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessStandaloneRenderers_Element = new();
public global::System.Boolean ProcessUIXRenderers { get => ProcessUIXRenderers_Element.Data; set => ProcessUIXRenderers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessUIXRenderers_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.UIX.TextField _tag { get => _tag_Element.Data; set => _tag_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _tag_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Font", Font_Element.ToLinkReference(context));
members.Add("ProcessDisabled", ProcessDisabled_Element.ToLinkField(context));
members.Add("ProcessStandaloneRenderers", ProcessStandaloneRenderers_Element.ToLinkField(context));
members.Add("ProcessUIXRenderers", ProcessUIXRenderers_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("_tag", _tag_Element.ToLinkReference(context));
}

}
}
