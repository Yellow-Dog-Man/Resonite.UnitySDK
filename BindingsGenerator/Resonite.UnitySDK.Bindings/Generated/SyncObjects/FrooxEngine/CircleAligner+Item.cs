
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleAligner+Item
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Single AngleOffset { get => AngleOffset_Element.Data; set => AngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("AngleOffset", AngleOffset_Element.ToLinkField(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
            }
}
