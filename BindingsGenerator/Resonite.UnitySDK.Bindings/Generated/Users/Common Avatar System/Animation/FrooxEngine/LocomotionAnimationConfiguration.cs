
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationConfiguration
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationConfiguration")]
public partial class LocomotionAnimationConfiguration : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionAnimationGlobalParameters GlobalParameters = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LocomotionAnimationGaitParameters>, global::FrooxEngine.LocomotionAnimationGaitParameters> Gaits = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlobalParameters", GlobalParameters.ToLinkSyncObject(context));
members.Add("Gaits", Gaits.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
