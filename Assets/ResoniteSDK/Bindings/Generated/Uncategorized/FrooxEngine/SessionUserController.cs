
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionUserController
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_name", new ResoniteLink.Reference() { });
members.Add("_slider", new ResoniteLink.Reference() { });
members.Add("_mute", new ResoniteLink.Reference() { });
members.Add("_jump", new ResoniteLink.Reference() { });
members.Add("_respawn", new ResoniteLink.Reference() { });
members.Add("_silence", new ResoniteLink.Reference() { });
members.Add("_kick", new ResoniteLink.Reference() { });
members.Add("_ban", new ResoniteLink.Reference() { });
}

}
}
