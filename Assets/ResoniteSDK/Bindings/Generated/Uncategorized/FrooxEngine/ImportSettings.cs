
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImportSettings
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImportSettings")]
public partial class ImportSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ImportSettings>

{
    public global::FrooxEngine.OpenableUrlImportPreference SessionUrls;
public global::FrooxEngine.OpenableUrlImportPreference WorldUrls;
public global::FrooxEngine.OpenableUrlImportPreference NetworkUrls;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionUrls", SessionUrls.ToResoniteLinkField());
members.Add("WorldUrls", WorldUrls.ToResoniteLinkField());
members.Add("NetworkUrls", NetworkUrls.ToResoniteLinkField());
}

}
}
