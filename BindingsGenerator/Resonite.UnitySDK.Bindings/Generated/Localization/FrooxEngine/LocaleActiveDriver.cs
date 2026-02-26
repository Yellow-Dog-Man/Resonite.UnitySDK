
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleActiveDriver
// Generated on: čtvrtek 26. února 2026 10:03:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleActiveDriver")]
public partial class LocaleActiveDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Boolean> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Target_Element = new();
public global::System.String LocaleCode { get => LocaleCode_Element.Data; set => LocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LocaleCode_Element = new();
public global::System.Boolean MatchMainLanguage { get => MatchMainLanguage_Element.Data; set => MatchMainLanguage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MatchMainLanguage_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("LocaleCode", LocaleCode_Element.Data.ToResoniteLinkField());
members.Add("MatchMainLanguage", MatchMainLanguage_Element.Data.ToResoniteLinkField());
}

}
}
