
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadiantScreenWrapper
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyRadiantScreenWrapper")]
public abstract partial class LegacyRadiantScreenWrapper : global::FrooxEngine.RadiantDashScreen

{
    public global::System.Single ExtraSidePadding { get => ExtraSidePadding_Element.Data; set => ExtraSidePadding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ExtraSidePadding_Element = new();
public UnityEngine.ColorX Background { get => Background_Element.Data; set => Background_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Background_Element = new();
public global::System.Boolean _initialized { get => _initialized_Element.Data; set => _initialized_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _initialized_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ExtraSidePadding", ExtraSidePadding_Element.ToLinkField(context));
members.Add("Background", Background_Element.ToLinkField(context));
members.Add("_initialized", _initialized_Element.ToLinkField(context));
}

}
}
