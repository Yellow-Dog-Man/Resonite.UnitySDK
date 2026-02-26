
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager")]
public abstract partial class ProtoFluxDynamicElementManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual Visual { get => Visual_Element.Data; set => Visual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual>, global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual> Visual_Element = new();
public global::FrooxEngine.ISyncList List { get => List_Element.Data; set => List_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncList>, global::FrooxEngine.ISyncList> List_Element = new();
public global::System.Int32 MinElements { get => MinElements_Element.Data; set => MinElements_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinElements_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AddButtonEnabled { get => AddButtonEnabled_Element.Data; set => AddButtonEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> AddButtonEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> RemoveButtonEnabled { get => RemoveButtonEnabled_Element.Data; set => RemoveButtonEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> RemoveButtonEnabled_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> _elements = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Visual", Visual_Element.ToLinkReference(context));
members.Add("List", List_Element.ToLinkReference(context));
members.Add("MinElements", MinElements_Element.ToLinkField(context));
members.Add("AddButtonEnabled", AddButtonEnabled_Element.ToLinkReference(context));
members.Add("RemoveButtonEnabled", RemoveButtonEnabled_Element.ToLinkReference(context));
members.Add("_elements", _elements.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
