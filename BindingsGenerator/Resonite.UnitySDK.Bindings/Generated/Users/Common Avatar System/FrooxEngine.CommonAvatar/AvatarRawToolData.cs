
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawToolData
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawToolData")]
public partial class AvatarRawToolData : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::Renderite.Shared.Chirality ControllerSide { get => ControllerSide_Element.Data; set => ControllerSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> ControllerSide_Element = new();
public global::System.Boolean PressingPrimary { get => PressingPrimary_Element.Data; set => PressingPrimary_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> PressingPrimary_Element = new();
public global::System.Boolean PressingSecondary { get => PressingSecondary_Element.Data; set => PressingSecondary_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> PressingSecondary_Element = new();
public global::System.Boolean PressingGrab { get => PressingGrab_Element.Data; set => PressingGrab_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> PressingGrab_Element = new();
public global::System.Single PrimaryStrength { get => PrimaryStrength_Element.Data; set => PrimaryStrength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> PrimaryStrength_Element = new();
public UnityEngine.Vector2 SecondaryAxis { get => SecondaryAxis_Element.Data; set => SecondaryAxis_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryAxis_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> _strengthStream { get => _strengthStream_Element.Data; set => _strengthStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> _strengthStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector2> _axisStream { get => _axisStream_Element.Data; set => _axisStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector2>>, global::FrooxEngine.ValueStream<UnityEngine.Vector2>> _axisStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> _primaryStream { get => _primaryStream_Element.Data; set => _primaryStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> _primaryStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> _secondaryStream { get => _secondaryStream_Element.Data; set => _secondaryStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> _secondaryStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> _grabStream { get => _grabStream_Element.Data; set => _grabStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> _grabStream_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ControllerSide", ControllerSide_Element.ToLinkField(context));
members.Add("PressingPrimary", PressingPrimary_Element.ToLinkField(context));
members.Add("PressingSecondary", PressingSecondary_Element.ToLinkField(context));
members.Add("PressingGrab", PressingGrab_Element.ToLinkField(context));
members.Add("PrimaryStrength", PrimaryStrength_Element.ToLinkField(context));
members.Add("SecondaryAxis", SecondaryAxis_Element.ToLinkField(context));
members.Add("_activeUser", _activeUser_Element.ToLinkReference(context));
members.Add("_strengthStream", _strengthStream_Element.ToLinkReference(context));
members.Add("_axisStream", _axisStream_Element.ToLinkReference(context));
members.Add("_primaryStream", _primaryStream_Element.ToLinkReference(context));
members.Add("_secondaryStream", _secondaryStream_Element.ToLinkReference(context));
members.Add("_grabStream", _grabStream_Element.ToLinkReference(context));
}

}
}
