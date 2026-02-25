
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySwapCanvasPanel
// Generated on: středa 25. února 2026 16:14:40
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
