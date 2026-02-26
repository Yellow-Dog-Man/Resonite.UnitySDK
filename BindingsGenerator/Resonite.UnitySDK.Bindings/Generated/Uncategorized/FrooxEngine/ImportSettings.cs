
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImportSettings
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImportSettings")]
public partial class ImportSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ImportSettings>

{
    public global::FrooxEngine.OpenableUrlImportPreference SessionUrls { get => SessionUrls_Element.Data; set => SessionUrls_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OpenableUrlImportPreference>, global::FrooxEngine.OpenableUrlImportPreference> SessionUrls_Element = new();
public global::FrooxEngine.OpenableUrlImportPreference WorldUrls { get => WorldUrls_Element.Data; set => WorldUrls_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OpenableUrlImportPreference>, global::FrooxEngine.OpenableUrlImportPreference> WorldUrls_Element = new();
public global::FrooxEngine.OpenableUrlImportPreference NetworkUrls { get => NetworkUrls_Element.Data; set => NetworkUrls_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OpenableUrlImportPreference>, global::FrooxEngine.OpenableUrlImportPreference> NetworkUrls_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionUrls", SessionUrls_Element.Data.ToResoniteLinkField());
members.Add("WorldUrls", WorldUrls_Element.Data.ToResoniteLinkField());
members.Add("NetworkUrls", NetworkUrls_Element.Data.ToResoniteLinkField());
}

}
}
