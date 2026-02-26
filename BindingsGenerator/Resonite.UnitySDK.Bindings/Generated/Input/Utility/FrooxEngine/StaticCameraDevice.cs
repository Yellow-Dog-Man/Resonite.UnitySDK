
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticCameraDevice
// Generated on: čtvrtek 26. února 2026 12:26:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticCameraDevice")]
public partial class StaticCameraDevice : global::FrooxEngine.Component

{
    public global::FrooxEngine.User Owner { get => Owner_Element.Data; set => Owner_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> Owner_Element = new();
public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::System.Single AspectRatio { get => AspectRatio_Element.Data; set => AspectRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AspectRatio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Owner", Owner_Element.ToLinkReference(context));
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("AspectRatio", AspectRatio_Element.ToLinkField(context));
}

}
}
