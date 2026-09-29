
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Utility.Tools.VideoStreamSpawner
// Generated on: pátek 14. srpna 2026 21:58:18
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Utility.Tools
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Utility.Tools.VideoStreamSpawner")]
public partial class VideoStreamSpawner : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean StreamActive { get => StreamActive_Element.Data; set => StreamActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> StreamActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StreamActive", StreamActive_Element.ToLinkField(context));
}

}
}
