
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalNullableDateTimeConvertor
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalNullableDateTimeConvertor")]
public partial class LocalNullableDateTimeConvertor : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Nullable<global::System.DateTime>> Source;
public global::System.Nullable<global::System.DateTime> LocalDateTime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("LocalDateTime", LocalDateTime.ToResoniteLinkField());
}

}
}
