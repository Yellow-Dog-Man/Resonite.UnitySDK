
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerSpawner
// Generated on: čtvrtek 26. února 2026 12:28:14
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.Slot SpawnRoot { get => SpawnRoot_Element.Data; set => SpawnRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SpawnRoot_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> MaterialOverride { get => MaterialOverride_Element.Data; set => MaterialOverride_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> MaterialOverride_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarControllerInfo _sourceControllerInfo { get => _sourceControllerInfo_Element.Data; set => _sourceControllerInfo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarControllerInfo>, global::FrooxEngine.CommonAvatar.AvatarControllerInfo> _sourceControllerInfo_Element = new();
public System.String _lastSpawned { get => _lastSpawned_Element.Data; set => _lastSpawned_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> _lastSpawned_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnRoot", SpawnRoot_Element.ToLinkReference(context));
members.Add("MaterialOverride", MaterialOverride_Element.ToLinkReference(context));
members.Add("_sourceControllerInfo", _sourceControllerInfo_Element.ToLinkReference(context));
members.Add("_lastSpawned", _lastSpawned_Element.ToLinkField(context));
}

}
}
