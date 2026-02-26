
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AuthorityTimeBase
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AuthorityTimeBase")]
public partial class AuthorityTimeBase : global::FrooxEngine.Component, global::FrooxEngine.IValue<global::System.Double>, global::FrooxEngine.IValue

{
    public global::System.Single BaseSpeed { get => BaseSpeed_Element.Data; set => BaseSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseSpeed_Element = new();
public global::System.Single _actualSpeed { get => _actualSpeed_Element.Data; set => _actualSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _actualSpeed_Element = new();
public global::System.Double _actualOffset { get => _actualOffset_Element.Data; set => _actualOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> _actualOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseSpeed", BaseSpeed_Element.ToLinkField(context));
members.Add("_actualSpeed", _actualSpeed_Element.ToLinkField(context));
members.Add("_actualOffset", _actualOffset_Element.ToLinkField(context));
}

}
}
