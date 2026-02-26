
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TextExpandIndicator
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.TextExpandIndicator")]
public partial class TextExpandIndicator : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Text_Element = new();
public global::FrooxEngine.Slot SectionRoot { get => SectionRoot_Element.Data; set => SectionRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SectionRoot_Element = new();
public global::FrooxEngine.Slot ChildrenRoot { get => ChildrenRoot_Element.Data; set => ChildrenRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ChildrenRoot_Element = new();
public global::System.String Closed { get => Closed_Element.Data; set => Closed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Closed_Element = new();
public global::System.String Opened { get => Opened_Element.Data; set => Opened_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Opened_Element = new();
public global::System.String Empty { get => Empty_Element.Data; set => Empty_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Empty_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text_Element.Data.ToResoniteReference(context));
members.Add("SectionRoot", SectionRoot_Element.Data.ToResoniteReference(context));
members.Add("ChildrenRoot", ChildrenRoot_Element.Data.ToResoniteReference(context));
members.Add("Closed", Closed_Element.Data.ToResoniteLinkField());
members.Add("Opened", Opened_Element.Data.ToResoniteLinkField());
members.Add("Empty", Empty_Element.Data.ToResoniteLinkField());
}

}
}
