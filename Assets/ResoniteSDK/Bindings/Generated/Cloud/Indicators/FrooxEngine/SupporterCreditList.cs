
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SupporterCreditList
// Generated on: pátek 13. února 2026 5:51:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SupporterCreditList")]
public partial class SupporterCreditList : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.CreditType CreditType;
public global::System.String Separator;
public global::System.String Prefix;
public global::System.String Suffix;
public global::System.String FormattedList;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CreditType", CreditType.ToResoniteLinkField());
members.Add("Separator", Separator.ToResoniteLinkField());
members.Add("Prefix", Prefix.ToResoniteLinkField());
members.Add("Suffix", Suffix.ToResoniteLinkField());
members.Add("FormattedList", FormattedList.ToResoniteLinkField());
}

}
}
