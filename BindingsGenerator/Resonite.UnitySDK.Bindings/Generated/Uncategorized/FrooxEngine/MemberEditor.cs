
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MemberEditor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MemberEditor")]
public abstract partial class MemberEditor : global::FrooxEngine.Component

{
    public global::System.Boolean Continuous { get => Continuous_Element.Data; set => Continuous_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Continuous_Element = new();
public global::System.String _path { get => _path_Element.Data; set => _path_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _path_Element = new();
public global::FrooxEngine.IField _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField>, global::FrooxEngine.IField> _target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Continuous", Continuous_Element.ToLinkField(context));
members.Add("_path", _path_Element.ToLinkField(context));
members.Add("_target", _target_Element.ToLinkReference(context));
}

}
}
