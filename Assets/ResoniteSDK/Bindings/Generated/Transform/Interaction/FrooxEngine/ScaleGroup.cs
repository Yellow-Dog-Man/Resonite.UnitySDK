
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleGroup
// Generated on: sobota 14. února 2026 8:58:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleGroup")]
public partial class ScaleGroup : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleElement SelectedElement;
public UnityEngine.Vector3 IdleScale;
public UnityEngine.Vector3 BackgroundScale;
public UnityEngine.Vector3 SelectedScale;
public global::System.Single SmoothSpeed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedElement", SelectedElement.ToResoniteReference(context));
members.Add("IdleScale", IdleScale.ToResoniteLinkField());
members.Add("BackgroundScale", BackgroundScale.ToResoniteLinkField());
members.Add("SelectedScale", SelectedScale.ToResoniteLinkField());
members.Add("SmoothSpeed", SmoothSpeed.ToResoniteLinkField());
}

}
}
