
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterControllerModifier
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterControllerModifier")]
public abstract partial class CharacterControllerModifier : global::FrooxEngine.Component

{
    public global::FrooxEngine.CharacterControllerParameter Parameter { get => Parameter_Element.Data; set => Parameter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CharacterControllerParameter>, global::FrooxEngine.CharacterControllerParameter> Parameter_Element = new();
public global::FrooxEngine.CharacterControllerModifier.Mode ModificationMode { get => ModificationMode_Element.Data; set => ModificationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CharacterControllerModifier.Mode>, global::FrooxEngine.CharacterControllerModifier.Mode> ModificationMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Parameter", Parameter_Element.Data.ToResoniteLinkField());
members.Add("ModificationMode", ModificationMode_Element.Data.ToResoniteLinkField());
}

}
}
