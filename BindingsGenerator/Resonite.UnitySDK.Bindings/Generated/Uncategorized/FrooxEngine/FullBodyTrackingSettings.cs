
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyTrackingSettings
// Generated on: pondělí 2. března 2026 17:53:34
// Resonite version: 2026.3.2.1000
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
