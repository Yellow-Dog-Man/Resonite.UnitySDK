
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBoolConditionDriver+Condition
// Generated on: čtvrtek 26. února 2026 12:28:07
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
    public partial class MultiBoolConditionDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiBoolConditionDriver+Condition")]
public partial class Condition : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Boolean> Field { get => Field_Element.Data; set => Field_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Field_Element = new();
public global::System.Boolean Invert { get => Invert_Element.Data; set => Invert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Invert_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field_Element.ToLinkReference(context));
members.Add("Invert", Invert_Element.ToLinkField(context));
}

}
            }
}
