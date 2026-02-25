
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabInstancerBase
// Generated on: středa 25. února 2026 16:14:31
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabInstancerBase")]
public abstract partial class GrabInstancerBase : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Template;
public global::FrooxEngine.Slot ContainerTemplate;
public global::FrooxEngine.Slot ContainerTemplateInstanceRoot;
public global::System.Boolean ActivateRoot;
public global::System.Boolean EnableGrabbable;
public global::System.Nullable<global::System.Boolean> SetInstancePersistent;
public System.Collections.Generic.List<global::FrooxEngine.Slot> ExcludedParts;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template.ToResoniteReference(context));
members.Add("ContainerTemplate", ContainerTemplate.ToResoniteReference(context));
members.Add("ContainerTemplateInstanceRoot", ContainerTemplateInstanceRoot.ToResoniteReference(context));
members.Add("ActivateRoot", ActivateRoot.ToResoniteLinkField());
members.Add("EnableGrabbable", EnableGrabbable.ToResoniteLinkField());
members.Add("SetInstancePersistent", SetInstancePersistent.ToResoniteLinkField());
members.Add("ExcludedParts", new ResoniteLink.SyncList()
{
    Elements = ExcludedParts.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
