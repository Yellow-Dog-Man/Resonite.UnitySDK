
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyTransformFromWorld
// Generated on: středa 25. února 2026 16:14:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyTransformFromWorld")]
public partial class CopyTransformFromWorld : global::FrooxEngine.Component

{
    public global::System.Boolean CopyPosition;
public global::System.Boolean CopyRotation;
public global::System.Boolean CopyScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CopyPosition", CopyPosition.ToResoniteLinkField());
members.Add("CopyRotation", CopyRotation.ToResoniteLinkField());
members.Add("CopyScale", CopyScale.ToResoniteLinkField());
}

}
}
