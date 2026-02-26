
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDialogInterface
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorDialogInterface")]
public partial class ColorDialogInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>> TargetColor { get => TargetColor_Element.Data; set => TargetColor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>> TargetColor_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Continuous { get => Continuous_Element.Data; set => Continuous_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Continuous_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AllowAlpha { get => AllowAlpha_Element.Data; set => AllowAlpha_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> AllowAlpha_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AllowHDR { get => AllowHDR_Element.Data; set => AllowHDR_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> AllowHDR_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetColor", TargetColor_Element.ToLinkReference(context));
members.Add("Continuous", Continuous_Element.ToLinkReference(context));
members.Add("AllowAlpha", AllowAlpha_Element.ToLinkReference(context));
members.Add("AllowHDR", AllowHDR_Element.ToLinkReference(context));
}

}
}
