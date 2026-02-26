
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarNameplateVisibilityDriver
// Generated on: čtvrtek 26. února 2026 12:28:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarNameplateVisibilityDriver")]
public partial class AvatarNameplateVisibilityDriver : global::FrooxEngine.Component

{
    public global::System.Boolean AlwaysShowToContacts { get => AlwaysShowToContacts_Element.Data; set => AlwaysShowToContacts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysShowToContacts_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Visible { get => Visible_Element.Data; set => Visible_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Visible_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AlwaysShowToContacts", AlwaysShowToContacts_Element.ToLinkField(context));
members.Add("Visible", Visible_Element.ToLinkReference(context));
}

}
}
