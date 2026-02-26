
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoLookAtUser
// Generated on: čtvrtek 26. února 2026 15:09:07
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AutoLookAtUser")]
public partial class AutoLookAtUser : global::FrooxEngine.Component

{
    public global::System.Single RetargetDistance { get => RetargetDistance_Element.Data; set => RetargetDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RetargetDistance_Element = new();
public global::System.Single LerpSpeed { get => LerpSpeed_Element.Data; set => LerpSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LerpSpeed_Element = new();
public global::FrooxEngine.User TargetedUser { get => TargetedUser_Element.Data; set => TargetedUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> TargetedUser_Element = new();
public global::System.Boolean AutoTarget { get => AutoTarget_Element.Data; set => AutoTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoTarget_Element = new();
public global::System.Boolean ExcludeActiveUser { get => ExcludeActiveUser_Element.Data; set => ExcludeActiveUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeActiveUser_Element = new();
public UnityEngine.Vector3 SwingReference { get => SwingReference_Element.Data; set => SwingReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SwingReference_Element = new();
public UnityEngine.Vector3 TwistReference { get => TwistReference_Element.Data; set => TwistReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TwistReference_Element = new();
public global::System.Single MaxSwing { get => MaxSwing_Element.Data; set => MaxSwing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSwing_Element = new();
public global::System.Single MaxTwist { get => MaxTwist_Element.Data; set => MaxTwist_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTwist_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RetargetDistance", RetargetDistance_Element.ToLinkField(context));
members.Add("LerpSpeed", LerpSpeed_Element.ToLinkField(context));
members.Add("TargetedUser", TargetedUser_Element.ToLinkReference(context));
members.Add("AutoTarget", AutoTarget_Element.ToLinkField(context));
members.Add("ExcludeActiveUser", ExcludeActiveUser_Element.ToLinkField(context));
members.Add("SwingReference", SwingReference_Element.ToLinkField(context));
members.Add("TwistReference", TwistReference_Element.ToLinkField(context));
members.Add("MaxSwing", MaxSwing_Element.ToLinkField(context));
members.Add("MaxTwist", MaxTwist_Element.ToLinkField(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
}
