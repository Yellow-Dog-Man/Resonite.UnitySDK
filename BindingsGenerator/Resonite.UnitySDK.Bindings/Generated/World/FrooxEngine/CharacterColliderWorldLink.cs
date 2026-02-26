
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterColliderWorldLink
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterColliderWorldLink")]
public partial class CharacterColliderWorldLink : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean OpenOnContactStart { get => OpenOnContactStart_Element.Data; set => OpenOnContactStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OpenOnContactStart_Element = new();
public global::System.Boolean OpenOnContactStay { get => OpenOnContactStay_Element.Data; set => OpenOnContactStay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OpenOnContactStay_Element = new();
public global::System.Boolean OpenOnContactEnd { get => OpenOnContactEnd_Element.Data; set => OpenOnContactEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OpenOnContactEnd_Element = new();
public global::FrooxEngine.WorldLink WorldLink { get => WorldLink_Element.Data; set => WorldLink_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldLink>, global::FrooxEngine.WorldLink> WorldLink_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OpenOnContactStart", OpenOnContactStart_Element.ToLinkField(context));
members.Add("OpenOnContactStay", OpenOnContactStay_Element.ToLinkField(context));
members.Add("OpenOnContactEnd", OpenOnContactEnd_Element.ToLinkField(context));
members.Add("WorldLink", WorldLink_Element.ToLinkReference(context));
}

}
}
