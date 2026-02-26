
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpatialVariableBlendDriver
// Generated on: čtvrtek 26. února 2026 15:07:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpatialVariableBlendDriver")]
public partial class SpatialVariableBlendDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> BlendWeight { get => BlendWeight_Element.Data; set => BlendWeight_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> BlendWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlendWeight", BlendWeight_Element.ToLinkReference(context));
}

}
}
