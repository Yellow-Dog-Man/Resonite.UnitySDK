
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextCountdownClock
// Generated on: úterý 24. února 2026 18:20:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextCountdownClock")]
public partial class TextCountdownClock : global::FrooxEngine.Component

{
    public global::System.Double CountdownTime;
public global::System.Boolean AllowNegative;
public global::FrooxEngine.IField<global::System.String> TextTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CountdownTime", CountdownTime.ToResoniteLinkField());
members.Add("AllowNegative", AllowNegative.ToResoniteLinkField());
members.Add("TextTarget", TextTarget.ToResoniteReference(context));
}

}
}
