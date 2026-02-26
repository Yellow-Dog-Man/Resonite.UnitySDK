
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TipTouchSource
// Generated on: čtvrtek 26. února 2026 12:26:55
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TipTouchSource")]
public partial class TipTouchSource : global::FrooxEngine.RaycastTouchSource

{
    public global::System.Boolean UseUserSpaceForDistance { get => UseUserSpaceForDistance_Element.Data; set => UseUserSpaceForDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseUserSpaceForDistance_Element = new();
public global::System.Single TouchDistance { get => TouchDistance_Element.Data; set => TouchDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TouchDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseUserSpaceForDistance", UseUserSpaceForDistance_Element.ToLinkField(context));
members.Add("TouchDistance", TouchDistance_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
}

}
}
