
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySwapCanvasPanel
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySwapCanvasPanel")]
public partial class LegacySwapCanvasPanel : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.UIX.RectTransform _currentPanel { get => _currentPanel_Element.Data; set => _currentPanel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _currentPanel_Element = new();
public global::FrooxEngine.Slot _container { get => _container_Element.Data; set => _container_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _container_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_currentPanel", _currentPanel_Element.ToLinkReference(context));
members.Add("_container", _container_Element.ToLinkReference(context));
}

}
}
