
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter
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
    public partial class BoxEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter")]
public partial class LegacyDirectionConverter : global::FrooxEngine.FieldConverter<global::System.Boolean,global::PhotonDust.BoxEmitterDirection>

{
    public global::FrooxEngine.IField<global::System.Boolean> EmitFromShell;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EmitFromShell", EmitFromShell.ToResoniteReference(context));
}

}
            }
}
