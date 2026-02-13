
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchor
// Generated on: pátek 13. února 2026 5:52:37
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceFacetAnchor")]
public partial class UserspaceFacetAnchor : global::FrooxEngine.Component

{
    public global::FrooxEngine.FacetAnchorPoint Point;
public global::FrooxEngine.UIX.Image BackgroundImage;
public global::FrooxEngine.UI_UnlitMaterial BackgroundMaterial;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point", Point.ToResoniteLinkField());
members.Add("BackgroundImage", new ResoniteLink.Reference() { });
members.Add("BackgroundMaterial", new ResoniteLink.Reference() { });
}

}
}
