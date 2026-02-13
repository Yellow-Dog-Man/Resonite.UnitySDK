
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TextExpandIndicator
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Text", new ResoniteLink.Reference() { });
members.Add("SectionRoot", new ResoniteLink.Reference() { });
members.Add("ChildrenRoot", new ResoniteLink.Reference() { });
members.Add("Closed", Closed.ToResoniteLinkField());
members.Add("Opened", Opened.ToResoniteLinkField());
members.Add("Empty", Empty.ToResoniteLinkField());
}

}
}
