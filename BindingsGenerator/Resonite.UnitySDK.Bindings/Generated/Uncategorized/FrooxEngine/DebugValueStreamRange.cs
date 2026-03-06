
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugValueStreamRange
// Generated on: pátek 6. března 2026 14:19:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugValueStreamRange")]
public partial class DebugValueStreamRange : global::FrooxEngine.Component

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> Stream_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> positionDrive { get => positionDrive_Element.Data; set => positionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> positionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> sizeDrive { get => sizeDrive_Element.Data; set => sizeDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> sizeDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("positionDrive", positionDrive_Element.ToLinkReference(context));
members.Add("sizeDrive", sizeDrive_Element.ToLinkReference(context));
}

}
}
