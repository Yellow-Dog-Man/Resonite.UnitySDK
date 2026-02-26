
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionUserController
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionUserController")]
public partial class SessionUserController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Text _name { get => _name_Element.Data; set => _name_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _name_Element = new();
public global::FrooxEngine.UIX.Slider<global::System.Single> _slider { get => _slider_Element.Data; set => _slider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _slider_Element = new();
public global::FrooxEngine.UIX.Button _mute { get => _mute_Element.Data; set => _mute_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _mute_Element = new();
public global::FrooxEngine.UIX.Button _jump { get => _jump_Element.Data; set => _jump_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _jump_Element = new();
public global::FrooxEngine.UIX.Button _respawn { get => _respawn_Element.Data; set => _respawn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _respawn_Element = new();
public global::FrooxEngine.UIX.Button _silence { get => _silence_Element.Data; set => _silence_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _silence_Element = new();
public global::FrooxEngine.UIX.Button _kick { get => _kick_Element.Data; set => _kick_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _kick_Element = new();
public global::FrooxEngine.UIX.Button _ban { get => _ban_Element.Data; set => _ban_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _ban_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_name", _name_Element.ToLinkReference(context));
members.Add("_slider", _slider_Element.ToLinkReference(context));
members.Add("_mute", _mute_Element.ToLinkReference(context));
members.Add("_jump", _jump_Element.ToLinkReference(context));
members.Add("_respawn", _respawn_Element.ToLinkReference(context));
members.Add("_silence", _silence_Element.ToLinkReference(context));
members.Add("_kick", _kick_Element.ToLinkReference(context));
members.Add("_ban", _ban_Element.ToLinkReference(context));
}

}
}
