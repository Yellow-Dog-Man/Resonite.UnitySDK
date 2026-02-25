
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackedHand
// Generated on: středa 25. února 2026 16:13:08
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.User User;
public global::Renderite.Shared.Chirality HandChirality;
public global::FrooxEngine.Grabber _grabber;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("HandChirality", HandChirality.ToResoniteLinkField());
members.Add("_grabber", _grabber.ToResoniteReference(context));
}

}
}
