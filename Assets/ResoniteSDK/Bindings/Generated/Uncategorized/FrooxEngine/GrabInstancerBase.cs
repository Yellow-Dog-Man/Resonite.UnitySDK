
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabInstancerBase
// Generated on: pátek 13. února 2026 23:23:10
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Template", new ResoniteLink.Reference() { });
members.Add("ContainerTemplate", new ResoniteLink.Reference() { });
members.Add("ContainerTemplateInstanceRoot", new ResoniteLink.Reference() { });
members.Add("ActivateRoot", ActivateRoot.ToResoniteLinkField());
members.Add("EnableGrabbable", EnableGrabbable.ToResoniteLinkField());
members.Add("SetInstancePersistent", SetInstancePersistent.ToResoniteLinkField());
members.Add("ExcludedParts", new ResoniteLink.SyncList()
{
    Elements = ExcludedParts.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
