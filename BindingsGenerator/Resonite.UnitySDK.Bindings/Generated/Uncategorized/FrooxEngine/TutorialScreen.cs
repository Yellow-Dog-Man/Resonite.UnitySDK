
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TutorialScreen
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TutorialScreen")]
public partial class TutorialScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion { get => _swapRegion_Element.Data; set => _swapRegion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapRegion_Element = new();
public global::FrooxEngine.TutorialScreen.Screen _currentScreen { get => _currentScreen_Element.Data; set => _currentScreen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TutorialScreen.Screen>, global::FrooxEngine.TutorialScreen.Screen> _currentScreen_Element = new();
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single> _heightField { get => _heightField_Element.Data; set => _heightField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single>>, global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single>> _heightField_Element = new();
public global::System.Boolean _nextEnabled { get => _nextEnabled_Element.Data; set => _nextEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _nextEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_swapRegion", _swapRegion_Element.Data.ToResoniteReference(context));
members.Add("_currentScreen", _currentScreen_Element.Data.ToResoniteLinkField());
members.Add("_heightField", _heightField_Element.Data.ToResoniteReference(context));
members.Add("_nextEnabled", _nextEnabled_Element.Data.ToResoniteLinkField());
}

}
}
