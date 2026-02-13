
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FacetContainer
// Generated on: pátek 13. února 2026 5:52:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FacetContainer")]
public abstract partial class FacetContainer : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIPreprocessInteractable, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::System.Boolean EditMode;
public global::FrooxEngine.Slot FacetsRoot;
public global::FrooxEngine.UIX.RectTransform _background;
public global::FrooxEngine.UIX.RectTransform _content;
public global::FrooxEngine.UIX.RectTransform _overlay;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("EditMode", EditMode.ToResoniteLinkField());
members.Add("FacetsRoot", new ResoniteLink.Reference() { });
members.Add("_background", new ResoniteLink.Reference() { });
members.Add("_content", new ResoniteLink.Reference() { });
members.Add("_overlay", new ResoniteLink.Reference() { });
}

}
}
