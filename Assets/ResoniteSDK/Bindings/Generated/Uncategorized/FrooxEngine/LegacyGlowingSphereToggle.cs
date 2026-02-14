
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyGlowingSphereToggle
// Generated on: sobota 14. února 2026 8:58:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyGlowingSphereToggle")]
public partial class LegacyGlowingSphereToggle : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.IField<global::System.Boolean> TargetField;
public global::System.Single FadeSpeed;
public global::System.Single CooldownTime;
public global::System.Single Radius;
public UnityEngine.ColorX GlowColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _emissiveColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _rimColor;
public global::FrooxEngine.IField<global::System.Single> _sphereRadius;
public global::FrooxEngine.IField<global::System.Single> _sphereExtrude;
public global::FrooxEngine.IField<global::System.Single> _colliderRadius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("FadeSpeed", FadeSpeed.ToResoniteLinkField());
members.Add("CooldownTime", CooldownTime.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("GlowColor", GlowColor.ToResoniteLinkField());
members.Add("_emissiveColor", _emissiveColor.ToResoniteReference(context));
members.Add("_rimColor", _rimColor.ToResoniteReference(context));
members.Add("_sphereRadius", _sphereRadius.ToResoniteReference(context));
members.Add("_sphereExtrude", _sphereExtrude.ToResoniteReference(context));
members.Add("_colliderRadius", _colliderRadius.ToResoniteReference(context));
}

}
}
