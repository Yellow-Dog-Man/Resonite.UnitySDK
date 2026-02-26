
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterParenter+AlignmentFilter
// Generated on: čtvrtek 26. února 2026 15:08:00
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
    public partial class CharacterParenter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterParenter+AlignmentFilter")]
public partial class AlignmentFilter : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.RootSpace DirectionSpace = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single MaximumAngle { get => MaximumAngle_Element.Data; set => MaximumAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumAngle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DirectionSpace", DirectionSpace.ToLinkSyncObject(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("MaximumAngle", MaximumAngle_Element.ToLinkField(context));
}

}
            }
}
