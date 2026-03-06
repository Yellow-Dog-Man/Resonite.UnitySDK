
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTexture2D
// Generated on: pátek 6. března 2026 14:18:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticTexture2D")]
public partial class StaticTexture2D : global::FrooxEngine.StaticTextureProvider<global::FrooxEngine.Texture2D,global::Elements.Assets.Bitmap2D,global::Elements.Assets.BitmapMetadata,global::FrooxEngine.Texture2DVariantDescriptor>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>

{
    public global::System.Boolean IsNormalMap { get => IsNormalMap_Element.Data; set => IsNormalMap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsNormalMap_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeU { get => WrapModeU_Element.Data; set => WrapModeU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeU_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeV { get => WrapModeV_Element.Data; set => WrapModeV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeV_Element = new();
public global::System.Single PowerOfTwoAlignThreshold { get => PowerOfTwoAlignThreshold_Element.Data; set => PowerOfTwoAlignThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PowerOfTwoAlignThreshold_Element = new();
public global::System.Boolean CrunchCompressed { get => CrunchCompressed_Element.Data; set => CrunchCompressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CrunchCompressed_Element = new();
public global::System.Nullable<global::System.Int32> MinSize { get => MinSize_Element.Data; set => MinSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MinSize_Element = new();
public global::System.Nullable<global::System.Int32> MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MaxSize_Element = new();
public global::System.Boolean MipMaps { get => MipMaps_Element.Data; set => MipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MipMaps_Element = new();
public global::System.Boolean KeepOriginalMipMaps { get => KeepOriginalMipMaps_Element.Data; set => KeepOriginalMipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepOriginalMipMaps_Element = new();
public global::Elements.Assets.Filtering MipMapFilter { get => MipMapFilter_Element.Data; set => MipMapFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.Filtering>, global::Elements.Assets.Filtering> MipMapFilter_Element = new();
public global::System.Boolean Readable { get => Readable_Element.Data; set => Readable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Readable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsNormalMap", IsNormalMap_Element.ToLinkField(context));
members.Add("WrapModeU", WrapModeU_Element.ToLinkField(context));
members.Add("WrapModeV", WrapModeV_Element.ToLinkField(context));
members.Add("PowerOfTwoAlignThreshold", PowerOfTwoAlignThreshold_Element.ToLinkField(context));
members.Add("CrunchCompressed", CrunchCompressed_Element.ToLinkField(context));
members.Add("MinSize", MinSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("MipMaps", MipMaps_Element.ToLinkField(context));
members.Add("KeepOriginalMipMaps", KeepOriginalMipMaps_Element.ToLinkField(context));
members.Add("MipMapFilter", MipMapFilter_Element.ToLinkField(context));
members.Add("Readable", Readable_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task<global::System.Boolean> BleedColorToAlpha(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "BleedColorToAlpha";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> FlipHorizontal(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "FlipHorizontal";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> FlipVertical(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "FlipVertical";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Rotate90CW(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Rotate90CW";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Rotate90CCW(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Rotate90CCW";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Rotate180(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Rotate180";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> MakeSquare(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "MakeSquare";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TileLoop(UnityEngine.Vector2 transition, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "TileLoop";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("transition", transition.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TileMirror(UnityEngine.Vector2 transition, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "TileMirror";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("transition", transition.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Rescale(global::System.Int32 size, global::Elements.Assets.Filtering filtering, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Rescale";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("size", size.ToData());
__message.Arguments.Add("filtering", filtering.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Rescale(UnityEngine.Vector2Int size, global::Elements.Assets.Filtering filtering, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Rescale";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("size", size.ToData());
__message.Arguments.Add("filtering", filtering.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Crop(UnityEngine.Vector2Int position, UnityEngine.Vector2Int size, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Crop";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("position", position.ToData());
__message.Arguments.Add("size", size.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Trim(UnityEngine.Color color, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Trim";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("color", color.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> Trim(UnityEngine.Color32 color, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Trim";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("color", color.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TrimTransparent(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "TrimTransparent";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TrimByCornerColor(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "TrimByCornerColor";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> LuminanceThreshold(global::System.Single threshold, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "LuminanceThreshold";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("threshold", threshold.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> LuminanceThreshold(global::System.Single threshold, UnityEngine.Color above, UnityEngine.Color below, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "LuminanceThreshold";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("threshold", threshold.ToData());
__message.Arguments.Add("above", above.ToData());
__message.Arguments.Add("below", below.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> LocalizedLuminanceThreshold(global::System.Single threshold, global::System.Int32 range, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "LocalizedLuminanceThreshold";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("threshold", threshold.ToData());
__message.Arguments.Add("range", range.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> LocalizedLuminanceThreshold(global::System.Single threshold, global::System.Int32 range, UnityEngine.Color above, UnityEngine.Color below, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "LocalizedLuminanceThreshold";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("threshold", threshold.ToData());
__message.Arguments.Add("range", range.ToData());
__message.Arguments.Add("above", above.ToData());
__message.Arguments.Add("below", below.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> KMeansCluster(global::System.Int32 k, global::System.Single positionWeight, global::System.Int32 batchSize, global::System.Single passesOverData, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "KMeansCluster";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("k", k.ToData());
__message.Arguments.Add("positionWeight", positionWeight.ToData());
__message.Arguments.Add("batchSize", batchSize.ToData());
__message.Arguments.Add("passesOverData", passesOverData.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
