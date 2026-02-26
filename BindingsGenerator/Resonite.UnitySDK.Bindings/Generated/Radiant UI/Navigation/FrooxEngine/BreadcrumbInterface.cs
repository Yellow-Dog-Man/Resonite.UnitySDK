
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbInterface
// Generated on: čtvrtek 26. února 2026 15:09:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BreadcrumbInterface")]
public partial class BreadcrumbInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> ItemName { get => ItemName_Element.Data; set => ItemName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> ItemName_Element = new();
public global::System.String PathSegment { get => PathSegment_Element.Data; set => PathSegment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PathSegment_Element = new();
public global::System.Int32 ItemDepth { get => ItemDepth_Element.Data; set => ItemDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ItemDepth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemName", ItemName_Element.ToLinkReference(context));
members.Add("PathSegment", PathSegment_Element.ToLinkField(context));
members.Add("ItemDepth", ItemDepth_Element.ToLinkField(context));
}

}
}
