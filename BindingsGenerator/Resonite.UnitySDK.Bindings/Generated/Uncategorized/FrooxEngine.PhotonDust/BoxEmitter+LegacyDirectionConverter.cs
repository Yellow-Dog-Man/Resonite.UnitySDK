
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter
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
    public partial class BoxEmitter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter+LegacyDirectionConverter")]
public partial class LegacyDirectionConverter : global::FrooxEngine.FieldConverter<global::System.Boolean,global::PhotonDust.BoxEmitterDirection>

{
    public global::FrooxEngine.IField<global::System.Boolean> EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> EmitFromShell_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EmitFromShell", EmitFromShell_Element.ToLinkReference(context));
}

}
            }
}
