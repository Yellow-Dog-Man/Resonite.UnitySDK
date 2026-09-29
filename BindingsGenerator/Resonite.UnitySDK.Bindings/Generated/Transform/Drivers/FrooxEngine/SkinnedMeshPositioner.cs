
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SkinnedMeshPositioner
// Generated on: pátek 14. srpna 2026 21:57:46
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SkinnedMeshPositioner")]
public partial class SkinnedMeshPositioner : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.SkinnedMeshRenderer Skin { get => Skin_Element.Data; set => Skin_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> Skin_Element = new();
public global::System.Int32 TriangleIndex { get => TriangleIndex_Element.Data; set => TriangleIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TriangleIndex_Element = new();
public UnityEngine.Vector3 BarycentricCoordinate { get => BarycentricCoordinate_Element.Data; set => BarycentricCoordinate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BarycentricCoordinate_Element = new();
public UnityEngine.Vector3 LocalPosition { get => LocalPosition_Element.Data; set => LocalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalPosition_Element = new();
public UnityEngine.Quaternion LocalRotation { get => LocalRotation_Element.Data; set => LocalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LocalRotation_Element = new();
public UnityEngine.Vector3 LocalScale { get => LocalScale_Element.Data; set => LocalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive { get => PositionDrive_Element.Data; set => PositionDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PositionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> RotationDrive { get => RotationDrive_Element.Data; set => RotationDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> RotationDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> ScaleDrive { get => ScaleDrive_Element.Data; set => ScaleDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ScaleDrive_Element = new();
public global::System.Boolean AlwaysUseFlatNormal { get => AlwaysUseFlatNormal_Element.Data; set => AlwaysUseFlatNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysUseFlatNormal_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Skin", Skin_Element.ToLinkReference(context));
members.Add("TriangleIndex", TriangleIndex_Element.ToLinkField(context));
members.Add("BarycentricCoordinate", BarycentricCoordinate_Element.ToLinkField(context));
members.Add("LocalPosition", LocalPosition_Element.ToLinkField(context));
members.Add("LocalRotation", LocalRotation_Element.ToLinkField(context));
members.Add("LocalScale", LocalScale_Element.ToLinkField(context));
members.Add("PositionDrive", PositionDrive_Element.ToLinkReference(context));
members.Add("RotationDrive", RotationDrive_Element.ToLinkReference(context));
members.Add("ScaleDrive", ScaleDrive_Element.ToLinkReference(context));
members.Add("AlwaysUseFlatNormal", AlwaysUseFlatNormal_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task<global::System.Boolean> ComputeParameters(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ComputeParameters";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
