
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MemberEditor
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MemberEditor")]
public abstract partial class MemberEditor : global::FrooxEngine.Component

{
    public global::System.Boolean Continuous;
public global::System.String _path;
public global::FrooxEngine.IField _target;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Continuous", Continuous.ToResoniteLinkField());
members.Add("_path", _path.ToResoniteLinkField());
members.Add("_target", new ResoniteLink.Reference() { });
}

}
}
