
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVariableSpace
// Generated on: čtvrtek 26. února 2026 12:26:54
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVariableSpace")]
public partial class DynamicVariableSpace : global::FrooxEngine.Component

{
    public global::System.String SpaceName { get => SpaceName_Element.Data; set => SpaceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SpaceName_Element = new();
public global::System.Boolean OnlyDirectBinding { get => OnlyDirectBinding_Element.Data; set => OnlyDirectBinding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OnlyDirectBinding_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpaceName", SpaceName_Element.ToLinkField(context));
members.Add("OnlyDirectBinding", OnlyDirectBinding_Element.ToLinkField(context));
}

}
}
