
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Slider<>
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Slider<>")]
public partial class Slider<T> : global::FrooxEngine.UIX.InteractionElement
	

{
    public T Value;
public T Min;
public T Max;
public global::System.Boolean Integers;
public global::System.Boolean MaxIsExclusive;
public global::System.Single Power;
public global::System.Boolean Clamp;
public T VibrationThreshold;
public global::FrooxEngine.UIX.Slider<T>.Direction SlideDirection;
public UnityEngine.Vector2 AnchorOffset;
public global::FrooxEngine.IField<UnityEngine.Vector2> HandleAnchorMinDrive;
public global::FrooxEngine.IField<UnityEngine.Vector2> HandleAnchorMaxDrive;
public global::FrooxEngine.IField<UnityEngine.Vector2> FillLineDrive;
public global::System.Boolean RequireLockInToInteract;
public global::System.Boolean RequireInitialPress;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("Integers", Integers.ToResoniteLinkField());
members.Add("MaxIsExclusive", MaxIsExclusive.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
members.Add("Clamp", Clamp.ToResoniteLinkField());
members.Add("VibrationThreshold", VibrationThreshold.ToResoniteLinkField());
members.Add("SlideDirection", SlideDirection.ToResoniteLinkField());
members.Add("AnchorOffset", AnchorOffset.ToResoniteLinkField());
members.Add("HandleAnchorMinDrive", HandleAnchorMinDrive.ToResoniteReference(context));
members.Add("HandleAnchorMaxDrive", HandleAnchorMaxDrive.ToResoniteReference(context));
members.Add("FillLineDrive", FillLineDrive.ToResoniteReference(context));
members.Add("RequireLockInToInteract", RequireLockInToInteract.ToResoniteLinkField());
members.Add("RequireInitialPress", RequireInitialPress.ToResoniteLinkField());
}

}
}
