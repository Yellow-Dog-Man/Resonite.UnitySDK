
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ModalOverlay
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::System.Single ShowLerp;
public global::System.Single AnimationTime;
public global::FrooxEngine.UIX.RectTransform SizeRoot;
public global::FrooxEngine.UIX.RectTransform ContentRoot;
public global::System.Boolean CloseOnContextMenuAction;
public global::System.Boolean CloseOnClick;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowLerp", ShowLerp.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("SizeRoot", SizeRoot.ToResoniteReference(context));
members.Add("ContentRoot", ContentRoot.ToResoniteReference(context));
members.Add("CloseOnContextMenuAction", CloseOnContextMenuAction.ToResoniteLinkField());
members.Add("CloseOnClick", CloseOnClick.ToResoniteLinkField());
}

}
}
