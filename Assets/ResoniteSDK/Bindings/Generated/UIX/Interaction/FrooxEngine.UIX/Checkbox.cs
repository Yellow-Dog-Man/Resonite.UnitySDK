
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Checkbox
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Checkbox")]
public partial class Checkbox : global::FrooxEngine.UIX.UIComponent, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean State;
public global::FrooxEngine.IField<global::System.Boolean> TargetState;
public global::FrooxEngine.IField<global::System.Boolean> CheckVisual;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetState", new ResoniteLink.Reference() { });
members.Add("CheckVisual", new ResoniteLink.Reference() { });
}

}
}
