
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPhotoSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPhotoSettings")]
public partial class InteractiveCameraPhotoSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPhotoSettings>

{
    public global::System.Boolean SpawnPhotoInWorld { get => SpawnPhotoInWorld_Element.Data; set => SpawnPhotoInWorld_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SpawnPhotoInWorld_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnPhotoInWorld", SpawnPhotoInWorld_Element.ToLinkField(context));
}

}
}
