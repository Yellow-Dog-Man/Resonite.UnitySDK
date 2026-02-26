
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootSpace
// Generated on: čtvrtek 26. února 2026 12:26:56
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RootSpace")]
public partial class RootSpace : global::FrooxEngine.SyncObject, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.Slot LocalSpace { get => LocalSpace_Element.Data; set => LocalSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> LocalSpace_Element = new();
public global::System.Boolean UseParentSpace { get => UseParentSpace_Element.Data; set => UseParentSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseParentSpace_Element = new();
public global::FrooxEngine.RootSpace.DefaultSpace Default { get => Default_Element.Data; set => Default_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.RootSpace.DefaultSpace>, global::FrooxEngine.RootSpace.DefaultSpace> Default_Element = new();
public global::FrooxEngine.RootSpace OverrideRootSpace { get => OverrideRootSpace_Element.Data; set => OverrideRootSpace_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.RootSpace>, global::FrooxEngine.RootSpace> OverrideRootSpace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalSpace", LocalSpace_Element.ToLinkReference(context));
members.Add("UseParentSpace", UseParentSpace_Element.ToLinkField(context));
members.Add("Default", Default_Element.ToLinkField(context));
members.Add("OverrideRootSpace", OverrideRootSpace_Element.ToLinkReference(context));
}

}
}
