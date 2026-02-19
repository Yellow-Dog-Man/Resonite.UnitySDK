
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RendererDecouplingSettings
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Single ActivationFramerate;
public global::System.Int32 DeactivationFrames;
public global::System.Boolean ForceDecouple;
public global::System.Single AssetProcessingMaxTimeMilliseconds;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActivationFramerate", ActivationFramerate.ToResoniteLinkField());
members.Add("DeactivationFrames", DeactivationFrames.ToResoniteLinkField());
members.Add("ForceDecouple", ForceDecouple.ToResoniteLinkField());
members.Add("AssetProcessingMaxTimeMilliseconds", AssetProcessingMaxTimeMilliseconds.ToResoniteLinkField());
}

}
}
