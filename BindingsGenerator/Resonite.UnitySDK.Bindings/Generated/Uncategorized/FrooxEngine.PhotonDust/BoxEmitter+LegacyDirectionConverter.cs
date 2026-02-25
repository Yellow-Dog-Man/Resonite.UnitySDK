
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter
// Generated on: středa 25. února 2026 16:14:40
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
