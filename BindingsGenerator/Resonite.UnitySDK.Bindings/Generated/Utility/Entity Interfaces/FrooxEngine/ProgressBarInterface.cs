
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProgressBarInterface
// Generated on: středa 25. února 2026 16:14:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProgressBarInterface")]
public partial class ProgressBarInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.Boolean> ProgressKnown;
public global::FrooxEngine.IField<global::System.Single> Progress;
public global::FrooxEngine.IField<global::System.Boolean> ProcessedCountKnown;
public global::FrooxEngine.IField<global::System.Int32> ProcessedItemCount;
public global::FrooxEngine.IField<global::System.Boolean> TotalItemCountKnown;
public global::FrooxEngine.IField<global::System.Int32> TotalItemCount;
public global::FrooxEngine.IField<global::System.String> PhaseName;
public global::FrooxEngine.IField<global::System.String> SubPhaseName;
public global::FrooxEngine.IField<global::FrooxEngine.ProgressStage> Stage;
public global::FrooxEngine.IField<global::System.Boolean> HasCompleted;
public global::FrooxEngine.IField<global::System.Boolean> HasFailed;
public global::FrooxEngine.IField<global::System.String> CompletionMessage;
public global::FrooxEngine.IField<global::System.String> FailureReason;
public global::FrooxEngine.IField<global::System.Boolean> CanBeHidden;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ProgressKnown", ProgressKnown.ToResoniteReference(context));
members.Add("Progress", Progress.ToResoniteReference(context));
members.Add("ProcessedCountKnown", ProcessedCountKnown.ToResoniteReference(context));
members.Add("ProcessedItemCount", ProcessedItemCount.ToResoniteReference(context));
members.Add("TotalItemCountKnown", TotalItemCountKnown.ToResoniteReference(context));
members.Add("TotalItemCount", TotalItemCount.ToResoniteReference(context));
members.Add("PhaseName", PhaseName.ToResoniteReference(context));
members.Add("SubPhaseName", SubPhaseName.ToResoniteReference(context));
members.Add("Stage", Stage.ToResoniteReference(context));
members.Add("HasCompleted", HasCompleted.ToResoniteReference(context));
members.Add("HasFailed", HasFailed.ToResoniteReference(context));
members.Add("CompletionMessage", CompletionMessage.ToResoniteReference(context));
members.Add("FailureReason", FailureReason.ToResoniteReference(context));
members.Add("CanBeHidden", CanBeHidden.ToResoniteReference(context));
}

}
}
