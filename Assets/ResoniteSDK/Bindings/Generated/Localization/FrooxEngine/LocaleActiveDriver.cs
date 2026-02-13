
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleActiveDriver
// Generated on: pátek 13. února 2026 5:51:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleActiveDriver")]
public partial class LocaleActiveDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::System.String LocaleCode;
public global::System.Boolean MatchMainLanguage;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("LocaleCode", LocaleCode.ToResoniteLinkField());
members.Add("MatchMainLanguage", MatchMainLanguage.ToResoniteLinkField());
}

}
}
