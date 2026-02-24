
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchor
// Generated on: úterý 24. února 2026 18:20:29
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.FacetAnchorPoint Point;
public global::FrooxEngine.UIX.Image BackgroundImage;
public global::FrooxEngine.UI_UnlitMaterial BackgroundMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point.ToResoniteLinkField());
members.Add("BackgroundImage", BackgroundImage.ToResoniteReference(context));
members.Add("BackgroundMaterial", BackgroundMaterial.ToResoniteReference(context));
}

}
}
