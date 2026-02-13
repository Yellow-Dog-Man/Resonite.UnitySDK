
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.CommonAvatar.EyeManager EyeManager;
public global::System.Single EyeMotionScale;
public global::System.Single EyeMotionExp;
public global::System.Single MaxSwing;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.EyeRotationDriver.Eye> Eyes;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("EyeManager", new ResoniteLink.Reference() { });
members.Add("EyeMotionScale", EyeMotionScale.ToResoniteLinkField());
members.Add("EyeMotionExp", EyeMotionExp.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("Eyes", new ResoniteLink.SyncList()
{
    Elements = Eyes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
