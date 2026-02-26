
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextCountdownClock
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextCountdownClock")]
public partial class TextCountdownClock : global::FrooxEngine.Component

{
    public global::System.Double CountdownTime { get => CountdownTime_Element.Data; set => CountdownTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> CountdownTime_Element = new();
public global::System.Boolean AllowNegative { get => AllowNegative_Element.Data; set => AllowNegative_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowNegative_Element = new();
public global::FrooxEngine.IField<global::System.String> TextTarget { get => TextTarget_Element.Data; set => TextTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> TextTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CountdownTime", CountdownTime_Element.Data.ToResoniteLinkField());
members.Add("AllowNegative", AllowNegative_Element.Data.ToResoniteLinkField());
members.Add("TextTarget", TextTarget_Element.Data.ToResoniteReference(context));
}

}
}
