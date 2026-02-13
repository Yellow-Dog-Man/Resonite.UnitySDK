
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticLocaleProvider
// Generated on: pátek 13. února 2026 23:21:31
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticLocaleProvider")]
public partial class StaticLocaleProvider : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.LocaleResource,global::Elements.Assets.DummyMetadata,global::FrooxEngine.LocaleVariantDescriptor>

{
    public global::System.String OverrideLocale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OverrideLocale", OverrideLocale.ToResoniteLinkField());
}

}
}
