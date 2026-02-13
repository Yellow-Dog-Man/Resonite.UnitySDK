
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NullableSourceDriver<>
// Generated on: pátek 13. února 2026 23:23:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("HasValue", new ResoniteLink.Reference() { });
members.Add("DefaultValue", DefaultValue.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("UpdateDefaultValue", UpdateDefaultValue.ToResoniteLinkField());
}

}
}
