
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDialogInterface
// Generated on: čtvrtek 19. února 2026 7:58:56
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>> TargetColor;
public global::FrooxEngine.IField<global::System.Boolean> Continuous;
public global::FrooxEngine.IField<global::System.Boolean> AllowAlpha;
public global::FrooxEngine.IField<global::System.Boolean> AllowHDR;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetColor", TargetColor.ToResoniteReference(context));
members.Add("Continuous", Continuous.ToResoniteReference(context));
members.Add("AllowAlpha", AllowAlpha.ToResoniteReference(context));
members.Add("AllowHDR", AllowHDR.ToResoniteReference(context));
}

}
}
