
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter+LegacyTransformConverter
// Generated on: pátek 13. února 2026 23:23:16
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
    public partial class SphereEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter+LegacyTransformConverter")]
public partial class LegacyTransformConverter : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Matrix3x3> Transform;
public global::FrooxEngine.PhotonDust.SphereEmitter Emitter;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Transform", new ResoniteLink.Reference() { });
members.Add("Emitter", new ResoniteLink.Reference() { });
}

}
            }
}
