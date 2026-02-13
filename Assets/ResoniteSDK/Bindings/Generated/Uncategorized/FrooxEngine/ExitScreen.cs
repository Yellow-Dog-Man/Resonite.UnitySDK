
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExitScreen
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExitScreen")]
public partial class ExitScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::System.String _sponsorName;
public global::FrooxEngine.StaticTexture2D _sponsorIcon;
public global::FrooxEngine.UIX.Text _shoutouts;
public global::FrooxEngine.UIX.Text _exitMessage;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_sponsorName", _sponsorName.ToResoniteLinkField());
members.Add("_sponsorIcon", new ResoniteLink.Reference() { });
members.Add("_shoutouts", new ResoniteLink.Reference() { });
members.Add("_exitMessage", new ResoniteLink.Reference() { });
}

}
}
