
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueTextFormatDriver<>
// Generated on: pátek 13. února 2026 23:23:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueTextFormatDriver<>")]
public partial class ValueTextFormatDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> Source;
public global::System.String Format;
public global::FrooxEngine.IField<global::System.String> Text;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Text", new ResoniteLink.Reference() { });
}

}
}
