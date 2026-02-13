
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HostAccessDialog
// Generated on: pátek 13. února 2026 5:52:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HostAccessDialog")]
public partial class HostAccessDialog : global::FrooxEngine.Component

{
    public global::System.String Host;
public global::System.Int32 Port;
public global::FrooxEngine.HostAccessScope AccessType;
public global::FrooxEngine.UIX.Text _hostText;
public global::FrooxEngine.UIX.Text _reasonText;
public global::FrooxEngine.UIX.Button _allowButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Host", Host.ToResoniteLinkField());
members.Add("Port", Port.ToResoniteLinkField());
members.Add("AccessType", AccessType.ToResoniteLinkField());
members.Add("_hostText", new ResoniteLink.Reference() { });
members.Add("_reasonText", new ResoniteLink.Reference() { });
members.Add("_allowButton", new ResoniteLink.Reference() { });
}

}
}
