
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySwapCanvasPanel
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySwapCanvasPanel")]
public partial class LegacySwapCanvasPanel : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.UIX.RectTransform _currentPanel;
public global::FrooxEngine.Slot _container;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_currentPanel", _currentPanel.ToResoniteReference(context));
members.Add("_container", _container.ToResoniteReference(context));
}

}
}
