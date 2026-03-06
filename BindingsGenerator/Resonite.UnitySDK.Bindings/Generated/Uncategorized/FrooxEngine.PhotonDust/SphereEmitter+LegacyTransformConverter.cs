
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter+LegacyTransformConverter
// Generated on: pátek 6. března 2026 14:19:09
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.IField<UnityEngine.Matrix3x3> Transform { get => Transform_Element.Data; set => Transform_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Matrix3x3>, global::FrooxEngine.IField<UnityEngine.Matrix3x3>> Transform_Element = new();
public global::FrooxEngine.PhotonDust.SphereEmitter Emitter { get => Emitter_Element.Data; set => Emitter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.SphereEmitter>, global::FrooxEngine.PhotonDust.SphereEmitter> Emitter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Transform", Transform_Element.ToLinkReference(context));
members.Add("Emitter", Emitter_Element.ToLinkReference(context));
}

}
            }
}
