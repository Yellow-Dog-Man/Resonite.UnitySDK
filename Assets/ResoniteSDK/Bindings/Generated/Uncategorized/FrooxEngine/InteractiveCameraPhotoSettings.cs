
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPhotoSettings
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPhotoSettings")]
public partial class InteractiveCameraPhotoSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPhotoSettings>

{
    public global::System.Boolean SpawnPhotoInWorld;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld.ToResoniteLinkField());
}

}
}
