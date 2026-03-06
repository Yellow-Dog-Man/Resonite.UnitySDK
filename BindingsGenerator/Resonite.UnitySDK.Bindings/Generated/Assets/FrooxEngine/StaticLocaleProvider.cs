
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticLocaleProvider
// Generated on: pátek 6. března 2026 14:18:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::System.String OverrideLocale { get => OverrideLocale_Element.Data; set => OverrideLocale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OverrideLocale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideLocale", OverrideLocale_Element.ToLinkField(context));
}

}
}
