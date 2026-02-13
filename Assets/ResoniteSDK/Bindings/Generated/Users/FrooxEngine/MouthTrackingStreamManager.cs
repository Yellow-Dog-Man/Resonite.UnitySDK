
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MouthTrackingStreamManager
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("IsTracking", new ResoniteLink.Reference() { });
members.Add("Jaw", new ResoniteLink.Reference() { });
members.Add("JawOpen", new ResoniteLink.Reference() { });
members.Add("Tongue", new ResoniteLink.Reference() { });
members.Add("TongueRoll", new ResoniteLink.Reference() { });
members.Add("LipUpperLeftRaise", new ResoniteLink.Reference() { });
members.Add("LipUpperRightRaise", new ResoniteLink.Reference() { });
members.Add("LipLowerLeftaise", new ResoniteLink.Reference() { });
members.Add("LipLowerRightRaise", new ResoniteLink.Reference() { });
members.Add("LipUpperHorizontal", new ResoniteLink.Reference() { });
members.Add("LipLowerHorizontal", new ResoniteLink.Reference() { });
members.Add("MouthLeftSmileFrown", new ResoniteLink.Reference() { });
members.Add("MouthRightSmileFrown", new ResoniteLink.Reference() { });
members.Add("MouthLeftDimple", new ResoniteLink.Reference() { });
members.Add("MouthRightDimple", new ResoniteLink.Reference() { });
members.Add("MouthPoutLeft", new ResoniteLink.Reference() { });
members.Add("MouthPoutRight", new ResoniteLink.Reference() { });
members.Add("LipTopLeftOverturn", new ResoniteLink.Reference() { });
members.Add("LipTopRightOverturn", new ResoniteLink.Reference() { });
members.Add("LipBottomLeftOverturn", new ResoniteLink.Reference() { });
members.Add("LipBottomRightOverturn", new ResoniteLink.Reference() { });
members.Add("LipTopLeftOverUnder", new ResoniteLink.Reference() { });
members.Add("LipTopRightOverUnder", new ResoniteLink.Reference() { });
members.Add("LipBottomLeftOverUnder", new ResoniteLink.Reference() { });
members.Add("LipBottomRightOverUnder", new ResoniteLink.Reference() { });
members.Add("LipLeftStretchTighten", new ResoniteLink.Reference() { });
members.Add("LipRightStretchTighten", new ResoniteLink.Reference() { });
members.Add("LipsLeftPress", new ResoniteLink.Reference() { });
members.Add("LipsRightPress", new ResoniteLink.Reference() { });
members.Add("CheekLeftPuffSuck", new ResoniteLink.Reference() { });
members.Add("CheekRightPuffSuck", new ResoniteLink.Reference() { });
members.Add("CheekLeftRaise", new ResoniteLink.Reference() { });
members.Add("CheekRightRaise", new ResoniteLink.Reference() { });
members.Add("NoseWrinkleLeft", new ResoniteLink.Reference() { });
members.Add("NoseWrinkleRight", new ResoniteLink.Reference() { });
members.Add("ChinRaiseBottom", new ResoniteLink.Reference() { });
members.Add("ChinRaiseTop", new ResoniteLink.Reference() { });
}

}
}
