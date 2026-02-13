
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TutorialScreen
// Generated on: pátek 13. února 2026 5:52:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TutorialScreen")]
public partial class TutorialScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;
public global::FrooxEngine.TutorialScreen.Screen _currentScreen;
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single> _heightField;
public global::System.Boolean _nextEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_swapRegion", new ResoniteLink.Reference() { });
members.Add("_currentScreen", _currentScreen.ToResoniteLinkField());
members.Add("_heightField", new ResoniteLink.Reference() { });
members.Add("_nextEnabled", _nextEnabled.ToResoniteLinkField());
}

}
}
