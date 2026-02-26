
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableUserVoiceModifier
// Generated on: čtvrtek 26. února 2026 10:03:40
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
    public global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState StateOnGrabbed { get => StateOnGrabbed_Element.Data; set => StateOnGrabbed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState>, global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState> StateOnGrabbed_Element = new();
public global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState StateOnReleased { get => StateOnReleased_Element.Data; set => StateOnReleased_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState>, global::FrooxEngine.GrabbableUserVoiceModifier.VoiceState> StateOnReleased_Element = new();
public global::System.Boolean _originalEnabled { get => _originalEnabled_Element.Data; set => _originalEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _originalEnabled_Element = new();
public global::System.Boolean _originalSpatialize { get => _originalSpatialize_Element.Data; set => _originalSpatialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _originalSpatialize_Element = new();
public global::System.Single _originalSpatialBlend { get => _originalSpatialBlend_Element.Data; set => _originalSpatialBlend_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _originalSpatialBlend_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StateOnGrabbed", StateOnGrabbed_Element.Data.ToResoniteLinkField());
members.Add("StateOnReleased", StateOnReleased_Element.Data.ToResoniteLinkField());
members.Add("_originalEnabled", _originalEnabled_Element.Data.ToResoniteLinkField());
members.Add("_originalSpatialize", _originalSpatialize_Element.Data.ToResoniteLinkField());
members.Add("_originalSpatialBlend", _originalSpatialBlend_Element.Data.ToResoniteLinkField());
}

}
}
