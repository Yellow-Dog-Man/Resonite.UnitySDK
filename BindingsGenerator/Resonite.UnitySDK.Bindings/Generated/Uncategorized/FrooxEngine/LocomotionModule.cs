
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionModule
// Generated on: čtvrtek 26. února 2026 10:03:40
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionModule")]
public abstract partial class LocomotionModule : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ILocomotionModule

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Icon { get => Icon_Element.Data; set => Icon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Icon_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.LocomotionController _currentController { get => _currentController_Element.Data; set => _currentController_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LocomotionController>, global::FrooxEngine.LocomotionController> _currentController_Element = new();
public System.Uri _lastDefaultIcon { get => _lastDefaultIcon_Element.Data; set => _lastDefaultIcon_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> _lastDefaultIcon_Element = new();
public global::System.Nullable<UnityEngine.ColorX> _lastDefaultColor { get => _lastDefaultColor_Element.Data; set => _lastDefaultColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.ColorX>>, global::System.Nullable<UnityEngine.ColorX>> _lastDefaultColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Icon", Icon_Element.Data.ToResoniteReference(context));
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("_currentController", _currentController_Element.Data.ToResoniteReference(context));
members.Add("_lastDefaultIcon", _lastDefaultIcon_Element.Data.ToResoniteLinkField());
members.Add("_lastDefaultColor", _lastDefaultColor_Element.Data.ToResoniteLinkField());
}

}
}
