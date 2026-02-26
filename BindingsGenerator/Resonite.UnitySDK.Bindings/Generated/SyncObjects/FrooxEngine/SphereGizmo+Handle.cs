
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo+Handle
// Generated on: čtvrtek 26. února 2026 15:09:10
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
    public partial class SphereGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereGizmo+Handle")]
public partial class Handle : global::FrooxEngine.SyncObject

{
    public global::System.Single RelativeRadius { get => RelativeRadius_Element.Data; set => RelativeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelativeRadius_Element = new();
public global::FrooxEngine.Slot root { get => root_Element.Data; set => root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> root_Element = new();
public global::FrooxEngine.TorusMesh mesh { get => mesh_Element.Data; set => mesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.TorusMesh>, global::FrooxEngine.TorusMesh> mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeRadius", RelativeRadius_Element.ToLinkField(context));
members.Add("root", root_Element.ToLinkReference(context));
members.Add("mesh", mesh_Element.ToLinkReference(context));
}

}
            }
}
