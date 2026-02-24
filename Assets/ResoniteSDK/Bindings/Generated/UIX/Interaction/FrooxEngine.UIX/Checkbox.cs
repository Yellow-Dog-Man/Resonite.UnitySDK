
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Checkbox
// Generated on: úterý 24. února 2026 18:20:17
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
