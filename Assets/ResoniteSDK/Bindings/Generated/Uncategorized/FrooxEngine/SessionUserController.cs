
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionUserController
// Generated on: sobota 14. února 2026 8:58:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionUserController")]
public partial class SessionUserController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Text _name;
public global::FrooxEngine.UIX.Slider<global::System.Single> _slider;
public global::FrooxEngine.UIX.Button _mute;
public global::FrooxEngine.UIX.Button _jump;
public global::FrooxEngine.UIX.Button _respawn;
public global::FrooxEngine.UIX.Button _silence;
public global::FrooxEngine.UIX.Button _kick;
public global::FrooxEngine.UIX.Button _ban;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_name", _name.ToResoniteReference(context));
members.Add("_slider", _slider.ToResoniteReference(context));
members.Add("_mute", _mute.ToResoniteReference(context));
members.Add("_jump", _jump.ToResoniteReference(context));
members.Add("_respawn", _respawn.ToResoniteReference(context));
members.Add("_silence", _silence.ToResoniteReference(context));
members.Add("_kick", _kick.ToResoniteReference(context));
members.Add("_ban", _ban.ToResoniteReference(context));
}

}
}
