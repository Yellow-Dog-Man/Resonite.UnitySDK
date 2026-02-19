
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleAligner+Item
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
    public partial class CircleAligner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleAligner+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot Root;
public global::System.Single AngleOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("AngleOffset", AngleOffset.ToResoniteLinkField());
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
}

}
            }
}
