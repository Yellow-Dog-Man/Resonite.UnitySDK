
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape
// Generated on: čtvrtek 26. února 2026 10:04:41
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class DynamicBlendShapeDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape")]
public partial class BlendShape : global::FrooxEngine.SyncObject

{
    public global::System.String BlendShapeName { get => BlendShapeName_Element.Data; set => BlendShapeName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> BlendShapeName_Element = new();
public global::System.Single Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Value_Element = new();
public global::FrooxEngine.IField<global::System.Single> _drive { get => _drive_Element.Data; set => _drive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _drive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlendShapeName", BlendShapeName_Element.Data.ToResoniteLinkField());
members.Add("Value", Value_Element.Data.ToResoniteLinkField());
members.Add("_drive", _drive_Element.Data.ToResoniteReference(context));
}

}
            }
}
