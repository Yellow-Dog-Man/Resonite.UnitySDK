
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver
// Generated on: úterý 24. února 2026 18:20:32
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver")]
public partial class AvatarExpressionDriver : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IMouthTrackingSourceComponent DataSource;
public global::System.Single StrengthMultiplier;
public global::FrooxEngine.IField<global::System.Single> VolumeSource;
public global::FrooxEngine.IField<global::System.Single> SilenceSource;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarExpressionDriver.ExpressionDriver> ExpressionDrivers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DataSource", DataSource.ToResoniteReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("VolumeSource", VolumeSource.ToResoniteReference(context));
members.Add("SilenceSource", SilenceSource.ToResoniteReference(context));
members.Add("ExpressionDrivers", new ResoniteLink.SyncList()
{
    Elements = ExpressionDrivers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
