
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackStateDriver
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackStateDriver")]
public partial class PlaybackStateDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPlayable>, global::FrooxEngine.IPlayable> Source_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsPlaying { get => IsPlaying_Element.Data; set => IsPlaying_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> IsPlaying_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsNotPlaying { get => IsNotPlaying_Element.Data; set => IsNotPlaying_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> IsNotPlaying_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsPaused { get => IsPaused_Element.Data; set => IsPaused_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> IsPaused_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsStopped { get => IsStopped_Element.Data; set => IsStopped_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> IsStopped_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.Data.ToResoniteReference(context));
members.Add("IsPlaying", IsPlaying_Element.Data.ToResoniteReference(context));
members.Add("IsNotPlaying", IsNotPlaying_Element.Data.ToResoniteReference(context));
members.Add("IsPaused", IsPaused_Element.Data.ToResoniteReference(context));
members.Add("IsStopped", IsStopped_Element.Data.ToResoniteReference(context));
}

}
}
