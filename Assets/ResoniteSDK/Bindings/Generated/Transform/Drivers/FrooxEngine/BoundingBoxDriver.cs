
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoundingBoxDriver
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoundingBoxDriver")]
public partial class BoundingBoxDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IBounded BoundedSource;
public global::FrooxEngine.IField<UnityEngine.Vector3> Size;
public global::FrooxEngine.IField<UnityEngine.Vector3> Center;
public UnityEngine.Vector3 Padding;
public UnityEngine.Vector3 Scale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundedSource", BoundedSource.ToResoniteReference(context));
members.Add("Size", Size.ToResoniteReference(context));
members.Add("Center", Center.ToResoniteReference(context));
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
}

}
}
