
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.License
// Generated on: sobota 14. února 2026 8:57:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.License")]
public partial class License : global::FrooxEngine.Component

{
    public global::System.Boolean RequireCredit;
public global::System.String CreditString;
public global::System.Boolean CanExport;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RequireCredit", RequireCredit.ToResoniteLinkField());
members.Add("CreditString", CreditString.ToResoniteLinkField());
members.Add("CanExport", CanExport.ToResoniteLinkField());
}

}
}
