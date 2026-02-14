
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TextExpandIndicator
// Generated on: sobota 14. února 2026 8:58:48
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.IField<global::System.String> Text;
public global::FrooxEngine.Slot SectionRoot;
public global::FrooxEngine.Slot ChildrenRoot;
public global::System.String Closed;
public global::System.String Opened;
public global::System.String Empty;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text.ToResoniteReference(context));
members.Add("SectionRoot", SectionRoot.ToResoniteReference(context));
members.Add("ChildrenRoot", ChildrenRoot.ToResoniteReference(context));
members.Add("Closed", Closed.ToResoniteLinkField());
members.Add("Opened", Opened.ToResoniteLinkField());
members.Add("Empty", Empty.ToResoniteLinkField());
}

}
}
