
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MicrophoneTool
// Generated on: pátek 13. února 2026 5:52:24
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MicrophoneTool")]
public partial class MicrophoneTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.MicrophoneTool.RecordFormat Format;
public global::System.Single Quality;
public global::FrooxEngine.MicrophoneTool.RecordMode Mode;
public global::FrooxEngine.MicrophoneTool.DataSource Source;
public global::FrooxEngine.User RecordingUser;
public global::System.Boolean IsRecording;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Quality", Quality.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Source", Source.ToResoniteLinkField());
members.Add("RecordingUser", new ResoniteLink.Reference() { });
members.Add("IsRecording", IsRecording.ToResoniteLinkField());
}

}
}
