
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectOrb
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectOrb")]
public partial class ObjectOrb : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot PreviewRoot { get => PreviewRoot_Element.Data; set => PreviewRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PreviewRoot_Element = new();
public global::FrooxEngine.Slot TemplateRoot { get => TemplateRoot_Element.Data; set => TemplateRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TemplateRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PreviewRoot", PreviewRoot_Element.Data.ToResoniteReference(context));
members.Add("TemplateRoot", TemplateRoot_Element.Data.ToResoniteReference(context));
}

}
}
