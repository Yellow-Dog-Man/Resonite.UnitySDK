
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueVisualizer
// Generated on: čtvrtek 26. února 2026 15:09:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GlueVisualizer")]
public partial class GlueVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.FresnelMaterial Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> Material_Element = new();
public global::FrooxEngine.Glue Glue { get => Glue_Element.Data; set => Glue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Glue>, global::FrooxEngine.Glue> Glue_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldHook<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Scale_Element = new();
public UnityEngine.Vector3 BaseScale { get => BaseScale_Element.Data; set => BaseScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BaseScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Glue", Glue_Element.ToLinkReference(context));
members.Add("Scale", Scale_Element.ToLinkReference(context));
members.Add("BaseScale", BaseScale_Element.ToLinkField(context));
}

}
}
