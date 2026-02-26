
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData")]
public partial class AvatarRawEyeData : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData LeftEye = new();
public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData RightEye = new();
public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData CombinedEye = new();
public global::System.Single ConvergenceDistance { get => ConvergenceDistance_Element.Data; set => ConvergenceDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ConvergenceDistance_Element = new();
public global::System.Double Timestamp { get => Timestamp_Element.Data; set => Timestamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> Timestamp_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftEye", new ResoniteLink.SyncObject() { Members = LeftEye.CollectMembers(context) });
members.Add("RightEye", new ResoniteLink.SyncObject() { Members = RightEye.CollectMembers(context) });
members.Add("CombinedEye", new ResoniteLink.SyncObject() { Members = CombinedEye.CollectMembers(context) });
members.Add("ConvergenceDistance", ConvergenceDistance_Element.Data.ToResoniteLinkField());
members.Add("Timestamp", Timestamp_Element.Data.ToResoniteLinkField());
members.Add("_activeUser", _activeUser_Element.Data.ToResoniteReference(context));
}

}
}
