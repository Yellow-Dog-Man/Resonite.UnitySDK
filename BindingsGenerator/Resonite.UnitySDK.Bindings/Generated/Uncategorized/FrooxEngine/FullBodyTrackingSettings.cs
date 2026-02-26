
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyTrackingSettings
// Generated on: čtvrtek 26. února 2026 15:09:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyTrackingSettings")]
public partial class FullBodyTrackingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.FullBodyTrackingSettings>

{
    public global::System.Single BodyHorizontalAngle { get => BodyHorizontalAngle_Element.Data; set => BodyHorizontalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BodyHorizontalAngle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BodyHorizontalAngle", BodyHorizontalAngle_Element.ToLinkField(context));
}

}
}
