
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter+LegacyTransformConverter
// Generated on: čtvrtek 19. února 2026 8:00:29
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
    public partial class SphereEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter+LegacyTransformConverter")]
public partial class LegacyTransformConverter : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Matrix3x3> Transform;
public global::FrooxEngine.PhotonDust.SphereEmitter Emitter;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Transform", Transform.ToResoniteReference(context));
members.Add("Emitter", Emitter.ToResoniteReference(context));
}

}
            }
}
