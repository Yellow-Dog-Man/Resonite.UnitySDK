
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Facet
// Generated on: čtvrtek 19. února 2026 8:00:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Facet")]
public partial class Facet : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver, global::FrooxEngine.IItemMetadataSource

{
    public global::System.Single MinWidth;
public global::System.Single MaxWidth;
public global::System.Single MinHeight;
public global::System.Single MaxHeight;
public global::System.Nullable<UnityEngine.Vector2> LastPlacedSize;
public System.Collections.Generic.List<UnityEngine.Vector2> PreferredSizes;
public System.Collections.Generic.List<UnityEngine.Vector2> AllowedAspectRatios;
public global::System.Boolean IsStandalone;
public global::FrooxEngine.UIX.Canvas Canvas;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinWidth", MinWidth.ToResoniteLinkField());
members.Add("MaxWidth", MaxWidth.ToResoniteLinkField());
members.Add("MinHeight", MinHeight.ToResoniteLinkField());
members.Add("MaxHeight", MaxHeight.ToResoniteLinkField());
members.Add("LastPlacedSize", LastPlacedSize.ToResoniteLinkField());
members.Add("PreferredSizes", new ResoniteLink.SyncList()
{
    Elements = PreferredSizes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("AllowedAspectRatios", new ResoniteLink.SyncList()
{
    Elements = AllowedAspectRatios.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("IsStandalone", IsStandalone.ToResoniteLinkField());
members.Add("Canvas", Canvas.ToResoniteReference(context));
}

}
}
