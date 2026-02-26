
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioOutputDopplerAdapter
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyAudioOutputDopplerAdapter")]
public partial class LegacyAudioOutputDopplerAdapter : global::FrooxEngine.FieldAdapter<global::System.Single>

{
    public global::FrooxEngine.IField<global::System.Single> SpatialBlend { get => SpatialBlend_Element.Data; set => SpatialBlend_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> SpatialBlend_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Spatialize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpatialBlend", SpatialBlend_Element.ToLinkReference(context));
members.Add("Spatialize", Spatialize_Element.ToLinkReference(context));
}

}
}
