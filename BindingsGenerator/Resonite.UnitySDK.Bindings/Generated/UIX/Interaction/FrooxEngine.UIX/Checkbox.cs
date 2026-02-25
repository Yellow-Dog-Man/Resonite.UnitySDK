
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Checkbox
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Checkbox")]
public partial class Checkbox : global::FrooxEngine.UIX.UIComponent, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean State;
public global::FrooxEngine.IField<global::System.Boolean> TargetState;
public global::FrooxEngine.IField<global::System.Boolean> CheckVisual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetState", TargetState.ToResoniteReference(context));
members.Add("CheckVisual", CheckVisual.ToResoniteReference(context));
}

}
}
