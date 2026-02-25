
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarHapticSourceManager
// Generated on: středa 25. února 2026 16:13:09
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
