
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomValueInitializer_sbyte3
// Generated on: pátek 14. srpna 2026 21:58:17
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomValueInitializer_sbyte3")]
public partial class RandomValueInitializer_sbyte3 : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3Sbyte> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector3Sbyte>>, global::FrooxEngine.IField<UnityEngine.Vector3Sbyte>> Target_Element = new();
public UnityEngine.Vector3Sbyte Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Sbyte>, UnityEngine.Vector3Sbyte> Min_Element = new();
public UnityEngine.Vector3Sbyte Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Sbyte>, UnityEngine.Vector3Sbyte> Max_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
}

}
}
