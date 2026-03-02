
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarHapticSourceManager
// Generated on: pondělí 2. března 2026 17:52:29
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarHapticSourceManager")]
public partial class AvatarHapticSourceManager : global::FrooxEngine.UserRootComponent

{
    public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> HapticVolumeActiveStates = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticVolumeActiveStates", HapticVolumeActiveStates.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
