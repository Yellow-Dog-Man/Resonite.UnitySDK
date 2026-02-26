
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatusSettings
// Generated on: čtvrtek 26. února 2026 10:04:47
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
    public global::SkyFrost.Base.OnlineStatus DefaultStatus { get => DefaultStatus_Element.Data; set => DefaultStatus_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.OnlineStatus>, global::SkyFrost.Base.OnlineStatus> DefaultStatus_Element = new();
public global::FrooxEngine.OnlineStatusSettings.StatusRememberMode RememberMode { get => RememberMode_Element.Data; set => RememberMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OnlineStatusSettings.StatusRememberMode>, global::FrooxEngine.OnlineStatusSettings.StatusRememberMode> RememberMode_Element = new();
public global::System.Double RememberTimespan { get => RememberTimespan_Element.Data; set => RememberTimespan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> RememberTimespan_Element = new();
public global::FrooxEngine.OnlineStatusSettings.StatusRememberMode InvisibleRememberMode { get => InvisibleRememberMode_Element.Data; set => InvisibleRememberMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OnlineStatusSettings.StatusRememberMode>, global::FrooxEngine.OnlineStatusSettings.StatusRememberMode> InvisibleRememberMode_Element = new();
public global::System.Double InvisibleRememberTimespan { get => InvisibleRememberTimespan_Element.Data; set => InvisibleRememberTimespan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> InvisibleRememberTimespan_Element = new();
public global::System.Double AutoAwayTimespan { get => AutoAwayTimespan_Element.Data; set => AutoAwayTimespan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> AutoAwayTimespan_Element = new();
public global::System.Boolean EnableDefaultStatus { get => EnableDefaultStatus_Element.Data; set => EnableDefaultStatus_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnableDefaultStatus_Element = new();
public global::System.Boolean ShowRememberTimespan { get => ShowRememberTimespan_Element.Data; set => ShowRememberTimespan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowRememberTimespan_Element = new();
public global::System.Boolean ShowInvisibleRememberTimespan { get => ShowInvisibleRememberTimespan_Element.Data; set => ShowInvisibleRememberTimespan_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowInvisibleRememberTimespan_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultStatus", DefaultStatus_Element.Data.ToResoniteLinkField());
members.Add("RememberMode", RememberMode_Element.Data.ToResoniteLinkField());
members.Add("RememberTimespan", RememberTimespan_Element.Data.ToResoniteLinkField());
members.Add("InvisibleRememberMode", InvisibleRememberMode_Element.Data.ToResoniteLinkField());
members.Add("InvisibleRememberTimespan", InvisibleRememberTimespan_Element.Data.ToResoniteLinkField());
members.Add("AutoAwayTimespan", AutoAwayTimespan_Element.Data.ToResoniteLinkField());
members.Add("EnableDefaultStatus", EnableDefaultStatus_Element.Data.ToResoniteLinkField());
members.Add("ShowRememberTimespan", ShowRememberTimespan_Element.Data.ToResoniteLinkField());
members.Add("ShowInvisibleRememberTimespan", ShowInvisibleRememberTimespan_Element.Data.ToResoniteLinkField());
}

}
}
