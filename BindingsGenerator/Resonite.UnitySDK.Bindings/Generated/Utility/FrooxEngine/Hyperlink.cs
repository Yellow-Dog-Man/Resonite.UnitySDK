
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Hyperlink
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Hyperlink")]
public partial class Hyperlink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButtonPressReceiver

{
    public System.Uri URL;
public global::System.Boolean OpenOnce;
public global::System.String Reason;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("OpenOnce", OpenOnce.ToResoniteLinkField());
members.Add("Reason", Reason.ToResoniteLinkField());
}

}
}
