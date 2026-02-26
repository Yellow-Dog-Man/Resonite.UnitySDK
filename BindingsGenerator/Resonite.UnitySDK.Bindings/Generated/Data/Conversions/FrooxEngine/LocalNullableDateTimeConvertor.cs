
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalNullableDateTimeConvertor
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalNullableDateTimeConvertor")]
public partial class LocalNullableDateTimeConvertor : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Nullable<global::System.DateTime>> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Nullable<global::System.DateTime>>>, global::FrooxEngine.IField<global::System.Nullable<global::System.DateTime>>> Source_Element = new();
public global::System.Nullable<global::System.DateTime> LocalDateTime { get => LocalDateTime_Element.Data; set => LocalDateTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> LocalDateTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("LocalDateTime", LocalDateTime_Element.ToLinkField(context));
}

}
}
