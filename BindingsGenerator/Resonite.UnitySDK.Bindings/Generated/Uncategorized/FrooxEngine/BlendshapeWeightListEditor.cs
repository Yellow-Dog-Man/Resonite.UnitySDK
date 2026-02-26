
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BlendshapeWeightListEditor
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> _targetSkin_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetSkin", _targetSkin_Element.ToLinkReference(context));
}

}
}
