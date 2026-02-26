
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRotationAdapter
// Generated on: čtvrtek 26. února 2026 12:28:12
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRotationAdapter")]
public partial class LegacyRotationAdapter : global::FrooxEngine.FieldAdapter<global::System.Single>

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh { get => ParticleMesh_Element.Data; set => ParticleMesh_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>>, global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>> ParticleMesh_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> UsingStretch { get => UsingStretch_Element.Data; set => UsingStretch_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> UsingStretch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParticleMesh", ParticleMesh_Element.ToLinkReference(context));
members.Add("UsingStretch", UsingStretch_Element.ToLinkReference(context));
}

}
}
