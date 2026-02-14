
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver
// Generated on: sobota 14. února 2026 8:58:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver")]
public partial class CurrentDateTimeTextDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target;
public global::FrooxEngine.DateTimePattern Pattern;
public global::System.Boolean UseUTC;
public global::System.String OverrideFormat;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Pattern", Pattern.ToResoniteLinkField());
members.Add("UseUTC", UseUTC.ToResoniteLinkField());
members.Add("OverrideFormat", OverrideFormat.ToResoniteLinkField());
}

}
}
