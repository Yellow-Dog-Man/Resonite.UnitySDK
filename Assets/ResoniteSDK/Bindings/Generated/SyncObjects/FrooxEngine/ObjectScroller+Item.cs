
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectScroller+Item
// Generated on: pátek 13. února 2026 23:23:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("PositionDrive", new ResoniteLink.Reference() { });
members.Add("ScaleDrive", new ResoniteLink.Reference() { });
members.Add("ActiveDrive", new ResoniteLink.Reference() { });
}

}
            }
}
