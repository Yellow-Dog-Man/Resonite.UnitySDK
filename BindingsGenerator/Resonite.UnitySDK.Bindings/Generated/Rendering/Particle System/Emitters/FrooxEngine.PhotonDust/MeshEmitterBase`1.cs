
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshEmitterBase<>
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.MeshEmitterBase<>")]
public abstract partial class MeshEmitterBase<E> : global::FrooxEngine.PhotonDust.TransformableEmitter<E>
	

{
    public global::PhotonDust.MeshEmissionSource EmitFrom { get => EmitFrom_Element.Data; set => EmitFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.MeshEmissionSource>, global::PhotonDust.MeshEmissionSource> EmitFrom_Element = new();
public global::System.Boolean UseVertexColors { get => UseVertexColors_Element.Data; set => UseVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVertexColors_Element = new();
public global::System.Boolean UniformDistribution { get => UniformDistribution_Element.Data; set => UniformDistribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UniformDistribution_Element = new();
public global::PhotonDust.MeshEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.MeshEmitterDirection>, global::PhotonDust.MeshEmitterDirection> DirectionMode_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> ColorTexture { get => ColorTexture_Element.Data; set => ColorTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> ColorTexture_Element = new();
public global::Elements.Assets.WrapMode WrapMode { get => WrapMode_Element.Data; set => WrapMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.WrapMode>, global::Elements.Assets.WrapMode> WrapMode_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public global::System.Nullable<UnityEngine.Rect> ClipRect { get => ClipRect_Element.Data; set => ClipRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Rect>>, global::System.Nullable<UnityEngine.Rect>> ClipRect_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EmitFrom", EmitFrom_Element.ToLinkField(context));
members.Add("UseVertexColors", UseVertexColors_Element.ToLinkField(context));
members.Add("UniformDistribution", UniformDistribution_Element.ToLinkField(context));
members.Add("DirectionMode", DirectionMode_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
members.Add("ColorTexture", ColorTexture_Element.ToLinkReference(context));
members.Add("WrapMode", WrapMode_Element.ToLinkField(context));
members.Add("UVOffset", UVOffset_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("ClipRect", ClipRect_Element.ToLinkField(context));
}

}
}
