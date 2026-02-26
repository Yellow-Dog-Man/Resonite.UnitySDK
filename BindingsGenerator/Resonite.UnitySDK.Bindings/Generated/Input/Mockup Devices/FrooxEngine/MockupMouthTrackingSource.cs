
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MockupMouthTrackingSource
// Generated on: čtvrtek 26. února 2026 10:03:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MockupMouthTrackingSource")]
public partial class MockupMouthTrackingSource : global::FrooxEngine.Component, global::FrooxEngine.IMouthTrackingSourceComponent

{
    public UnityEngine.Vector3 Jaw { get => Jaw_Element.Data; set => Jaw_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Jaw_Element = new();
public global::System.Single JawOpen { get => JawOpen_Element.Data; set => JawOpen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> JawOpen_Element = new();
public UnityEngine.Vector3 Tongue { get => Tongue_Element.Data; set => Tongue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Tongue_Element = new();
public global::System.Single TongueRoll { get => TongueRoll_Element.Data; set => TongueRoll_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TongueRoll_Element = new();
public global::System.Single LipUpperLeftRaise { get => LipUpperLeftRaise_Element.Data; set => LipUpperLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipUpperLeftRaise_Element = new();
public global::System.Single LipUpperRightRaise { get => LipUpperRightRaise_Element.Data; set => LipUpperRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipUpperRightRaise_Element = new();
public global::System.Single LipLowerLeftRaise { get => LipLowerLeftRaise_Element.Data; set => LipLowerLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipLowerLeftRaise_Element = new();
public global::System.Single LipLowerRightRaise { get => LipLowerRightRaise_Element.Data; set => LipLowerRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipLowerRightRaise_Element = new();
public global::System.Single LipUpperHorizontal { get => LipUpperHorizontal_Element.Data; set => LipUpperHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipUpperHorizontal_Element = new();
public global::System.Single LipLowerHorizontal { get => LipLowerHorizontal_Element.Data; set => LipLowerHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipLowerHorizontal_Element = new();
public global::System.Single MouthLeftSmileFrown { get => MouthLeftSmileFrown_Element.Data; set => MouthLeftSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthLeftSmileFrown_Element = new();
public global::System.Single MouthRightSmileFrown { get => MouthRightSmileFrown_Element.Data; set => MouthRightSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthRightSmileFrown_Element = new();
public global::System.Single MouthLeftDimple { get => MouthLeftDimple_Element.Data; set => MouthLeftDimple_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthLeftDimple_Element = new();
public global::System.Single MouthRightDimple { get => MouthRightDimple_Element.Data; set => MouthRightDimple_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthRightDimple_Element = new();
public global::System.Single MouthPoutLeft { get => MouthPoutLeft_Element.Data; set => MouthPoutLeft_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthPoutLeft_Element = new();
public global::System.Single MouthPoutRight { get => MouthPoutRight_Element.Data; set => MouthPoutRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouthPoutRight_Element = new();
public global::System.Single LipTopLeftOverturn { get => LipTopLeftOverturn_Element.Data; set => LipTopLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipTopLeftOverturn_Element = new();
public global::System.Single LipTopRightOverturn { get => LipTopRightOverturn_Element.Data; set => LipTopRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipTopRightOverturn_Element = new();
public global::System.Single LipBottomLeftOverturn { get => LipBottomLeftOverturn_Element.Data; set => LipBottomLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipBottomLeftOverturn_Element = new();
public global::System.Single LipBottomRightOverturn { get => LipBottomRightOverturn_Element.Data; set => LipBottomRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipBottomRightOverturn_Element = new();
public global::System.Single LipTopLeftOverUnder { get => LipTopLeftOverUnder_Element.Data; set => LipTopLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipTopLeftOverUnder_Element = new();
public global::System.Single LipTopRightOverUnder { get => LipTopRightOverUnder_Element.Data; set => LipTopRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipTopRightOverUnder_Element = new();
public global::System.Single LipBottomLeftOverUnder { get => LipBottomLeftOverUnder_Element.Data; set => LipBottomLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipBottomLeftOverUnder_Element = new();
public global::System.Single LipBottomRightOverUnder { get => LipBottomRightOverUnder_Element.Data; set => LipBottomRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipBottomRightOverUnder_Element = new();
public global::System.Single LipLeftStretchTighten { get => LipLeftStretchTighten_Element.Data; set => LipLeftStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipLeftStretchTighten_Element = new();
public global::System.Single LipRightStretchTighten { get => LipRightStretchTighten_Element.Data; set => LipRightStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipRightStretchTighten_Element = new();
public global::System.Single LipsLeftPress { get => LipsLeftPress_Element.Data; set => LipsLeftPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipsLeftPress_Element = new();
public global::System.Single LipsRightPress { get => LipsRightPress_Element.Data; set => LipsRightPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LipsRightPress_Element = new();
public global::System.Single CheekLeftPuffSuck { get => CheekLeftPuffSuck_Element.Data; set => CheekLeftPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CheekLeftPuffSuck_Element = new();
public global::System.Single CheekRightPuffSuck { get => CheekRightPuffSuck_Element.Data; set => CheekRightPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CheekRightPuffSuck_Element = new();
public global::System.Single CheekLeftRaise { get => CheekLeftRaise_Element.Data; set => CheekLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CheekLeftRaise_Element = new();
public global::System.Single CheekRightRaise { get => CheekRightRaise_Element.Data; set => CheekRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CheekRightRaise_Element = new();
public global::System.Single NoseWrinkleLeft { get => NoseWrinkleLeft_Element.Data; set => NoseWrinkleLeft_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoseWrinkleLeft_Element = new();
public global::System.Single NoseWrinkleRight { get => NoseWrinkleRight_Element.Data; set => NoseWrinkleRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoseWrinkleRight_Element = new();
public global::System.Single ChinRaiseBottom { get => ChinRaiseBottom_Element.Data; set => ChinRaiseBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ChinRaiseBottom_Element = new();
public global::System.Single ChinRaiseTop { get => ChinRaiseTop_Element.Data; set => ChinRaiseTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ChinRaiseTop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Jaw", Jaw_Element.Data.ToResoniteLinkField());
members.Add("JawOpen", JawOpen_Element.Data.ToResoniteLinkField());
members.Add("Tongue", Tongue_Element.Data.ToResoniteLinkField());
members.Add("TongueRoll", TongueRoll_Element.Data.ToResoniteLinkField());
members.Add("LipUpperLeftRaise", LipUpperLeftRaise_Element.Data.ToResoniteLinkField());
members.Add("LipUpperRightRaise", LipUpperRightRaise_Element.Data.ToResoniteLinkField());
members.Add("LipLowerLeftRaise", LipLowerLeftRaise_Element.Data.ToResoniteLinkField());
members.Add("LipLowerRightRaise", LipLowerRightRaise_Element.Data.ToResoniteLinkField());
members.Add("LipUpperHorizontal", LipUpperHorizontal_Element.Data.ToResoniteLinkField());
members.Add("LipLowerHorizontal", LipLowerHorizontal_Element.Data.ToResoniteLinkField());
members.Add("MouthLeftSmileFrown", MouthLeftSmileFrown_Element.Data.ToResoniteLinkField());
members.Add("MouthRightSmileFrown", MouthRightSmileFrown_Element.Data.ToResoniteLinkField());
members.Add("MouthLeftDimple", MouthLeftDimple_Element.Data.ToResoniteLinkField());
members.Add("MouthRightDimple", MouthRightDimple_Element.Data.ToResoniteLinkField());
members.Add("MouthPoutLeft", MouthPoutLeft_Element.Data.ToResoniteLinkField());
members.Add("MouthPoutRight", MouthPoutRight_Element.Data.ToResoniteLinkField());
members.Add("LipTopLeftOverturn", LipTopLeftOverturn_Element.Data.ToResoniteLinkField());
members.Add("LipTopRightOverturn", LipTopRightOverturn_Element.Data.ToResoniteLinkField());
members.Add("LipBottomLeftOverturn", LipBottomLeftOverturn_Element.Data.ToResoniteLinkField());
members.Add("LipBottomRightOverturn", LipBottomRightOverturn_Element.Data.ToResoniteLinkField());
members.Add("LipTopLeftOverUnder", LipTopLeftOverUnder_Element.Data.ToResoniteLinkField());
members.Add("LipTopRightOverUnder", LipTopRightOverUnder_Element.Data.ToResoniteLinkField());
members.Add("LipBottomLeftOverUnder", LipBottomLeftOverUnder_Element.Data.ToResoniteLinkField());
members.Add("LipBottomRightOverUnder", LipBottomRightOverUnder_Element.Data.ToResoniteLinkField());
members.Add("LipLeftStretchTighten", LipLeftStretchTighten_Element.Data.ToResoniteLinkField());
members.Add("LipRightStretchTighten", LipRightStretchTighten_Element.Data.ToResoniteLinkField());
members.Add("LipsLeftPress", LipsLeftPress_Element.Data.ToResoniteLinkField());
members.Add("LipsRightPress", LipsRightPress_Element.Data.ToResoniteLinkField());
members.Add("CheekLeftPuffSuck", CheekLeftPuffSuck_Element.Data.ToResoniteLinkField());
members.Add("CheekRightPuffSuck", CheekRightPuffSuck_Element.Data.ToResoniteLinkField());
members.Add("CheekLeftRaise", CheekLeftRaise_Element.Data.ToResoniteLinkField());
members.Add("CheekRightRaise", CheekRightRaise_Element.Data.ToResoniteLinkField());
members.Add("NoseWrinkleLeft", NoseWrinkleLeft_Element.Data.ToResoniteLinkField());
members.Add("NoseWrinkleRight", NoseWrinkleRight_Element.Data.ToResoniteLinkField());
members.Add("ChinRaiseBottom", ChinRaiseBottom_Element.Data.ToResoniteLinkField());
members.Add("ChinRaiseTop", ChinRaiseTop_Element.Data.ToResoniteLinkField());
}

}
}
