
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter+LegacyDirectionAdapter
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::System.Boolean ForceDirection;
public global::FrooxEngine.IValue<global::System.Boolean> EmitFromShell;
public global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterDirection> Direction;
public global::FrooxEngine.IField<global::PhotonDust.CylinderEmitterCapsDirection> CapsDirection;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ForceDirection", ForceDirection.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("CapsDirection", CapsDirection.ToResoniteReference(context));
}

}
            }
}
