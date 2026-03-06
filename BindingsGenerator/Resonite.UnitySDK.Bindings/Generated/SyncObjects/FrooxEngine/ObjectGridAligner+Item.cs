
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectGridAligner+Item
// Generated on: pátek 6. března 2026 14:19:06
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive { get => PositionDrive_Element.Data; set => PositionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PositionDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("PositionDrive", PositionDrive_Element.ToLinkReference(context));
}

}
            }
}
