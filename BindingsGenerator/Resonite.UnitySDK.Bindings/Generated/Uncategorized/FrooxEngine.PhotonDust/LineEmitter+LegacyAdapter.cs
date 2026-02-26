
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LineEmitter+LegacyAdapter
// Generated on: čtvrtek 26. února 2026 10:04:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    public partial class LineEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LineEmitter+LegacyAdapter")]
public partial class LegacyAdapter : global::FrooxEngine.Component

{
    public global::System.Boolean ForceDirection { get => ForceDirection_Element.Data; set => ForceDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceDirection_Element = new();
public UnityEngine.Vector3 ForcedDirection { get => ForcedDirection_Element.Data; set => ForcedDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ForcedDirection_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.LineEmitterDirection> DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::PhotonDust.LineEmitterDirection>, global::FrooxEngine.IField<global::PhotonDust.LineEmitterDirection>> DirectionMode_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Direction0 { get => Direction0_Element.Data; set => Direction0_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Direction0_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Direction1 { get => Direction1_Element.Data; set => Direction1_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Direction1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ForceDirection", ForceDirection_Element.Data.ToResoniteLinkField());
members.Add("ForcedDirection", ForcedDirection_Element.Data.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode_Element.Data.ToResoniteReference(context));
members.Add("Direction0", Direction0_Element.Data.ToResoniteReference(context));
members.Add("Direction1", Direction1_Element.Data.ToResoniteReference(context));
}

}
            }
}
