
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerSpawner
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerSpawner")]
public partial class AvatarControllerSpawner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.Slot SpawnRoot;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> MaterialOverride;
public global::FrooxEngine.CommonAvatar.AvatarControllerInfo _sourceControllerInfo;
public System.String _lastSpawned;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnRoot", SpawnRoot.ToResoniteReference(context));
members.Add("MaterialOverride", MaterialOverride.ToResoniteReference(context));
members.Add("_sourceControllerInfo", _sourceControllerInfo.ToResoniteReference(context));
members.Add("_lastSpawned", _lastSpawned.ToResoniteLinkField());
}

}
}
