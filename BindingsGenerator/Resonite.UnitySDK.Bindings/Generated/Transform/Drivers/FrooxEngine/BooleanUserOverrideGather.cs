
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanUserOverrideGather
// Generated on: čtvrtek 26. února 2026 15:09:07
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanUserOverrideGather")]
public partial class BooleanUserOverrideGather : global::FrooxEngine.ValueUserOverride<global::System.Boolean>

{
    public global::System.Boolean Any { get => Any_Element.Data; set => Any_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> Any_Element = new();
public global::System.Boolean All { get => All_Element.Data; set => All_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> All_Element = new();
public global::System.Boolean None { get => None_Element.Data; set => None_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> None_Element = new();
public global::System.Int32 TrueCount { get => TrueCount_Element.Data; set => TrueCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TrueCount_Element = new();
public global::System.Int32 FalseCount { get => FalseCount_Element.Data; set => FalseCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> FalseCount_Element = new();
public global::System.Boolean ExcludeHeadless { get => ExcludeHeadless_Element.Data; set => ExcludeHeadless_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeHeadless_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Any", Any_Element.ToLinkField(context));
members.Add("All", All_Element.ToLinkField(context));
members.Add("None", None_Element.ToLinkField(context));
members.Add("TrueCount", TrueCount_Element.ToLinkField(context));
members.Add("FalseCount", FalseCount_Element.ToLinkField(context));
members.Add("ExcludeHeadless", ExcludeHeadless_Element.ToLinkField(context));
}

}
}
