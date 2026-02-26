
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoundingBoxDriver
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoundingBoxDriver")]
public partial class BoundingBoxDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IBounded BoundedSource { get => BoundedSource_Element.Data; set => BoundedSource_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded> BoundedSource_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Size_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Center { get => Center_Element.Data; set => Center_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Center_Element = new();
public UnityEngine.Vector3 Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Padding_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundedSource", BoundedSource_Element.ToLinkReference(context));
members.Add("Size", Size_Element.ToLinkReference(context));
members.Add("Center", Center_Element.ToLinkReference(context));
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
}

}
}
