
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter+LegacyDirectionAdapter
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
    public partial class CylinderEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter+LegacyDirectionAdapter")]
public partial class LegacyDirectionAdapter : global::FrooxEngine.Component

{
    public global::System.Boolean ForceDirection { get => ForceDirection_Element.Data; set => ForceDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceDirection_Element = new();
public global::FrooxEngine.IValue<global::System.Boolean> EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<global::System.Boolean>>, global::FrooxEngine.IValue<global::System.Boolean>> EmitFromShell_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterDirection> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::PhotonDust.CylinderEmitterDirection>, global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterDirection>> Direction_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterCapsDirection> CapsDirection { get => CapsDirection_Element.Data; set => CapsDirection_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::PhotonDust.CylinderEmitterCapsDirection>, global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterCapsDirection>> CapsDirection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ForceDirection", ForceDirection_Element.Data.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell_Element.Data.ToResoniteReference(context));
members.Add("Direction", Direction_Element.Data.ToResoniteReference(context));
members.Add("CapsDirection", CapsDirection_Element.Data.ToResoniteReference(context));
}

}
            }
}
