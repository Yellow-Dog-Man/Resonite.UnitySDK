
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MemberEditor
// Generated on: sobota 14. února 2026 8:58:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MemberEditor")]
public abstract partial class MemberEditor : global::FrooxEngine.Component

{
    public global::System.Boolean Continuous;
public global::System.String _path;
public global::FrooxEngine.IField _target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Continuous", Continuous.ToResoniteLinkField());
members.Add("_path", _path.ToResoniteLinkField());
members.Add("_target", _target.ToResoniteReference(context));
}

}
}
