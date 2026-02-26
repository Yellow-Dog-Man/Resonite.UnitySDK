
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabInstancerBase
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabInstancerBase")]
public abstract partial class GrabInstancerBase : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Template_Element = new();
public global::FrooxEngine.Slot ContainerTemplate { get => ContainerTemplate_Element.Data; set => ContainerTemplate_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ContainerTemplate_Element = new();
public global::FrooxEngine.Slot ContainerTemplateInstanceRoot { get => ContainerTemplateInstanceRoot_Element.Data; set => ContainerTemplateInstanceRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ContainerTemplateInstanceRoot_Element = new();
public global::System.Boolean ActivateRoot { get => ActivateRoot_Element.Data; set => ActivateRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ActivateRoot_Element = new();
public global::System.Boolean EnableGrabbable { get => EnableGrabbable_Element.Data; set => EnableGrabbable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnableGrabbable_Element = new();
public global::System.Nullable<global::System.Boolean> SetInstancePersistent { get => SetInstancePersistent_Element.Data; set => SetInstancePersistent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> SetInstancePersistent_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> ExcludedParts = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template_Element.ToLinkReference(context));
members.Add("ContainerTemplate", ContainerTemplate_Element.ToLinkReference(context));
members.Add("ContainerTemplateInstanceRoot", ContainerTemplateInstanceRoot_Element.ToLinkReference(context));
members.Add("ActivateRoot", ActivateRoot_Element.ToLinkField(context));
members.Add("EnableGrabbable", EnableGrabbable_Element.ToLinkField(context));
members.Add("SetInstancePersistent", SetInstancePersistent_Element.ToLinkField(context));
members.Add("ExcludedParts", ExcludedParts.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
