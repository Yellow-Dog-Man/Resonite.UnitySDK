
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserMetricsSettings
// Generated on: pondělí 2. března 2026 17:53:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserMetricsSettings")]
public partial class UserMetricsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.UserMetricsSettings>

{
    public global::System.Single UserHeight { get => UserHeight_Element.Data; set => UserHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserHeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserHeight", UserHeight_Element.ToLinkField(context));
}

}
}
