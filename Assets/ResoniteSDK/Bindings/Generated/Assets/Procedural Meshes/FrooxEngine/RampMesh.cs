
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RampMesh
// Generated on: sobota 14. února 2026 8:57:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RampMesh")]
public partial class RampMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Length;
public global::System.Single Height;
public global::System.Single Width;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Length", Length.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
