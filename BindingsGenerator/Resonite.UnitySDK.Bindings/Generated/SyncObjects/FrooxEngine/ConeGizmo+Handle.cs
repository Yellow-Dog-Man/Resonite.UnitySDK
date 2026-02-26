
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeGizmo+Handle
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
    public partial class ConeGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConeGizmo+Handle")]
public partial class Handle : global::FrooxEngine.SyncObject

{
    public global::System.Single RelativeHeight { get => RelativeHeight_Element.Data; set => RelativeHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelativeHeight_Element = new();
public global::FrooxEngine.Slot root { get => root_Element.Data; set => root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> root_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> offset { get => offset_Element.Data; set => offset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> offset_Element = new();
public global::FrooxEngine.TorusMesh mesh { get => mesh_Element.Data; set => mesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.TorusMesh>, global::FrooxEngine.TorusMesh> mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeHeight", RelativeHeight_Element.ToLinkField(context));
members.Add("root", root_Element.ToLinkReference(context));
members.Add("offset", offset_Element.ToLinkReference(context));
members.Add("mesh", mesh_Element.ToLinkReference(context));
}

}
            }
}
