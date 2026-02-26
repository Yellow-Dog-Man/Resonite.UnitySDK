
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProgressBarInterface
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProgressBarInterface")]
public partial class ProgressBarInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.Boolean> ProgressKnown { get => ProgressKnown_Element.Data; set => ProgressKnown_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> ProgressKnown_Element = new();
public global::FrooxEngine.IField<global::System.Single> Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Progress_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> ProcessedCountKnown { get => ProcessedCountKnown_Element.Data; set => ProcessedCountKnown_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> ProcessedCountKnown_Element = new();
public global::FrooxEngine.IField<global::System.Int32> ProcessedItemCount { get => ProcessedItemCount_Element.Data; set => ProcessedItemCount_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> ProcessedItemCount_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> TotalItemCountKnown { get => TotalItemCountKnown_Element.Data; set => TotalItemCountKnown_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> TotalItemCountKnown_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalItemCount { get => TotalItemCount_Element.Data; set => TotalItemCount_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalItemCount_Element = new();
public global::FrooxEngine.IField<global::System.String> PhaseName { get => PhaseName_Element.Data; set => PhaseName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> PhaseName_Element = new();
public global::FrooxEngine.IField<global::System.String> SubPhaseName { get => SubPhaseName_Element.Data; set => SubPhaseName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> SubPhaseName_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ProgressStage> Stage { get => Stage_Element.Data; set => Stage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::FrooxEngine.ProgressStage>>, global::FrooxEngine.IField<global::FrooxEngine.ProgressStage>> Stage_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasCompleted { get => HasCompleted_Element.Data; set => HasCompleted_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasCompleted_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasFailed { get => HasFailed_Element.Data; set => HasFailed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasFailed_Element = new();
public global::FrooxEngine.IField<global::System.String> CompletionMessage { get => CompletionMessage_Element.Data; set => CompletionMessage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> CompletionMessage_Element = new();
public global::FrooxEngine.IField<global::System.String> FailureReason { get => FailureReason_Element.Data; set => FailureReason_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> FailureReason_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> CanBeHidden { get => CanBeHidden_Element.Data; set => CanBeHidden_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> CanBeHidden_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ProgressKnown", ProgressKnown_Element.ToLinkReference(context));
members.Add("Progress", Progress_Element.ToLinkReference(context));
members.Add("ProcessedCountKnown", ProcessedCountKnown_Element.ToLinkReference(context));
members.Add("ProcessedItemCount", ProcessedItemCount_Element.ToLinkReference(context));
members.Add("TotalItemCountKnown", TotalItemCountKnown_Element.ToLinkReference(context));
members.Add("TotalItemCount", TotalItemCount_Element.ToLinkReference(context));
members.Add("PhaseName", PhaseName_Element.ToLinkReference(context));
members.Add("SubPhaseName", SubPhaseName_Element.ToLinkReference(context));
members.Add("Stage", Stage_Element.ToLinkReference(context));
members.Add("HasCompleted", HasCompleted_Element.ToLinkReference(context));
members.Add("HasFailed", HasFailed_Element.ToLinkReference(context));
members.Add("CompletionMessage", CompletionMessage_Element.ToLinkReference(context));
members.Add("FailureReason", FailureReason_Element.ToLinkReference(context));
members.Add("CanBeHidden", CanBeHidden_Element.ToLinkReference(context));
}

}
}
