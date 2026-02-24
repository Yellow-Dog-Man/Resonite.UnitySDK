
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AxisMultiViewportPanner+Viewport
// Generated on: úterý 24. února 2026 18:20:17
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorMin", AnchorMin.ToResoniteReference(context));
members.Add("AnchorMax", AnchorMax.ToResoniteReference(context));
members.Add("Active", Active.ToResoniteReference(context));
}

}
            }
}
