
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter
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
    public partial class BoxEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter")]
public partial class LegacyDirectionConverter : global::FrooxEngine.FieldConverter<global::System.Boolean,global::PhotonDust.BoxEmitterDirection>

{
    public global::FrooxEngine.IField<global::System.Boolean> EmitFromShell;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("EmitFromShell", new ResoniteLink.Reference() { });
}

}
            }
}
