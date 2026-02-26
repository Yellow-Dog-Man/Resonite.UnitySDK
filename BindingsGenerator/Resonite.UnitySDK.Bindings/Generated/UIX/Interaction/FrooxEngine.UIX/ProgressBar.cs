
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ProgressBar
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ProgressBar")]
public partial class ProgressBar : global::FrooxEngine.Component

{
    public global::System.Single Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Progress_Element = new();
public UnityEngine.Vector2 AnchorMinOffset { get => AnchorMinOffset_Element.Data; set => AnchorMinOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AnchorMinOffset_Element = new();
public UnityEngine.Vector2 AnchorMaxOffset { get => AnchorMaxOffset_Element.Data; set => AnchorMaxOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AnchorMaxOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMin { get => AnchorMin_Element.Data; set => AnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> AnchorMin_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMax { get => AnchorMax_Element.Data; set => AnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> AnchorMax_Element = new();
public global::System.Single Power { get => Power_Element.Data; set => Power_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Power_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress_Element.ToLinkField(context));
members.Add("AnchorMinOffset", AnchorMinOffset_Element.ToLinkField(context));
members.Add("AnchorMaxOffset", AnchorMaxOffset_Element.ToLinkField(context));
members.Add("AnchorMin", AnchorMin_Element.ToLinkReference(context));
members.Add("AnchorMax", AnchorMax_Element.ToLinkReference(context));
members.Add("Power", Power_Element.ToLinkField(context));
}

}
}
