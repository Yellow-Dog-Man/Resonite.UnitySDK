
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExitScreen
// Generated on: čtvrtek 26. února 2026 10:04:44
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExitScreen")]
public partial class ExitScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::System.String _sponsorName { get => _sponsorName_Element.Data; set => _sponsorName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _sponsorName_Element = new();
public global::FrooxEngine.StaticTexture2D _sponsorIcon { get => _sponsorIcon_Element.Data; set => _sponsorIcon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _sponsorIcon_Element = new();
public global::FrooxEngine.UIX.Text _shoutouts { get => _shoutouts_Element.Data; set => _shoutouts_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _shoutouts_Element = new();
public global::FrooxEngine.UIX.Text _exitMessage { get => _exitMessage_Element.Data; set => _exitMessage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _exitMessage_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_sponsorName", _sponsorName_Element.Data.ToResoniteLinkField());
members.Add("_sponsorIcon", _sponsorIcon_Element.Data.ToResoniteReference(context));
members.Add("_shoutouts", _shoutouts_Element.Data.ToResoniteReference(context));
members.Add("_exitMessage", _exitMessage_Element.Data.ToResoniteReference(context));
}

}
}
