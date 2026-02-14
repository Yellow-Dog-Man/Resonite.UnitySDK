
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HostAccessDialog
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HostAccessDialog")]
public partial class HostAccessDialog : global::FrooxEngine.Component

{
    public global::System.String Host;
public global::System.Int32 Port;
public global::FrooxEngine.HostAccessScope AccessType;
public global::FrooxEngine.UIX.Text _hostText;
public global::FrooxEngine.UIX.Text _reasonText;
public global::FrooxEngine.UIX.Button _allowButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Host", Host.ToResoniteLinkField());
members.Add("Port", Port.ToResoniteLinkField());
members.Add("AccessType", AccessType.ToResoniteLinkField());
members.Add("_hostText", _hostText.ToResoniteReference(context));
members.Add("_reasonText", _reasonText.ToResoniteReference(context));
members.Add("_allowButton", _allowButton.ToResoniteReference(context));
}

}
}
