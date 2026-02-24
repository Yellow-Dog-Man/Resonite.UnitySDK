
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawMouthData
// Generated on: úterý 24. února 2026 18:20:32
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawMouthData")]
public partial class AvatarRawMouthData : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.IMouthTrackingSourceComponent DataSource;
public global::System.Single StrengthMultiplier;
public UnityEngine.Vector3 Jaw;
public global::System.Single JawOpen;
public UnityEngine.Vector3 Tongue;
public global::System.Single TongueRoll;
public global::System.Single LipUpperLeftRaise;
public global::System.Single LipUpperRightRaise;
public global::System.Single LipLowerLeftRaise;
public global::System.Single LipLowerRightRaise;
public global::System.Single LipUpperHorizontal;
public global::System.Single LipLowerHorizontal;
public global::System.Single MouthLeftSmileFrown;
public global::System.Single MouthRightSmileFrown;
public global::System.Single MouthLeftDimple;
public global::System.Single MouthRightDimple;
public global::System.Single MouthPout;
public global::System.Single MouthPoutLeft;
public global::System.Single MouthPoutRight;
public global::System.Single LipTopOverturn;
public global::System.Single LipTopLeftOverturn;
public global::System.Single LipTopRightOverturn;
public global::System.Single LipBottomOverturn;
public global::System.Single LipBottomLeftOverturn;
public global::System.Single LipBottomRightOverturn;
public global::System.Single LipTopOverUnder;
public global::System.Single LipTopLeftOverUnder;
public global::System.Single LipTopRightOverUnder;
public global::System.Single LipBottomOverUnder;
public global::System.Single LipBottomLeftOverUnder;
public global::System.Single LipBottomRightOverUnder;
public global::System.Single LipLeftStretchTighten;
public global::System.Single LipRightStretchTighten;
public global::System.Single LipsLeftPress;
public global::System.Single LipsRightPress;
public global::System.Single CheekLeftPuffSuck;
public global::System.Single CheekRightPuffSuck;
public global::System.Single CheekLeftRaise;
public global::System.Single CheekRightRaise;
public global::System.Single NoseWrinkleLeft;
public global::System.Single NoseWrinkleRight;
public global::System.Single ChinRaiseBottom;
public global::System.Single ChinRaiseTop;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DataSource", DataSource.ToResoniteReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("Jaw", Jaw.ToResoniteLinkField());
members.Add("JawOpen", JawOpen.ToResoniteLinkField());
members.Add("Tongue", Tongue.ToResoniteLinkField());
members.Add("TongueRoll", TongueRoll.ToResoniteLinkField());
members.Add("LipUpperLeftRaise", LipUpperLeftRaise.ToResoniteLinkField());
members.Add("LipUpperRightRaise", LipUpperRightRaise.ToResoniteLinkField());
members.Add("LipLowerLeftRaise", LipLowerLeftRaise.ToResoniteLinkField());
members.Add("LipLowerRightRaise", LipLowerRightRaise.ToResoniteLinkField());
members.Add("LipUpperHorizontal", LipUpperHorizontal.ToResoniteLinkField());
members.Add("LipLowerHorizontal", LipLowerHorizontal.ToResoniteLinkField());
members.Add("MouthLeftSmileFrown", MouthLeftSmileFrown.ToResoniteLinkField());
members.Add("MouthRightSmileFrown", MouthRightSmileFrown.ToResoniteLinkField());
members.Add("MouthLeftDimple", MouthLeftDimple.ToResoniteLinkField());
members.Add("MouthRightDimple", MouthRightDimple.ToResoniteLinkField());
members.Add("MouthPout", MouthPout.ToResoniteLinkField());
members.Add("MouthPoutLeft", MouthPoutLeft.ToResoniteLinkField());
members.Add("MouthPoutRight", MouthPoutRight.ToResoniteLinkField());
members.Add("LipTopOverturn", LipTopOverturn.ToResoniteLinkField());
members.Add("LipTopLeftOverturn", LipTopLeftOverturn.ToResoniteLinkField());
members.Add("LipTopRightOverturn", LipTopRightOverturn.ToResoniteLinkField());
members.Add("LipBottomOverturn", LipBottomOverturn.ToResoniteLinkField());
members.Add("LipBottomLeftOverturn", LipBottomLeftOverturn.ToResoniteLinkField());
members.Add("LipBottomRightOverturn", LipBottomRightOverturn.ToResoniteLinkField());
members.Add("LipTopOverUnder", LipTopOverUnder.ToResoniteLinkField());
members.Add("LipTopLeftOverUnder", LipTopLeftOverUnder.ToResoniteLinkField());
members.Add("LipTopRightOverUnder", LipTopRightOverUnder.ToResoniteLinkField());
members.Add("LipBottomOverUnder", LipBottomOverUnder.ToResoniteLinkField());
members.Add("LipBottomLeftOverUnder", LipBottomLeftOverUnder.ToResoniteLinkField());
members.Add("LipBottomRightOverUnder", LipBottomRightOverUnder.ToResoniteLinkField());
members.Add("LipLeftStretchTighten", LipLeftStretchTighten.ToResoniteLinkField());
members.Add("LipRightStretchTighten", LipRightStretchTighten.ToResoniteLinkField());
members.Add("LipsLeftPress", LipsLeftPress.ToResoniteLinkField());
members.Add("LipsRightPress", LipsRightPress.ToResoniteLinkField());
members.Add("CheekLeftPuffSuck", CheekLeftPuffSuck.ToResoniteLinkField());
members.Add("CheekRightPuffSuck", CheekRightPuffSuck.ToResoniteLinkField());
members.Add("CheekLeftRaise", CheekLeftRaise.ToResoniteLinkField());
members.Add("CheekRightRaise", CheekRightRaise.ToResoniteLinkField());
members.Add("NoseWrinkleLeft", NoseWrinkleLeft.ToResoniteLinkField());
members.Add("NoseWrinkleRight", NoseWrinkleRight.ToResoniteLinkField());
members.Add("ChinRaiseBottom", ChinRaiseBottom.ToResoniteLinkField());
members.Add("ChinRaiseTop", ChinRaiseTop.ToResoniteLinkField());
}

}
}
