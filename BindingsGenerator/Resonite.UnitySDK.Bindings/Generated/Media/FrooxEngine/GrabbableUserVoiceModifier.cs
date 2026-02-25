
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableUserVoiceModifier
// Generated on: středa 25. února 2026 16:13:10
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableUserVoiceModifier")]
public partial class GrabbableUserVoiceModifier : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState StateOnGrabbed;
public global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState StateOnReleased;
public global::System.Boolean _originalEnabled;
public global::System.Boolean _originalSpatialize;
public global::System.Single _originalSpatialBlend;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StateOnGrabbed", StateOnGrabbed.ToResoniteLinkField());
members.Add("StateOnReleased", StateOnReleased.ToResoniteLinkField());
members.Add("_originalEnabled", _originalEnabled.ToResoniteLinkField());
members.Add("_originalSpatialize", _originalSpatialize.ToResoniteLinkField());
members.Add("_originalSpatialBlend", _originalSpatialBlend.ToResoniteLinkField());
}

}
}
