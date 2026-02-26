
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Facet
// Generated on: čtvrtek 26. února 2026 15:09:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Facet")]
public partial class Facet : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver, global::FrooxEngine.IItemMetadataSource

{
    public global::System.Single MinWidth { get => MinWidth_Element.Data; set => MinWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinWidth_Element = new();
public global::System.Single MaxWidth { get => MaxWidth_Element.Data; set => MaxWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxWidth_Element = new();
public global::System.Single MinHeight { get => MinHeight_Element.Data; set => MinHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinHeight_Element = new();
public global::System.Single MaxHeight { get => MaxHeight_Element.Data; set => MaxHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxHeight_Element = new();
public global::System.Nullable<UnityEngine.Vector2> LastPlacedSize { get => LastPlacedSize_Element.Data; set => LastPlacedSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2>>, global::System.Nullable<UnityEngine.Vector2>> LastPlacedSize_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<UnityEngine.Vector2>, UnityEngine.Vector2, Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2>> PreferredSizes = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<UnityEngine.Vector2>, UnityEngine.Vector2, Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2>> AllowedAspectRatios = new();
public global::System.Boolean IsStandalone { get => IsStandalone_Element.Data; set => IsStandalone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsStandalone_Element = new();
public global::FrooxEngine.UIX.Canvas Canvas { get => Canvas_Element.Data; set => Canvas_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> Canvas_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinWidth", MinWidth_Element.ToLinkField(context));
members.Add("MaxWidth", MaxWidth_Element.ToLinkField(context));
members.Add("MinHeight", MinHeight_Element.ToLinkField(context));
members.Add("MaxHeight", MaxHeight_Element.ToLinkField(context));
members.Add("LastPlacedSize", LastPlacedSize_Element.ToLinkField(context));
members.Add("PreferredSizes", PreferredSizes.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("AllowedAspectRatios", AllowedAspectRatios.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("IsStandalone", IsStandalone_Element.ToLinkField(context));
members.Add("Canvas", Canvas_Element.ToLinkReference(context));
}

}
}
