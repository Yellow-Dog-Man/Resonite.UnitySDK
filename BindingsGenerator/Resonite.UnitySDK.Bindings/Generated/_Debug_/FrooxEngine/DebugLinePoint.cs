
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLinePoint
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLinePoint")]
public partial class DebugLinePoint : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LinePoint0 { get => LinePoint0_Element.Data; set => LinePoint0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LinePoint0_Element = new();
public UnityEngine.Vector3 LinePoint1 { get => LinePoint1_Element.Data; set => LinePoint1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LinePoint1_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<UnityEngine.Vector3>, UnityEngine.Vector3, Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3>> Points = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LinePoint0", LinePoint0_Element.ToLinkField(context));
members.Add("LinePoint1", LinePoint1_Element.ToLinkField(context));
members.Add("Points", Points.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
