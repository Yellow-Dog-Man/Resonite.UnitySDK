
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AuthorityTimeBase
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AuthorityTimeBase")]
public partial class AuthorityTimeBase : global::FrooxEngine.Component, global::FrooxEngine.IValue<global::System.Double>, global::FrooxEngine.IValue

{
    public global::System.Single BaseSpeed;
public global::System.Single _actualSpeed;
public global::System.Double _actualOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseSpeed", BaseSpeed.ToResoniteLinkField());
members.Add("_actualSpeed", _actualSpeed.ToResoniteLinkField());
members.Add("_actualOffset", _actualOffset.ToResoniteLinkField());
}

}
}
