
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonStringAppend
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonStringAppend")]
public partial class ButtonStringAppend : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<global::System.String> TargetString;
public global::System.String AppendString;
public global::System.Boolean AppendInFront;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetString", TargetString.ToResoniteReference(context));
members.Add("AppendString", AppendString.ToResoniteLinkField());
members.Add("AppendInFront", AppendInFront.ToResoniteLinkField());
}

}
}
