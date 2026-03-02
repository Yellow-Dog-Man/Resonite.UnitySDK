
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BabbleSettings
// Generated on: pondělí 2. března 2026 17:53:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BabbleSettings")]
public partial class BabbleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.BabbleSettings>

{
    public global::System.Int32 OSC_DataPort { get => OSC_DataPort_Element.Data; set => OSC_DataPort_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> OSC_DataPort_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OSC_DataPort", OSC_DataPort_Element.ToLinkField(context));
}

}
}
