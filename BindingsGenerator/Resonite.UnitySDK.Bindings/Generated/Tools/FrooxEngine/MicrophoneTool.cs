
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MicrophoneTool
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MicrophoneTool")]
public partial class MicrophoneTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.MicrophoneTool.RecordFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MicrophoneTool.RecordFormat>, global::FrooxEngine.MicrophoneTool.RecordFormat> Format_Element = new();
public global::System.Single Quality { get => Quality_Element.Data; set => Quality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Quality_Element = new();
public global::FrooxEngine.MicrophoneTool.RecordMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MicrophoneTool.RecordMode>, global::FrooxEngine.MicrophoneTool.RecordMode> Mode_Element = new();
public global::FrooxEngine.MicrophoneTool.DataSource Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MicrophoneTool.DataSource>, global::FrooxEngine.MicrophoneTool.DataSource> Source_Element = new();
public global::FrooxEngine.User RecordingUser { get => RecordingUser_Element.Data; set => RecordingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> RecordingUser_Element = new();
public global::System.Boolean IsRecording { get => IsRecording_Element.Data; set => IsRecording_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsRecording_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format_Element.Data.ToResoniteLinkField());
members.Add("Quality", Quality_Element.Data.ToResoniteLinkField());
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
members.Add("Source", Source_Element.Data.ToResoniteLinkField());
members.Add("RecordingUser", RecordingUser_Element.Data.ToResoniteReference(context));
members.Add("IsRecording", IsRecording_Element.Data.ToResoniteLinkField());
}

}
}
