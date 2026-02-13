
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StringConcatenationDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StringConcatenationDriver")]
public partial class StringConcatenationDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> TargetString;
public global::System.String Separator;
public System.Collections.Generic.List<global::System.String> Strings;
public global::System.Boolean NullOutputWhenAllAreNull;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetString", new ResoniteLink.Reference() { });
members.Add("Separator", Separator.ToResoniteLinkField());
members.Add("Strings", new ResoniteLink.SyncList()
{
    Elements = Strings.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("NullOutputWhenAllAreNull", NullOutputWhenAllAreNull.ToResoniteLinkField());
}

}
}
