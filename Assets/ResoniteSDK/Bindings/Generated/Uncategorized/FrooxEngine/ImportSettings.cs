
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImportSettings
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImportSettings")]
public partial class ImportSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ImportSettings>

{
    public global::FrooxEngine.OpenableUrlImportPreference SessionUrls;
public global::FrooxEngine.OpenableUrlImportPreference WorldUrls;
public global::FrooxEngine.OpenableUrlImportPreference NetworkUrls;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SessionUrls", SessionUrls.ToResoniteLinkField());
members.Add("WorldUrls", WorldUrls.ToResoniteLinkField());
members.Add("NetworkUrls", NetworkUrls.ToResoniteLinkField());
}

}
}
