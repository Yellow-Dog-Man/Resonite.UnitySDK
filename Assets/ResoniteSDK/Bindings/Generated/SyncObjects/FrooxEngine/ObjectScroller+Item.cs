
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectScroller+Item
// Generated on: sobota 14. února 2026 8:58:39
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
    public partial class ObjectScroller
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectScroller+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position;
public UnityEngine.Vector3 Size;
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive;
public global::FrooxEngine.IField<global::System.Boolean> ActiveDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("PositionDrive", PositionDrive.ToResoniteReference(context));
members.Add("ScaleDrive", ScaleDrive.ToResoniteReference(context));
members.Add("ActiveDrive", ActiveDrive.ToResoniteReference(context));
}

}
            }
}
