
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner+Viewport
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
    public partial class AxisMultiViewportPanner
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner+Viewport")]
public partial class Viewport : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMax;
public global::FrooxEngine.IField<global::System.Boolean> Active;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AnchorMin", new ResoniteLink.Reference() { });
members.Add("AnchorMax", new ResoniteLink.Reference() { });
members.Add("Active", new ResoniteLink.Reference() { });
}

}
            }
}
