
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver")]
public partial class AvatarExpressionDriver : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IMouthTrackingSourceComponent DataSource { get => DataSource_Element.Data; set => DataSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>, global::FrooxEngine.IMouthTrackingSourceComponent> DataSource_Element = new();
public global::System.Single StrengthMultiplier { get => StrengthMultiplier_Element.Data; set => StrengthMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrengthMultiplier_Element = new();
public global::FrooxEngine.IField<global::System.Single> VolumeSource { get => VolumeSource_Element.Data; set => VolumeSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> VolumeSource_Element = new();
public global::FrooxEngine.IField<global::System.Single> SilenceSource { get => SilenceSource_Element.Data; set => SilenceSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> SilenceSource_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.AvatarExpressionDriver.ExpressionDriver>, global::FrooxEngine.CommonAvatar.AvatarExpressionDriver.ExpressionDriver> ExpressionDrivers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DataSource", DataSource_Element.Data.ToResoniteReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier_Element.Data.ToResoniteLinkField());
members.Add("VolumeSource", VolumeSource_Element.Data.ToResoniteReference(context));
members.Add("SilenceSource", SilenceSource_Element.Data.ToResoniteReference(context));
members.Add("ExpressionDrivers", new ResoniteLink.SyncList()
{
    Elements = ExpressionDrivers.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
