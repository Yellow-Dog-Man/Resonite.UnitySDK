
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticVolume
// Generated on: čtvrtek 19. února 2026 7:58:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticVolume")]
public partial class HapticVolume : global::FrooxEngine.Component, global::FrooxEngine.IHapticSource

{
    public global::FrooxEngine.SensationClass Sensation;
public global::System.Single Intensity;
public System.Collections.Generic.List<global::System.String> SensationHints;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sensation", Sensation.ToResoniteLinkField());
members.Add("Intensity", Intensity.ToResoniteLinkField());
members.Add("SensationHints", new ResoniteLink.SyncList()
{
    Elements = SensationHints.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
