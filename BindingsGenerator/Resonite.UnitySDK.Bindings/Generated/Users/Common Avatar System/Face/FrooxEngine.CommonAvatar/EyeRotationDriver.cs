
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver")]
public partial class EyeRotationDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.EyeManager EyeManager { get => EyeManager_Element.Data; set => EyeManager_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.EyeManager>, global::FrooxEngine.CommonAvatar.EyeManager> EyeManager_Element = new();
public global::System.Single EyeMotionScale { get => EyeMotionScale_Element.Data; set => EyeMotionScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EyeMotionScale_Element = new();
public global::System.Single EyeMotionExp { get => EyeMotionExp_Element.Data; set => EyeMotionExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EyeMotionExp_Element = new();
public global::System.Single MaxSwing { get => MaxSwing_Element.Data; set => MaxSwing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSwing_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.EyeRotationDriver.Eye>, global::FrooxEngine.CommonAvatar.EyeRotationDriver.Eye> Eyes = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EyeManager", EyeManager_Element.Data.ToResoniteReference(context));
members.Add("EyeMotionScale", EyeMotionScale_Element.Data.ToResoniteLinkField());
members.Add("EyeMotionExp", EyeMotionExp_Element.Data.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing_Element.Data.ToResoniteLinkField());
members.Add("Eyes", new ResoniteLink.SyncList()
{
    Elements = Eyes.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
