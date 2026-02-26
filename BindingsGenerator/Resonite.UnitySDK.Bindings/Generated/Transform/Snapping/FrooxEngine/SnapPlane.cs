
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapPlane
// Generated on: čtvrtek 26. února 2026 15:09:08
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapPlane")]
public partial class SnapPlane : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable, global::FrooxEngine.IUIInterface

{
    public UnityEngine.Vector3 Normal { get => Normal_Element.Data; set => Normal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Normal_Element = new();
public global::FrooxEngine.Slot SnapParent { get => SnapParent_Element.Data; set => SnapParent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SnapParent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Normal", Normal_Element.ToLinkField(context));
members.Add("SnapParent", SnapParent_Element.ToLinkReference(context));
}

}
}
