
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackedHand
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackedHand")]
public partial class TrackedHand : global::FrooxEngine.Component

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::Renderite.Shared.Chirality HandChirality { get => HandChirality_Element.Data; set => HandChirality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> HandChirality_Element = new();
public global::FrooxEngine.Grabber _grabber { get => _grabber_Element.Data; set => _grabber_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _grabber_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("HandChirality", HandChirality_Element.ToLinkField(context));
members.Add("_grabber", _grabber_Element.ToLinkReference(context));
}

}
}
