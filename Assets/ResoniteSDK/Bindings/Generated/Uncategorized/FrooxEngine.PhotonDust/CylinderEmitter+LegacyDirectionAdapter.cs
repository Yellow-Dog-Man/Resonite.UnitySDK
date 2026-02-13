
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter+LegacyDirectionAdapter
// Generated on: pátek 13. února 2026 23:23:15
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ForceDirection", ForceDirection.ToResoniteLinkField());
members.Add("EmitFromShell", new ResoniteLink.Reference() { });
members.Add("Direction", new ResoniteLink.Reference() { });
members.Add("CapsDirection", new ResoniteLink.Reference() { });
}

}
            }
}
