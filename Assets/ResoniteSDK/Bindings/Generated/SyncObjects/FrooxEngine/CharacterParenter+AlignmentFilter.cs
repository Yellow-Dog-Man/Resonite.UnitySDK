
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterParenter+AlignmentFilter
// Generated on: úterý 24. února 2026 18:17:50
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
    public partial class CharacterParenter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterParenter+AlignmentFilter")]
public partial class AlignmentFilter : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.RootSpace DirectionSpace;
public UnityEngine.Vector3 Direction;
public global::System.Single MaximumAngle;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DirectionSpace", new ResoniteLink.SyncObject() { Members = DirectionSpace.CollectMembers(context) });
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MaximumAngle", MaximumAngle.ToResoniteLinkField());
}

}
            }
}
