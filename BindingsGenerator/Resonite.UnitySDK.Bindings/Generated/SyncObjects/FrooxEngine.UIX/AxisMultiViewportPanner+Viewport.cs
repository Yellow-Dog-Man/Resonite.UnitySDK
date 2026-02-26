
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner+Viewport
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    public partial class AxisMultiViewportPanner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner+Viewport")]
public partial class Viewport : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMin { get => AnchorMin_Element.Data; set => AnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> AnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMax { get => AnchorMax_Element.Data; set => AnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> AnchorMax_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Active { get => Active_Element.Data; set => Active_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Active_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorMin", AnchorMin_Element.ToLinkReference(context));
members.Add("AnchorMax", AnchorMax_Element.ToLinkReference(context));
members.Add("Active", Active_Element.ToLinkReference(context));
}

}
            }
}
