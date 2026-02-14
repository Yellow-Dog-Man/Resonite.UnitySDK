
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarHapticSourceManager
// Generated on: sobota 14. února 2026 8:57:06
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> HapticVolumeActiveStates;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticVolumeActiveStates", new ResoniteLink.SyncList()
{
    Elements = HapticVolumeActiveStates.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
