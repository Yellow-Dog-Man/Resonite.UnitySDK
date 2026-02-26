
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RendererDecouplingSettings
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RendererDecouplingSettings")]
public partial class RendererDecouplingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RendererDecouplingSettings>

{
    public global::System.Single ActivationFramerate { get => ActivationFramerate_Element.Data; set => ActivationFramerate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationFramerate_Element = new();
public global::System.Int32 DeactivationFrames { get => DeactivationFrames_Element.Data; set => DeactivationFrames_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DeactivationFrames_Element = new();
public global::System.Boolean ForceDecouple { get => ForceDecouple_Element.Data; set => ForceDecouple_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceDecouple_Element = new();
public global::System.Single AssetProcessingMaxTimeMilliseconds { get => AssetProcessingMaxTimeMilliseconds_Element.Data; set => AssetProcessingMaxTimeMilliseconds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AssetProcessingMaxTimeMilliseconds_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActivationFramerate", ActivationFramerate_Element.Data.ToResoniteLinkField());
members.Add("DeactivationFrames", DeactivationFrames_Element.Data.ToResoniteLinkField());
members.Add("ForceDecouple", ForceDecouple_Element.Data.ToResoniteLinkField());
members.Add("AssetProcessingMaxTimeMilliseconds", AssetProcessingMaxTimeMilliseconds_Element.Data.ToResoniteLinkField());
}

}
}
