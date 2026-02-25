
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TimeDiagnosis
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TimeDiagnosis")]
public partial class TimeDiagnosis : global::FrooxEngine.Component

{
    public global::System.Boolean FormatTime;
public global::FrooxEngine.Sync<global::System.String> text;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FormatTime", FormatTime.ToResoniteLinkField());
members.Add("text", text.ToResoniteReference(context));
}

}
}
