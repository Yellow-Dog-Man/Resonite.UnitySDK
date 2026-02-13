
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterControllerModifier
// Generated on: pátek 13. února 2026 23:21:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.CharacterControllerParameter Parameter;
public global::FrooxEngine.CharacterControllerModifier.Mode ModificationMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Parameter", Parameter.ToResoniteLinkField());
members.Add("ModificationMode", ModificationMode.ToResoniteLinkField());
}

}
}
