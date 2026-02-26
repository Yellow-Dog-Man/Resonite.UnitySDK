
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ModalOverlay
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ModalOverlay")]
public partial class ModalOverlay : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIInteractable

{
    public global::System.Single ShowLerp { get => ShowLerp_Element.Data; set => ShowLerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShowLerp_Element = new();
public global::System.Single AnimationTime { get => AnimationTime_Element.Data; set => AnimationTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationTime_Element = new();
public global::FrooxEngine.UIX.RectTransform SizeRoot { get => SizeRoot_Element.Data; set => SizeRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> SizeRoot_Element = new();
public global::FrooxEngine.UIX.RectTransform ContentRoot { get => ContentRoot_Element.Data; set => ContentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> ContentRoot_Element = new();
public global::System.Boolean CloseOnContextMenuAction { get => CloseOnContextMenuAction_Element.Data; set => CloseOnContextMenuAction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseOnContextMenuAction_Element = new();
public global::System.Boolean CloseOnClick { get => CloseOnClick_Element.Data; set => CloseOnClick_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseOnClick_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowLerp", ShowLerp_Element.ToLinkField(context));
members.Add("AnimationTime", AnimationTime_Element.ToLinkField(context));
members.Add("SizeRoot", SizeRoot_Element.ToLinkReference(context));
members.Add("ContentRoot", ContentRoot_Element.ToLinkReference(context));
members.Add("CloseOnContextMenuAction", CloseOnContextMenuAction_Element.ToLinkField(context));
members.Add("CloseOnClick", CloseOnClick_Element.ToLinkField(context));
}

}
}
