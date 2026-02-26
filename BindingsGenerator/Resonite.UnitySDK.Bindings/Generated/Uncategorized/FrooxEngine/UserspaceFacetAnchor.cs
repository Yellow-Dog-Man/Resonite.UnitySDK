
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchor
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceFacetAnchor")]
public partial class UserspaceFacetAnchor : global::FrooxEngine.Component

{
    public global::FrooxEngine.FacetAnchorPoint Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FacetAnchorPoint>, global::FrooxEngine.FacetAnchorPoint> Point_Element = new();
public global::FrooxEngine.UIX.Image BackgroundImage { get => BackgroundImage_Element.Data; set => BackgroundImage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> BackgroundImage_Element = new();
public global::FrooxEngine.UI_UnlitMaterial BackgroundMaterial { get => BackgroundMaterial_Element.Data; set => BackgroundMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_UnlitMaterial>, global::FrooxEngine.UI_UnlitMaterial> BackgroundMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.ToLinkField(context));
members.Add("BackgroundImage", BackgroundImage_Element.ToLinkReference(context));
members.Add("BackgroundMaterial", BackgroundMaterial_Element.ToLinkReference(context));
}

}
}
