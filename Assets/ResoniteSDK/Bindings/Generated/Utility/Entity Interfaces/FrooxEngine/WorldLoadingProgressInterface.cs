
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadingProgressInterface
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Progress", new ResoniteLink.Reference() { });
members.Add("WorldName", new ResoniteLink.Reference() { });
members.Add("Stage", new ResoniteLink.Reference() { });
members.Add("PhaseName", new ResoniteLink.Reference() { });
members.Add("SubPhaseName", new ResoniteLink.Reference() { });
members.Add("HasCompleted", new ResoniteLink.Reference() { });
members.Add("HasFailed", new ResoniteLink.Reference() { });
members.Add("CompletionMessage", new ResoniteLink.Reference() { });
members.Add("FailureReason", new ResoniteLink.Reference() { });
members.Add("LoadingAssets", new ResoniteLink.Reference() { });
members.Add("LoadedAssets", new ResoniteLink.Reference() { });
members.Add("TotalAssets", new ResoniteLink.Reference() { });
members.Add("LoadedTextures2D", new ResoniteLink.Reference() { });
members.Add("TotalTextures2D", new ResoniteLink.Reference() { });
members.Add("LoadedTextures3D", new ResoniteLink.Reference() { });
members.Add("TotalTextures3D", new ResoniteLink.Reference() { });
members.Add("LoadedCubemaps", new ResoniteLink.Reference() { });
members.Add("TotalCubemaps", new ResoniteLink.Reference() { });
members.Add("LoadedVideos", new ResoniteLink.Reference() { });
members.Add("TotalVideos", new ResoniteLink.Reference() { });
members.Add("LoadedMeshes", new ResoniteLink.Reference() { });
members.Add("TotalMeshes", new ResoniteLink.Reference() { });
members.Add("LoadedAudioClips", new ResoniteLink.Reference() { });
members.Add("TotalAudioClips", new ResoniteLink.Reference() { });
members.Add("LoadedShaders", new ResoniteLink.Reference() { });
members.Add("TotalShaders", new ResoniteLink.Reference() { });
members.Add("LoadedFonts", new ResoniteLink.Reference() { });
members.Add("TotalFonts", new ResoniteLink.Reference() { });
members.Add("BytesDownloaded", new ResoniteLink.Reference() { });
members.Add("TotalBytes", new ResoniteLink.Reference() { });
members.Add("BytesPerSecond", new ResoniteLink.Reference() { });
members.Add("ProgressBar", new ResoniteLink.Reference() { });
}

}
}
