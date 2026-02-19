
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FacetContainer
// Generated on: čtvrtek 19. února 2026 8:00:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FacetContainer")]
public abstract partial class FacetContainer : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIPreprocessInteractable, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::System.Boolean EditMode;
public global::FrooxEngine.Slot FacetsRoot;
public global::FrooxEngine.UIX.RectTransform _background;
public global::FrooxEngine.UIX.RectTransform _content;
public global::FrooxEngine.UIX.RectTransform _overlay;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EditMode", EditMode.ToResoniteLinkField());
members.Add("FacetsRoot", FacetsRoot.ToResoniteReference(context));
members.Add("_background", _background.ToResoniteReference(context));
members.Add("_content", _content.ToResoniteReference(context));
members.Add("_overlay", _overlay.ToResoniteReference(context));
}

}
}
