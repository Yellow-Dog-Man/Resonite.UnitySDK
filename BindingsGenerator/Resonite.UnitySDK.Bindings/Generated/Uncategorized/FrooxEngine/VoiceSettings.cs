
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoiceSettings
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VoiceSettings")]
public partial class VoiceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.VoiceSettings>

{
    public global::FrooxEngine.MutePersistence MutePersistence { get => MutePersistence_Element.Data; set => MutePersistence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MutePersistence>, global::FrooxEngine.MutePersistence> MutePersistence_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MutePersistence", MutePersistence_Element.ToLinkField(context));
}

}
}
