
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleGroup
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleGroup")]
public partial class ScaleGroup : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleElement SelectedElement { get => SelectedElement_Element.Data; set => SelectedElement_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ScaleElement>, global::FrooxEngine.ScaleElement> SelectedElement_Element = new();
public UnityEngine.Vector3 IdleScale { get => IdleScale_Element.Data; set => IdleScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> IdleScale_Element = new();
public UnityEngine.Vector3 BackgroundScale { get => BackgroundScale_Element.Data; set => BackgroundScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BackgroundScale_Element = new();
public UnityEngine.Vector3 SelectedScale { get => SelectedScale_Element.Data; set => SelectedScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SelectedScale_Element = new();
public global::System.Single SmoothSpeed { get => SmoothSpeed_Element.Data; set => SmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothSpeed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedElement", SelectedElement_Element.ToLinkReference(context));
members.Add("IdleScale", IdleScale_Element.ToLinkField(context));
members.Add("BackgroundScale", BackgroundScale_Element.ToLinkField(context));
members.Add("SelectedScale", SelectedScale_Element.ToLinkField(context));
members.Add("SmoothSpeed", SmoothSpeed_Element.ToLinkField(context));
}

}
}
