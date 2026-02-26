
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.License
// Generated on: čtvrtek 26. února 2026 15:08:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean RequireCredit { get => RequireCredit_Element.Data; set => RequireCredit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RequireCredit_Element = new();
public global::System.String CreditString { get => CreditString_Element.Data; set => CreditString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CreditString_Element = new();
public global::System.Boolean CanExport { get => CanExport_Element.Data; set => CanExport_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanExport_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RequireCredit", RequireCredit_Element.ToLinkField(context));
members.Add("CreditString", CreditString_Element.ToLinkField(context));
members.Add("CanExport", CanExport_Element.ToLinkField(context));
}

}
}
