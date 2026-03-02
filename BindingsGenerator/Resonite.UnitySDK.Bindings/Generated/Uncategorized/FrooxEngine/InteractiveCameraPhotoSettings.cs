
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPhotoSettings
// Generated on: pondělí 2. března 2026 17:53:35
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
