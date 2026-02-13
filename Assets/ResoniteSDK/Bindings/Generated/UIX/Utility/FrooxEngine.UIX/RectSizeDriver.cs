
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectSizeDriver
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectSizeDriver")]
public partial class RectSizeDriver : global::FrooxEngine.UIX.UIController

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> TargetSize;
public UnityEngine.Vector2 Scale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSize", new ResoniteLink.Reference() { });
members.Add("Scale", Scale.ToResoniteLinkField());
}

}
}
