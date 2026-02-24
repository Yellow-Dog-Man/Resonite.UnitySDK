
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AtlasInfo
// Generated on: úterý 24. února 2026 18:17:40
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AtlasInfo")]
public partial class AtlasInfo : global::FrooxEngine.Component

{
    public UnityEngine.Vector2Int GridSize;
public global::System.Int32 GridFrames;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GridSize", GridSize.ToResoniteLinkField());
members.Add("GridFrames", GridFrames.ToResoniteLinkField());
}

}
}
