
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextCountdownClock
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextCountdownClock")]
public partial class TextCountdownClock : global::FrooxEngine.Component

{
    public global::System.Double CountdownTime;
public global::System.Boolean AllowNegative;
public global::FrooxEngine.IField<global::System.String> TextTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CountdownTime", CountdownTime.ToResoniteLinkField());
members.Add("AllowNegative", AllowNegative.ToResoniteLinkField());
members.Add("TextTarget", new ResoniteLink.Reference() { });
}

}
}
