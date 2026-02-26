
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver")]
public partial class EyeLinearDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.EyeManager EyeManager { get => EyeManager_Element.Data; set => EyeManager_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.EyeManager>, global::FrooxEngine.CommonAvatar.EyeManager> EyeManager_Element = new();
public UnityEngine.Vector2 ProjectionPlaneSize { get => ProjectionPlaneSize_Element.Data; set => ProjectionPlaneSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ProjectionPlaneSize_Element = new();
public global::System.Single ProjectionPointDistance { get => ProjectionPointDistance_Element.Data; set => ProjectionPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ProjectionPointDistance_Element = new();
public UnityEngine.Vector2 PositionOffsetCenter { get => PositionOffsetCenter_Element.Data; set => PositionOffsetCenter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PositionOffsetCenter_Element = new();
public UnityEngine.Vector2 PositionOffsetRange { get => PositionOffsetRange_Element.Data; set => PositionOffsetRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PositionOffsetRange_Element = new();
public global::System.Single MinimumTargetPointDistance { get => MinimumTargetPointDistance_Element.Data; set => MinimumTargetPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumTargetPointDistance_Element = new();
public global::FrooxEngine.CommonAvatar.EyeLinearDriver.ClampMode PositionClampMode { get => PositionClampMode_Element.Data; set => PositionClampMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.EyeLinearDriver.ClampMode>, global::FrooxEngine.CommonAvatar.EyeLinearDriver.ClampMode> PositionClampMode_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit>, global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> LeftCloseSubtractLimits = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit>, global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> RightCloseSubtractLimits = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit>, global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> CombinedCloseSubtractLimits = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeLinearDriver.Eye>, global::FrooxEngine.CommonAvatar.EyeLinearDriver.Eye> Eyes = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EyeManager", EyeManager_Element.ToLinkReference(context));
members.Add("ProjectionPlaneSize", ProjectionPlaneSize_Element.ToLinkField(context));
members.Add("ProjectionPointDistance", ProjectionPointDistance_Element.ToLinkField(context));
members.Add("PositionOffsetCenter", PositionOffsetCenter_Element.ToLinkField(context));
members.Add("PositionOffsetRange", PositionOffsetRange_Element.ToLinkField(context));
members.Add("MinimumTargetPointDistance", MinimumTargetPointDistance_Element.ToLinkField(context));
members.Add("PositionClampMode", PositionClampMode_Element.ToLinkField(context));
members.Add("LeftCloseSubtractLimits", LeftCloseSubtractLimits.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("RightCloseSubtractLimits", RightCloseSubtractLimits.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("CombinedCloseSubtractLimits", CombinedCloseSubtractLimits.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Eyes", Eyes.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
