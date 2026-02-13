
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ModalOverlay
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ShowLerp", ShowLerp.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("SizeRoot", new ResoniteLink.Reference() { });
members.Add("ContentRoot", new ResoniteLink.Reference() { });
members.Add("CloseOnContextMenuAction", CloseOnContextMenuAction.ToResoniteLinkField());
members.Add("CloseOnClick", CloseOnClick.ToResoniteLinkField());
}

}
}
