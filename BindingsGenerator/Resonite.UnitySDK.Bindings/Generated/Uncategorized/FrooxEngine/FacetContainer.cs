
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FacetContainer
// Generated on: čtvrtek 26. února 2026 12:28:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FacetContainer")]
public abstract partial class FacetContainer : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIPreprocessInteractable, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::System.Boolean EditMode { get => EditMode_Element.Data; set => EditMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditMode_Element = new();
public global::FrooxEngine.Slot FacetsRoot { get => FacetsRoot_Element.Data; set => FacetsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> FacetsRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform _background { get => _background_Element.Data; set => _background_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _background_Element = new();
public global::FrooxEngine.UIX.RectTransform _content { get => _content_Element.Data; set => _content_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _content_Element = new();
public global::FrooxEngine.UIX.RectTransform _overlay { get => _overlay_Element.Data; set => _overlay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _overlay_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EditMode", EditMode_Element.ToLinkField(context));
members.Add("FacetsRoot", FacetsRoot_Element.ToLinkReference(context));
members.Add("_background", _background_Element.ToLinkReference(context));
members.Add("_content", _content_Element.ToLinkReference(context));
members.Add("_overlay", _overlay_Element.ToLinkReference(context));
}

}
}
