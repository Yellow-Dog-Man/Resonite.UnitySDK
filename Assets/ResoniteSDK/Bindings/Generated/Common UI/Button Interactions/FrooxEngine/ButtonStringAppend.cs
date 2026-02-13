
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonStringAppend
// Generated on: pátek 13. února 2026 23:21:38
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonStringAppend")]
public partial class ButtonStringAppend : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<global::System.String> TargetString;
public global::System.String AppendString;
public global::System.Boolean AppendInFront;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetString", new ResoniteLink.Reference() { });
members.Add("AppendString", AppendString.ToResoniteLinkField());
members.Add("AppendInFront", AppendInFront.ToResoniteLinkField());
}

}
}
