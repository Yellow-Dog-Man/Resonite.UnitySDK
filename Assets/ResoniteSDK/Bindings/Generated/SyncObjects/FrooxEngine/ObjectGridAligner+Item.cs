
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectGridAligner+Item
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
    public partial class ObjectGridAligner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectGridAligner+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot Root;
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("PositionDrive", PositionDrive.ToResoniteReference(context));
}

}
            }
}
