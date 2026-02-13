
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionModule
// Generated on: pátek 13. února 2026 5:51:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionModule")]
public abstract partial class LocomotionModule : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ILocomotionModule

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Icon;
public UnityEngine.ColorX Color;
public global::FrooxEngine.LocomotionController _currentController;
public System.Uri _lastDefaultIcon;
public global::System.Nullable<UnityEngine.ColorX> _lastDefaultColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Icon", new ResoniteLink.Reference() { });
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_currentController", new ResoniteLink.Reference() { });
members.Add("_lastDefaultIcon", _lastDefaultIcon.ToResoniteLinkField());
members.Add("_lastDefaultColor", _lastDefaultColor.ToResoniteLinkField());
}

}
}
