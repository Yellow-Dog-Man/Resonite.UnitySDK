
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FlipAtUser
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FlipAtUser")]
public partial class FlipAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.RootSpace UpSpace = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpSpace", UpSpace.ToLinkSyncObject(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
}
