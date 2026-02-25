
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectGridAligner+Item
// Generated on: středa 25. února 2026 16:14:30
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
