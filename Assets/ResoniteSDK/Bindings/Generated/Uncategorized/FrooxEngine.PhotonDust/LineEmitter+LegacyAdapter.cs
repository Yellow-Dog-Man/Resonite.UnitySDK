
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LineEmitter+LegacyAdapter
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Boolean ForceDirection;
public UnityEngine.Vector3 ForcedDirection;
public global::FrooxEngine.IField<global::PhotonDust.LineEmitterDirection> DirectionMode;
public global::FrooxEngine.IField<UnityEngine.Vector3> Direction0;
public global::FrooxEngine.IField<UnityEngine.Vector3> Direction1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ForceDirection", ForceDirection.ToResoniteLinkField());
members.Add("ForcedDirection", ForcedDirection.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteReference(context));
members.Add("Direction0", Direction0.ToResoniteReference(context));
members.Add("Direction1", Direction1.ToResoniteReference(context));
}

}
            }
}
