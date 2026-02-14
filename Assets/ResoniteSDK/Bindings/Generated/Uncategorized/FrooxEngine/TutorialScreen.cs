
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TutorialScreen
// Generated on: sobota 14. února 2026 8:58:48
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_swapRegion", _swapRegion.ToResoniteReference(context));
members.Add("_currentScreen", _currentScreen.ToResoniteLinkField());
members.Add("_heightField", _heightField.ToResoniteReference(context));
members.Add("_nextEnabled", _nextEnabled.ToResoniteLinkField());
}

}
}
