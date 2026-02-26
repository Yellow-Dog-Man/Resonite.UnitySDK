
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackPositionDriver
// Generated on: čtvrtek 26. února 2026 15:08:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackPositionDriver")]
public partial class PlaybackPositionDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Target_Element = new();
public global::FrooxEngine.IPlayable Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IPlayable>, global::FrooxEngine.IPlayable> Source_Element = new();
public global::System.Boolean UseNormalizedPosition { get => UseNormalizedPosition_Element.Data; set => UseNormalizedPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseNormalizedPosition_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("UseNormalizedPosition", UseNormalizedPosition_Element.ToLinkField(context));
members.Add("WriteBack", WriteBack_Element.ToLinkField(context));
}

}
}
