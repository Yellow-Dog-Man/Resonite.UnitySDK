
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MicrophoneTool
// Generated on: sobota 14. února 2026 8:58:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MicrophoneTool")]
public partial class MicrophoneTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.MicrophoneTool.RecordFormat Format;
public global::System.Single Quality;
public global::FrooxEngine.MicrophoneTool.RecordMode Mode;
public global::FrooxEngine.MicrophoneTool.DataSource Source;
public global::FrooxEngine.User RecordingUser;
public global::System.Boolean IsRecording;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Quality", Quality.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Source", Source.ToResoniteLinkField());
members.Add("RecordingUser", RecordingUser.ToResoniteReference(context));
members.Add("IsRecording", IsRecording.ToResoniteLinkField());
}

}
}
