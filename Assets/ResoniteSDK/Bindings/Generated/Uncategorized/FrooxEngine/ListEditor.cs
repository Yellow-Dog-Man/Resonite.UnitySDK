
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ListEditor
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ListEditor")]
public partial class ListEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.ISyncList _targetList;
public global::FrooxEngine.UIX.Button _addNewButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_targetList", new ResoniteLink.Reference() { });
members.Add("_addNewButton", new ResoniteLink.Reference() { });
}

}
}
