
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectScroller+Item
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
    public partial class ObjectScroller
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectScroller+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Position_Element = new();
public UnityEngine.Vector3 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Size_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive { get => PositionDrive_Element.Data; set => PositionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PositionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive { get => ScaleDrive_Element.Data; set => ScaleDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ScaleDrive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> ActiveDrive { get => ActiveDrive_Element.Data; set => ActiveDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> ActiveDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.ToLinkField(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("PositionDrive", PositionDrive_Element.ToLinkReference(context));
members.Add("ScaleDrive", ScaleDrive_Element.ToLinkReference(context));
members.Add("ActiveDrive", ActiveDrive_Element.ToLinkReference(context));
}

}
            }
}
