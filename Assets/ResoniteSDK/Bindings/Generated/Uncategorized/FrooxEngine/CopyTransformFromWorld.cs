
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyTransformFromWorld
// Generated on: pátek 13. února 2026 23:23:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyTransformFromWorld")]
public partial class CopyTransformFromWorld : global::FrooxEngine.Component

{
    public global::System.Boolean CopyPosition;
public global::System.Boolean CopyRotation;
public global::System.Boolean CopyScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CopyPosition", CopyPosition.ToResoniteLinkField());
members.Add("CopyRotation", CopyRotation.ToResoniteLinkField());
members.Add("CopyScale", CopyScale.ToResoniteLinkField());
}

}
}
