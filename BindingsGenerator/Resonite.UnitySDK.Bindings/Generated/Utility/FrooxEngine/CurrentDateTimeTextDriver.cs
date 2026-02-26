
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver
// Generated on: čtvrtek 26. února 2026 12:28:16
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentDateTimeTextDriver")]
public partial class CurrentDateTimeTextDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Target_Element = new();
public global::FrooxEngine.DateTimePattern Pattern { get => Pattern_Element.Data; set => Pattern_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.DateTimePattern>, global::FrooxEngine.DateTimePattern> Pattern_Element = new();
public global::System.Boolean UseUTC { get => UseUTC_Element.Data; set => UseUTC_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseUTC_Element = new();
public global::System.String OverrideFormat { get => OverrideFormat_Element.Data; set => OverrideFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OverrideFormat_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Pattern", Pattern_Element.ToLinkField(context));
members.Add("UseUTC", UseUTC_Element.ToLinkField(context));
members.Add("OverrideFormat", OverrideFormat_Element.ToLinkField(context));
}

}
}
