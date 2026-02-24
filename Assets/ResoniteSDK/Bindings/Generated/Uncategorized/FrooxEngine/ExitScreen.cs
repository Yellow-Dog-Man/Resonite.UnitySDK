
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExitScreen
// Generated on: úterý 24. února 2026 18:20:20
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.String _sponsorName;
public global::FrooxEngine.StaticTexture2D _sponsorIcon;
public global::FrooxEngine.UIX.Text _shoutouts;
public global::FrooxEngine.UIX.Text _exitMessage;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_sponsorName", _sponsorName.ToResoniteLinkField());
members.Add("_sponsorIcon", _sponsorIcon.ToResoniteReference(context));
members.Add("_shoutouts", _shoutouts.ToResoniteReference(context));
members.Add("_exitMessage", _exitMessage.ToResoniteReference(context));
}

}
}
