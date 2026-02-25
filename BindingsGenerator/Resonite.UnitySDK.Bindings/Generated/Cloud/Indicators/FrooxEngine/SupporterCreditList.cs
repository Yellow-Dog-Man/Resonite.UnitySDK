
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SupporterCreditList
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SupporterCreditList")]
public partial class SupporterCreditList : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.CreditType CreditType;
public global::System.String Separator;
public global::System.String Prefix;
public global::System.String Suffix;
public global::System.String FormattedList;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CreditType", CreditType.ToResoniteLinkField());
members.Add("Separator", Separator.ToResoniteLinkField());
members.Add("Prefix", Prefix.ToResoniteLinkField());
members.Add("Suffix", Suffix.ToResoniteLinkField());
members.Add("FormattedList", FormattedList.ToResoniteLinkField());
}

}
}
