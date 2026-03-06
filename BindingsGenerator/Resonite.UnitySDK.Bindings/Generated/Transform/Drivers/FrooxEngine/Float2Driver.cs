
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float2Driver
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float2Driver")]
public partial class Float2Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X { get => X_Element.Data; set => X_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> X_Element = new();
public global::FrooxEngine.Sync<global::System.Single> Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> Y_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X_Element.ToLinkReference(context));
members.Add("Y", Y_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
