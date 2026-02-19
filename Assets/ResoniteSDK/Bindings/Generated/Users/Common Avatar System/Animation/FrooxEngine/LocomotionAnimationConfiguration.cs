
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationConfiguration
// Generated on: čtvrtek 19. února 2026 8:00:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationConfiguration")]
public partial class LocomotionAnimationConfiguration : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionAnimationGlobalParameters GlobalParameters;
public System.Collections.Generic.List<global::FrooxEngine.LocomotionAnimationGaitParameters> Gaits;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlobalParameters", new ResoniteLink.SyncObject() { Members = GlobalParameters.CollectMembers(context) });
members.Add("Gaits", new ResoniteLink.SyncList()
{
    Elements = Gaits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
