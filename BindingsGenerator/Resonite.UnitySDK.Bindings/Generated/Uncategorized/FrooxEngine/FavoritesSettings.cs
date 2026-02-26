
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FavoritesSettings
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FavoritesSettings")]
public partial class FavoritesSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.FavoritesSettings>

{
    public global::System.Boolean AutoLoadCloudHome { get => AutoLoadCloudHome_Element.Data; set => AutoLoadCloudHome_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoLoadCloudHome_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoLoadCloudHome", AutoLoadCloudHome_Element.Data.ToResoniteLinkField());
}

}
}
