
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadingProgressInterface
// Generated on: sobota 14. února 2026 8:58:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLoadingProgressInterface")]
public partial class WorldLoadingProgressInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.Single> Progress;
public global::FrooxEngine.IField<global::System.String> WorldName;
public global::FrooxEngine.IField<global::FrooxEngine.ProgressStage> Stage;
public global::FrooxEngine.IField<global::System.String> PhaseName;
public global::FrooxEngine.IField<global::System.String> SubPhaseName;
public global::FrooxEngine.IField<global::System.Boolean> HasCompleted;
public global::FrooxEngine.IField<global::System.Boolean> HasFailed;
public global::FrooxEngine.IField<global::System.String> CompletionMessage;
public global::FrooxEngine.IField<global::System.String> FailureReason;
public global::FrooxEngine.IField<global::System.Boolean> LoadingAssets;
public global::FrooxEngine.IField<global::System.Int32> LoadedAssets;
public global::FrooxEngine.IField<global::System.Int32> TotalAssets;
public global::FrooxEngine.IField<global::System.Int32> LoadedTextures2D;
public global::FrooxEngine.IField<global::System.Int32> TotalTextures2D;
public global::FrooxEngine.IField<global::System.Int32> LoadedTextures3D;
public global::FrooxEngine.IField<global::System.Int32> TotalTextures3D;
public global::FrooxEngine.IField<global::System.Int32> LoadedCubemaps;
public global::FrooxEngine.IField<global::System.Int32> TotalCubemaps;
public global::FrooxEngine.IField<global::System.Int32> LoadedVideos;
public global::FrooxEngine.IField<global::System.Int32> TotalVideos;
public global::FrooxEngine.IField<global::System.Int32> LoadedMeshes;
public global::FrooxEngine.IField<global::System.Int32> TotalMeshes;
public global::FrooxEngine.IField<global::System.Int32> LoadedAudioClips;
public global::FrooxEngine.IField<global::System.Int32> TotalAudioClips;
public global::FrooxEngine.IField<global::System.Int32> LoadedShaders;
public global::FrooxEngine.IField<global::System.Int32> TotalShaders;
public global::FrooxEngine.IField<global::System.Int32> LoadedFonts;
public global::FrooxEngine.IField<global::System.Int32> TotalFonts;
public global::FrooxEngine.IField<global::System.Int64> BytesDownloaded;
public global::FrooxEngine.IField<global::System.Int64> TotalBytes;
public global::FrooxEngine.IField<global::System.Int64> BytesPerSecond;
public global::FrooxEngine.ProgressBarInterface ProgressBar;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress.ToResoniteReference(context));
members.Add("WorldName", WorldName.ToResoniteReference(context));
members.Add("Stage", Stage.ToResoniteReference(context));
members.Add("PhaseName", PhaseName.ToResoniteReference(context));
members.Add("SubPhaseName", SubPhaseName.ToResoniteReference(context));
members.Add("HasCompleted", HasCompleted.ToResoniteReference(context));
members.Add("HasFailed", HasFailed.ToResoniteReference(context));
members.Add("CompletionMessage", CompletionMessage.ToResoniteReference(context));
members.Add("FailureReason", FailureReason.ToResoniteReference(context));
members.Add("LoadingAssets", LoadingAssets.ToResoniteReference(context));
members.Add("LoadedAssets", LoadedAssets.ToResoniteReference(context));
members.Add("TotalAssets", TotalAssets.ToResoniteReference(context));
members.Add("LoadedTextures2D", LoadedTextures2D.ToResoniteReference(context));
members.Add("TotalTextures2D", TotalTextures2D.ToResoniteReference(context));
members.Add("LoadedTextures3D", LoadedTextures3D.ToResoniteReference(context));
members.Add("TotalTextures3D", TotalTextures3D.ToResoniteReference(context));
members.Add("LoadedCubemaps", LoadedCubemaps.ToResoniteReference(context));
members.Add("TotalCubemaps", TotalCubemaps.ToResoniteReference(context));
members.Add("LoadedVideos", LoadedVideos.ToResoniteReference(context));
members.Add("TotalVideos", TotalVideos.ToResoniteReference(context));
members.Add("LoadedMeshes", LoadedMeshes.ToResoniteReference(context));
members.Add("TotalMeshes", TotalMeshes.ToResoniteReference(context));
members.Add("LoadedAudioClips", LoadedAudioClips.ToResoniteReference(context));
members.Add("TotalAudioClips", TotalAudioClips.ToResoniteReference(context));
members.Add("LoadedShaders", LoadedShaders.ToResoniteReference(context));
members.Add("TotalShaders", TotalShaders.ToResoniteReference(context));
members.Add("LoadedFonts", LoadedFonts.ToResoniteReference(context));
members.Add("TotalFonts", TotalFonts.ToResoniteReference(context));
members.Add("BytesDownloaded", BytesDownloaded.ToResoniteReference(context));
members.Add("TotalBytes", TotalBytes.ToResoniteReference(context));
members.Add("BytesPerSecond", BytesPerSecond.ToResoniteReference(context));
members.Add("ProgressBar", ProgressBar.ToResoniteReference(context));
}

}
}
