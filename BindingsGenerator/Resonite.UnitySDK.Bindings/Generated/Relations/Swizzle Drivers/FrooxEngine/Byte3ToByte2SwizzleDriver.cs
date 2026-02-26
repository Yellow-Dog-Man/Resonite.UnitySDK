
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Byte3ToByte2SwizzleDriver
// Generated on: čtvrtek 26. února 2026 12:28:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Byte3ToByte2SwizzleDriver")]
public partial class Byte3ToByte2SwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3Byte> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3Byte>>, global::FrooxEngine.IField<UnityEngine.Vector3Byte>> Source_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2Byte> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2Byte>, global::FrooxEngine.IField<UnityEngine.Vector2Byte>> Target_Element = new();
public global::System.Int32 X { get => X_Element.Data; set => X_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> X_Element = new();
public global::System.Int32 Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Y_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("X", X_Element.ToLinkField(context));
members.Add("Y", Y_Element.ToLinkField(context));
}

}
}
