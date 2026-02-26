
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvertibleUshortDriver<>
// Generated on: čtvrtek 26. února 2026 12:28:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConvertibleUshortDriver<>")]
public partial class ConvertibleUshortDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Source_Element = new();
public global::FrooxEngine.IField<global::System.UInt16> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.UInt16>, global::FrooxEngine.IField<global::System.UInt16>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
