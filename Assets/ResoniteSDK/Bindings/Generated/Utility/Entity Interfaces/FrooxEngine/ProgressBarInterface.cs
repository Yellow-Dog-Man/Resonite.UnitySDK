
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProgressBarInterface
// Generated on: pátek 13. února 2026 5:52:38
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ProgressKnown", new ResoniteLink.Reference() { });
members.Add("Progress", new ResoniteLink.Reference() { });
members.Add("ProcessedCountKnown", new ResoniteLink.Reference() { });
members.Add("ProcessedItemCount", new ResoniteLink.Reference() { });
members.Add("TotalItemCountKnown", new ResoniteLink.Reference() { });
members.Add("TotalItemCount", new ResoniteLink.Reference() { });
members.Add("PhaseName", new ResoniteLink.Reference() { });
members.Add("SubPhaseName", new ResoniteLink.Reference() { });
members.Add("Stage", new ResoniteLink.Reference() { });
members.Add("HasCompleted", new ResoniteLink.Reference() { });
members.Add("HasFailed", new ResoniteLink.Reference() { });
members.Add("CompletionMessage", new ResoniteLink.Reference() { });
members.Add("FailureReason", new ResoniteLink.Reference() { });
members.Add("CanBeHidden", new ResoniteLink.Reference() { });
}

}
}
