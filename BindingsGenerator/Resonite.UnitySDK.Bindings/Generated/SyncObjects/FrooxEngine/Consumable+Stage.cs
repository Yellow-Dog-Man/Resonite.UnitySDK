
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Consumable+Stage
// Generated on: pátek 14. srpna 2026 21:56:19
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class Consumable
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Consumable+Stage")]
public partial class Stage : global::FrooxEngine.SyncObject

{
    public global::System.Single ConsumeTime { get => ConsumeTime_Element.Data; set => ConsumeTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ConsumeTime_Element = new();
public global::FrooxEngine.Slot OverrideReferencePoint { get => OverrideReferencePoint_Element.Data; set => OverrideReferencePoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideReferencePoint_Element = new();
public global::System.Boolean KeepConsumeProgressOnPause { get => KeepConsumeProgressOnPause_Element.Data; set => KeepConsumeProgressOnPause_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepConsumeProgressOnPause_Element = new();
public global::System.Boolean WaitForResetBeforeStart { get => WaitForResetBeforeStart_Element.Data; set => WaitForResetBeforeStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WaitForResetBeforeStart_Element = new();
public global::System.Boolean IsBeingConsumed { get => IsBeingConsumed_Element.Data; set => IsBeingConsumed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsBeingConsumed_Element = new();
public global::System.Boolean HasBeenConsumed { get => HasBeenConsumed_Element.Data; set => HasBeenConsumed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasBeenConsumed_Element = new();
public global::System.Boolean IsStageActive { get => IsStageActive_Element.Data; set => IsStageActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsStageActive_Element = new();
public global::FrooxEngine.UserRef ConsumedByUser = new();
public global::System.Single NormalizedConsumeProgress { get => NormalizedConsumeProgress_Element.Data; set => NormalizedConsumeProgress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedConsumeProgress_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> StageActiveDrive { get => StageActiveDrive_Element.Data; set => StageActiveDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> StageActiveDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConsumeTime", ConsumeTime_Element.ToLinkField(context));
members.Add("OverrideReferencePoint", OverrideReferencePoint_Element.ToLinkReference(context));
members.Add("KeepConsumeProgressOnPause", KeepConsumeProgressOnPause_Element.ToLinkField(context));
members.Add("WaitForResetBeforeStart", WaitForResetBeforeStart_Element.ToLinkField(context));
members.Add("IsBeingConsumed", IsBeingConsumed_Element.ToLinkField(context));
members.Add("HasBeenConsumed", HasBeenConsumed_Element.ToLinkField(context));
members.Add("IsStageActive", IsStageActive_Element.ToLinkField(context));
members.Add("ConsumedByUser", ConsumedByUser.ToLinkSyncObject(context));
members.Add("NormalizedConsumeProgress", NormalizedConsumeProgress_Element.ToLinkField(context));
members.Add("StageActiveDrive", StageActiveDrive_Element.ToLinkReference(context));
}

}
            }
}
