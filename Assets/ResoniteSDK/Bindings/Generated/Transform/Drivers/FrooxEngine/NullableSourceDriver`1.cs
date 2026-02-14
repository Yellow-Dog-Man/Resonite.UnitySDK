
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NullableSourceDriver<>
// Generated on: sobota 14. února 2026 8:58:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NullableSourceDriver<>")]
public partial class NullableSourceDriver<T> : global::FrooxEngine.Component
	where T : struct

{
    public global::FrooxEngine.IField<global::System.Nullable<T>> Source;
public global::FrooxEngine.IField<T> Value;
public global::FrooxEngine.IField<global::System.Boolean> HasValue;
public T DefaultValue;
public global::System.Boolean WriteBack;
public global::System.Boolean UpdateDefaultValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Value", Value.ToResoniteReference(context));
members.Add("HasValue", HasValue.ToResoniteReference(context));
members.Add("DefaultValue", DefaultValue.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("UpdateDefaultValue", UpdateDefaultValue.ToResoniteLinkField());
}

}
}
