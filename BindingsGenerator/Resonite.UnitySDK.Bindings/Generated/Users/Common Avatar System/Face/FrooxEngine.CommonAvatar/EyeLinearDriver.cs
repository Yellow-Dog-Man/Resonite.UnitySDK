
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver
// Generated on: středa 25. února 2026 16:14:46
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.CommonAvatar.EyeManager EyeManager;
public UnityEngine.Vector2 ProjectionPlaneSize;
public global::System.Single ProjectionPointDistance;
public UnityEngine.Vector2 PositionOffsetCenter;
public UnityEngine.Vector2 PositionOffsetRange;
public global::System.Single MinimumTargetPointDistance;
public global::FrooxEngine.CommonAvatar.EyeLinearDriver.ClampMode PositionClampMode;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> LeftCloseSubtractLimits;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> RightCloseSubtractLimits;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeLinearDriver.EyeCloseLimit> CombinedCloseSubtractLimits;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeLinearDriver.Eye> Eyes;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EyeManager", EyeManager.ToResoniteReference(context));
members.Add("ProjectionPlaneSize", ProjectionPlaneSize.ToResoniteLinkField());
members.Add("ProjectionPointDistance", ProjectionPointDistance.ToResoniteLinkField());
members.Add("PositionOffsetCenter", PositionOffsetCenter.ToResoniteLinkField());
members.Add("PositionOffsetRange", PositionOffsetRange.ToResoniteLinkField());
members.Add("MinimumTargetPointDistance", MinimumTargetPointDistance.ToResoniteLinkField());
members.Add("PositionClampMode", PositionClampMode.ToResoniteLinkField());
members.Add("LeftCloseSubtractLimits", new ResoniteLink.SyncList()
{
    Elements = LeftCloseSubtractLimits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("RightCloseSubtractLimits", new ResoniteLink.SyncList()
{
    Elements = RightCloseSubtractLimits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("CombinedCloseSubtractLimits", new ResoniteLink.SyncList()
{
    Elements = CombinedCloseSubtractLimits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Eyes", new ResoniteLink.SyncList()
{
    Elements = Eyes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
