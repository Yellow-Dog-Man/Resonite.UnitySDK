
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HostAccessDialog
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HostAccessDialog")]
public partial class HostAccessDialog : global::FrooxEngine.Component

{
    public global::System.String Host { get => Host_Element.Data; set => Host_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Host_Element = new();
public global::System.Int32 Port { get => Port_Element.Data; set => Port_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Port_Element = new();
public global::FrooxEngine.HostAccessScope AccessType { get => AccessType_Element.Data; set => AccessType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.HostAccessScope>, global::FrooxEngine.HostAccessScope> AccessType_Element = new();
public global::FrooxEngine.UIX.Text _hostText { get => _hostText_Element.Data; set => _hostText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _hostText_Element = new();
public global::FrooxEngine.UIX.Text _reasonText { get => _reasonText_Element.Data; set => _reasonText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _reasonText_Element = new();
public global::FrooxEngine.UIX.Button _allowButton { get => _allowButton_Element.Data; set => _allowButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _allowButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Host", Host_Element.Data.ToResoniteLinkField());
members.Add("Port", Port_Element.Data.ToResoniteLinkField());
members.Add("AccessType", AccessType_Element.Data.ToResoniteLinkField());
members.Add("_hostText", _hostText_Element.Data.ToResoniteReference(context));
members.Add("_reasonText", _reasonText_Element.Data.ToResoniteReference(context));
members.Add("_allowButton", _allowButton_Element.Data.ToResoniteReference(context));
}

}
}
