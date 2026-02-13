
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver")]
public partial class CurrentDateTimeTextDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target;
public global::FrooxEngine.DateTimePattern Pattern;
public global::System.Boolean UseUTC;
public global::System.String OverrideFormat;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Pattern", Pattern.ToResoniteLinkField());
members.Add("UseUTC", UseUTC.ToResoniteLinkField());
members.Add("OverrideFormat", OverrideFormat.ToResoniteLinkField());
}

}
}
