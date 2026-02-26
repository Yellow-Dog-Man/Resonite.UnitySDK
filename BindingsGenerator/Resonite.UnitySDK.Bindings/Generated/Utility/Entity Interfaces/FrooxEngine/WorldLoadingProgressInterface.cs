
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadingProgressInterface
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLoadingProgressInterface")]
public partial class WorldLoadingProgressInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.Single> Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Progress_Element = new();
public global::FrooxEngine.IField<global::System.String> WorldName { get => WorldName_Element.Data; set => WorldName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> WorldName_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.ProgressStage> Stage { get => Stage_Element.Data; set => Stage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::FrooxEngine.ProgressStage>>, global::FrooxEngine.IField<global::FrooxEngine.ProgressStage>> Stage_Element = new();
public global::FrooxEngine.IField<global::System.String> PhaseName { get => PhaseName_Element.Data; set => PhaseName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> PhaseName_Element = new();
public global::FrooxEngine.IField<global::System.String> SubPhaseName { get => SubPhaseName_Element.Data; set => SubPhaseName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> SubPhaseName_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasCompleted { get => HasCompleted_Element.Data; set => HasCompleted_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasCompleted_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasFailed { get => HasFailed_Element.Data; set => HasFailed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasFailed_Element = new();
public global::FrooxEngine.IField<global::System.String> CompletionMessage { get => CompletionMessage_Element.Data; set => CompletionMessage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> CompletionMessage_Element = new();
public global::FrooxEngine.IField<global::System.String> FailureReason { get => FailureReason_Element.Data; set => FailureReason_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> FailureReason_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> LoadingAssets { get => LoadingAssets_Element.Data; set => LoadingAssets_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> LoadingAssets_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedAssets { get => LoadedAssets_Element.Data; set => LoadedAssets_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedAssets_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalAssets { get => TotalAssets_Element.Data; set => TotalAssets_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalAssets_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedTextures2D { get => LoadedTextures2D_Element.Data; set => LoadedTextures2D_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedTextures2D_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalTextures2D { get => TotalTextures2D_Element.Data; set => TotalTextures2D_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalTextures2D_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedTextures3D { get => LoadedTextures3D_Element.Data; set => LoadedTextures3D_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedTextures3D_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalTextures3D { get => TotalTextures3D_Element.Data; set => TotalTextures3D_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalTextures3D_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedCubemaps { get => LoadedCubemaps_Element.Data; set => LoadedCubemaps_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedCubemaps_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalCubemaps { get => TotalCubemaps_Element.Data; set => TotalCubemaps_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalCubemaps_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedVideos { get => LoadedVideos_Element.Data; set => LoadedVideos_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedVideos_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalVideos { get => TotalVideos_Element.Data; set => TotalVideos_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalVideos_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedMeshes { get => LoadedMeshes_Element.Data; set => LoadedMeshes_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedMeshes_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalMeshes { get => TotalMeshes_Element.Data; set => TotalMeshes_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalMeshes_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedAudioClips { get => LoadedAudioClips_Element.Data; set => LoadedAudioClips_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedAudioClips_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalAudioClips { get => TotalAudioClips_Element.Data; set => TotalAudioClips_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalAudioClips_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedShaders { get => LoadedShaders_Element.Data; set => LoadedShaders_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedShaders_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalShaders { get => TotalShaders_Element.Data; set => TotalShaders_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalShaders_Element = new();
public global::FrooxEngine.IField<global::System.Int32> LoadedFonts { get => LoadedFonts_Element.Data; set => LoadedFonts_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> LoadedFonts_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalFonts { get => TotalFonts_Element.Data; set => TotalFonts_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalFonts_Element = new();
public global::FrooxEngine.IField<global::System.Int64> BytesDownloaded { get => BytesDownloaded_Element.Data; set => BytesDownloaded_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int64>>, global::FrooxEngine.IField<global::System.Int64>> BytesDownloaded_Element = new();
public global::FrooxEngine.IField<global::System.Int64> TotalBytes { get => TotalBytes_Element.Data; set => TotalBytes_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int64>>, global::FrooxEngine.IField<global::System.Int64>> TotalBytes_Element = new();
public global::FrooxEngine.IField<global::System.Int64> BytesPerSecond { get => BytesPerSecond_Element.Data; set => BytesPerSecond_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int64>>, global::FrooxEngine.IField<global::System.Int64>> BytesPerSecond_Element = new();
public global::FrooxEngine.ProgressBarInterface ProgressBar { get => ProgressBar_Element.Data; set => ProgressBar_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProgressBarInterface>, global::FrooxEngine.ProgressBarInterface> ProgressBar_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress_Element.ToLinkReference(context));
members.Add("WorldName", WorldName_Element.ToLinkReference(context));
members.Add("Stage", Stage_Element.ToLinkReference(context));
members.Add("PhaseName", PhaseName_Element.ToLinkReference(context));
members.Add("SubPhaseName", SubPhaseName_Element.ToLinkReference(context));
members.Add("HasCompleted", HasCompleted_Element.ToLinkReference(context));
members.Add("HasFailed", HasFailed_Element.ToLinkReference(context));
members.Add("CompletionMessage", CompletionMessage_Element.ToLinkReference(context));
members.Add("FailureReason", FailureReason_Element.ToLinkReference(context));
members.Add("LoadingAssets", LoadingAssets_Element.ToLinkReference(context));
members.Add("LoadedAssets", LoadedAssets_Element.ToLinkReference(context));
members.Add("TotalAssets", TotalAssets_Element.ToLinkReference(context));
members.Add("LoadedTextures2D", LoadedTextures2D_Element.ToLinkReference(context));
members.Add("TotalTextures2D", TotalTextures2D_Element.ToLinkReference(context));
members.Add("LoadedTextures3D", LoadedTextures3D_Element.ToLinkReference(context));
members.Add("TotalTextures3D", TotalTextures3D_Element.ToLinkReference(context));
members.Add("LoadedCubemaps", LoadedCubemaps_Element.ToLinkReference(context));
members.Add("TotalCubemaps", TotalCubemaps_Element.ToLinkReference(context));
members.Add("LoadedVideos", LoadedVideos_Element.ToLinkReference(context));
members.Add("TotalVideos", TotalVideos_Element.ToLinkReference(context));
members.Add("LoadedMeshes", LoadedMeshes_Element.ToLinkReference(context));
members.Add("TotalMeshes", TotalMeshes_Element.ToLinkReference(context));
members.Add("LoadedAudioClips", LoadedAudioClips_Element.ToLinkReference(context));
members.Add("TotalAudioClips", TotalAudioClips_Element.ToLinkReference(context));
members.Add("LoadedShaders", LoadedShaders_Element.ToLinkReference(context));
members.Add("TotalShaders", TotalShaders_Element.ToLinkReference(context));
members.Add("LoadedFonts", LoadedFonts_Element.ToLinkReference(context));
members.Add("TotalFonts", TotalFonts_Element.ToLinkReference(context));
members.Add("BytesDownloaded", BytesDownloaded_Element.ToLinkReference(context));
members.Add("TotalBytes", TotalBytes_Element.ToLinkReference(context));
members.Add("BytesPerSecond", BytesPerSecond_Element.ToLinkReference(context));
members.Add("ProgressBar", ProgressBar_Element.ToLinkReference(context));
}

}
}
