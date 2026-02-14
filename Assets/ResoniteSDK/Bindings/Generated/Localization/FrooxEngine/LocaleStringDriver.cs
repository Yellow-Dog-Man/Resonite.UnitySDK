
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleStringDriver
// Generated on: sobota 14. února 2026 8:57:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleStringDriver")]
public partial class LocaleStringDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Target;
public global::System.String Key;
public global::System.String Format;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource> Locale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Key", Key.ToResoniteLinkField());
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Locale", Locale.ToResoniteReference(context));
}

}
}
