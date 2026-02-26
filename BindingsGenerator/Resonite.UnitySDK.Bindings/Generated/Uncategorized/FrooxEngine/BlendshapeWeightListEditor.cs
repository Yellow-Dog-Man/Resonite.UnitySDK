
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BlendshapeWeightListEditor
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BlendshapeWeightListEditor")]
public partial class BlendshapeWeightListEditor : global::FrooxEngine.ListEditor

{
    public global::FrooxEngine.SkinnedMeshRenderer _targetSkin { get => _targetSkin_Element.Data; set => _targetSkin_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> _targetSkin_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetSkin", _targetSkin_Element.Data.ToResoniteReference(context));
}

}
}
