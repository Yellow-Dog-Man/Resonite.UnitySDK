
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbingSettings
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbingSettings")]
public partial class GrabbingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GrabbingSettings>

{
    public global::FrooxEngine.InteractionHandler.HandGrabType DefaultHandGrabType { get => DefaultHandGrabType_Element.Data; set => DefaultHandGrabType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.InteractionHandler.HandGrabType>, global::FrooxEngine.InteractionHandler.HandGrabType> DefaultHandGrabType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultHandGrabType", DefaultHandGrabType_Element.ToLinkField(context));
}

}
}
