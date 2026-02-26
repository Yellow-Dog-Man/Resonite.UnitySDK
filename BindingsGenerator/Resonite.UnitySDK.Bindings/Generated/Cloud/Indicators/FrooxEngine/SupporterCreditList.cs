
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SupporterCreditList
// Generated on: čtvrtek 26. února 2026 10:03:37
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
    public global::SkyFrost.Base.CreditType CreditType { get => CreditType_Element.Data; set => CreditType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.CreditType>, global::SkyFrost.Base.CreditType> CreditType_Element = new();
public global::System.String Separator { get => Separator_Element.Data; set => Separator_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Separator_Element = new();
public global::System.String Prefix { get => Prefix_Element.Data; set => Prefix_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Prefix_Element = new();
public global::System.String Suffix { get => Suffix_Element.Data; set => Suffix_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Suffix_Element = new();
public global::System.String FormattedList { get => FormattedList_Element.Data; set => FormattedList_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FormattedList_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CreditType", CreditType_Element.Data.ToResoniteLinkField());
members.Add("Separator", Separator_Element.Data.ToResoniteLinkField());
members.Add("Prefix", Prefix_Element.Data.ToResoniteLinkField());
members.Add("Suffix", Suffix_Element.Data.ToResoniteLinkField());
members.Add("FormattedList", FormattedList_Element.Data.ToResoniteLinkField());
}

}
}
