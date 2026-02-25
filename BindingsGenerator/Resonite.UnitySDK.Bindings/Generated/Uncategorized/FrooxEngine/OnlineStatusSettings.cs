
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatusSettings
// Generated on: středa 25. února 2026 16:14:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OnlineStatusSettings")]
public partial class OnlineStatusSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.OnlineStatusSettings>

{
    public global::SkyFrost.Base.OnlineStatus DefaultStatus;
public global::FrooxEngine.OnlineStatusSettings.StatusRememberMode RememberMode;
public global::System.Double RememberTimespan;
public global::FrooxEngine.OnlineStatusSettings.StatusRememberMode InvisibleRememberMode;
public global::System.Double InvisibleRememberTimespan;
public global::System.Double AutoAwayTimespan;
public global::System.Boolean EnableDefaultStatus;
public global::System.Boolean ShowRememberTimespan;
public global::System.Boolean ShowInvisibleRememberTimespan;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultStatus", DefaultStatus.ToResoniteLinkField());
members.Add("RememberMode", RememberMode.ToResoniteLinkField());
members.Add("RememberTimespan", RememberTimespan.ToResoniteLinkField());
members.Add("InvisibleRememberMode", InvisibleRememberMode.ToResoniteLinkField());
members.Add("InvisibleRememberTimespan", InvisibleRememberTimespan.ToResoniteLinkField());
members.Add("AutoAwayTimespan", AutoAwayTimespan.ToResoniteLinkField());
members.Add("EnableDefaultStatus", EnableDefaultStatus.ToResoniteLinkField());
members.Add("ShowRememberTimespan", ShowRememberTimespan.ToResoniteLinkField());
members.Add("ShowInvisibleRememberTimespan", ShowInvisibleRememberTimespan.ToResoniteLinkField());
}

}
}
