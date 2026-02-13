
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LinearMapper1D
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LinearMapper1D")]
public partial class LinearMapper1D : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Single> Source;
public global::FrooxEngine.IField<global::System.Single> Target;
public global::System.Single SourceMin;
public global::System.Single SourceMax;
public global::System.Single TargetMin;
public global::System.Single TargetMax;
public global::System.Boolean AllowReverseMapping;
public global::System.Boolean Clamp;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("SourceMin", SourceMin.ToResoniteLinkField());
members.Add("SourceMax", SourceMax.ToResoniteLinkField());
members.Add("TargetMin", TargetMin.ToResoniteLinkField());
members.Add("TargetMax", TargetMax.ToResoniteLinkField());
members.Add("AllowReverseMapping", AllowReverseMapping.ToResoniteLinkField());
members.Add("Clamp", Clamp.ToResoniteLinkField());
}

}
}
