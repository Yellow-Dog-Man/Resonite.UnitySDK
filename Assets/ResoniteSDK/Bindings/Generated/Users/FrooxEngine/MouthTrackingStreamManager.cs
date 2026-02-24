
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MouthTrackingStreamManager
// Generated on: úterý 24. února 2026 18:20:30
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MouthTrackingStreamManager")]
public partial class MouthTrackingStreamManager : global::FrooxEngine.Component, global::FrooxEngine.IMouthTrackingSourceComponent

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.ValueStream<global::System.Boolean> IsTracking;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Jaw;
public global::FrooxEngine.ValueStream<global::System.Single> JawOpen;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Tongue;
public global::FrooxEngine.ValueStream<global::System.Single> TongueRoll;
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperLeftRaise;
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperRightRaise;
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerLeftaise;
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerRightRaise;
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperHorizontal;
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerHorizontal;
public global::FrooxEngine.ValueStream<global::System.Single> MouthLeftSmileFrown;
public global::FrooxEngine.ValueStream<global::System.Single> MouthRightSmileFrown;
public global::FrooxEngine.ValueStream<global::System.Single> MouthLeftDimple;
public global::FrooxEngine.ValueStream<global::System.Single> MouthRightDimple;
public global::FrooxEngine.ValueStream<global::System.Single> MouthPoutLeft;
public global::FrooxEngine.ValueStream<global::System.Single> MouthPoutRight;
public global::FrooxEngine.ValueStream<global::System.Single> LipTopLeftOverturn;
public global::FrooxEngine.ValueStream<global::System.Single> LipTopRightOverturn;
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomLeftOverturn;
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomRightOverturn;
public global::FrooxEngine.ValueStream<global::System.Single> LipTopLeftOverUnder;
public global::FrooxEngine.ValueStream<global::System.Single> LipTopRightOverUnder;
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomLeftOverUnder;
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomRightOverUnder;
public global::FrooxEngine.ValueStream<global::System.Single> LipLeftStretchTighten;
public global::FrooxEngine.ValueStream<global::System.Single> LipRightStretchTighten;
public global::FrooxEngine.ValueStream<global::System.Single> LipsLeftPress;
public global::FrooxEngine.ValueStream<global::System.Single> LipsRightPress;
public global::FrooxEngine.ValueStream<global::System.Single> CheekLeftPuffSuck;
public global::FrooxEngine.ValueStream<global::System.Single> CheekRightPuffSuck;
public global::FrooxEngine.ValueStream<global::System.Single> CheekLeftRaise;
public global::FrooxEngine.ValueStream<global::System.Single> CheekRightRaise;
public global::FrooxEngine.ValueStream<global::System.Single> NoseWrinkleLeft;
public global::FrooxEngine.ValueStream<global::System.Single> NoseWrinkleRight;
public global::FrooxEngine.ValueStream<global::System.Single> ChinRaiseBottom;
public global::FrooxEngine.ValueStream<global::System.Single> ChinRaiseTop;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("IsTracking", IsTracking.ToResoniteReference(context));
members.Add("Jaw", Jaw.ToResoniteReference(context));
members.Add("JawOpen", JawOpen.ToResoniteReference(context));
members.Add("Tongue", Tongue.ToResoniteReference(context));
members.Add("TongueRoll", TongueRoll.ToResoniteReference(context));
members.Add("LipUpperLeftRaise", LipUpperLeftRaise.ToResoniteReference(context));
members.Add("LipUpperRightRaise", LipUpperRightRaise.ToResoniteReference(context));
members.Add("LipLowerLeftaise", LipLowerLeftaise.ToResoniteReference(context));
members.Add("LipLowerRightRaise", LipLowerRightRaise.ToResoniteReference(context));
members.Add("LipUpperHorizontal", LipUpperHorizontal.ToResoniteReference(context));
members.Add("LipLowerHorizontal", LipLowerHorizontal.ToResoniteReference(context));
members.Add("MouthLeftSmileFrown", MouthLeftSmileFrown.ToResoniteReference(context));
members.Add("MouthRightSmileFrown", MouthRightSmileFrown.ToResoniteReference(context));
members.Add("MouthLeftDimple", MouthLeftDimple.ToResoniteReference(context));
members.Add("MouthRightDimple", MouthRightDimple.ToResoniteReference(context));
members.Add("MouthPoutLeft", MouthPoutLeft.ToResoniteReference(context));
members.Add("MouthPoutRight", MouthPoutRight.ToResoniteReference(context));
members.Add("LipTopLeftOverturn", LipTopLeftOverturn.ToResoniteReference(context));
members.Add("LipTopRightOverturn", LipTopRightOverturn.ToResoniteReference(context));
members.Add("LipBottomLeftOverturn", LipBottomLeftOverturn.ToResoniteReference(context));
members.Add("LipBottomRightOverturn", LipBottomRightOverturn.ToResoniteReference(context));
members.Add("LipTopLeftOverUnder", LipTopLeftOverUnder.ToResoniteReference(context));
members.Add("LipTopRightOverUnder", LipTopRightOverUnder.ToResoniteReference(context));
members.Add("LipBottomLeftOverUnder", LipBottomLeftOverUnder.ToResoniteReference(context));
members.Add("LipBottomRightOverUnder", LipBottomRightOverUnder.ToResoniteReference(context));
members.Add("LipLeftStretchTighten", LipLeftStretchTighten.ToResoniteReference(context));
members.Add("LipRightStretchTighten", LipRightStretchTighten.ToResoniteReference(context));
members.Add("LipsLeftPress", LipsLeftPress.ToResoniteReference(context));
members.Add("LipsRightPress", LipsRightPress.ToResoniteReference(context));
members.Add("CheekLeftPuffSuck", CheekLeftPuffSuck.ToResoniteReference(context));
members.Add("CheekRightPuffSuck", CheekRightPuffSuck.ToResoniteReference(context));
members.Add("CheekLeftRaise", CheekLeftRaise.ToResoniteReference(context));
members.Add("CheekRightRaise", CheekRightRaise.ToResoniteReference(context));
members.Add("NoseWrinkleLeft", NoseWrinkleLeft.ToResoniteReference(context));
members.Add("NoseWrinkleRight", NoseWrinkleRight.ToResoniteReference(context));
members.Add("ChinRaiseBottom", ChinRaiseBottom.ToResoniteReference(context));
members.Add("ChinRaiseTop", ChinRaiseTop.ToResoniteReference(context));
}

}
}
