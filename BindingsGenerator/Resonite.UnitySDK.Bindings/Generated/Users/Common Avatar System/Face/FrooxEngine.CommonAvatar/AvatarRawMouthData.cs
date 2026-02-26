
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawMouthData
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IMouthTrackingSourceComponent DataSource { get => DataSource_Element.Data; set => DataSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>, global::FrooxEngine.IMouthTrackingSourceComponent> DataSource_Element = new();
public global::System.Single StrengthMultiplier { get => StrengthMultiplier_Element.Data; set => StrengthMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrengthMultiplier_Element = new();
public UnityEngine.Vector3 Jaw { get => Jaw_Element.Data; set => Jaw_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> Jaw_Element = new();
public global::System.Single JawOpen { get => JawOpen_Element.Data; set => JawOpen_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> JawOpen_Element = new();
public UnityEngine.Vector3 Tongue { get => Tongue_Element.Data; set => Tongue_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> Tongue_Element = new();
public global::System.Single TongueRoll { get => TongueRoll_Element.Data; set => TongueRoll_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> TongueRoll_Element = new();
public global::System.Single LipUpperLeftRaise { get => LipUpperLeftRaise_Element.Data; set => LipUpperLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipUpperLeftRaise_Element = new();
public global::System.Single LipUpperRightRaise { get => LipUpperRightRaise_Element.Data; set => LipUpperRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipUpperRightRaise_Element = new();
public global::System.Single LipLowerLeftRaise { get => LipLowerLeftRaise_Element.Data; set => LipLowerLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipLowerLeftRaise_Element = new();
public global::System.Single LipLowerRightRaise { get => LipLowerRightRaise_Element.Data; set => LipLowerRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipLowerRightRaise_Element = new();
public global::System.Single LipUpperHorizontal { get => LipUpperHorizontal_Element.Data; set => LipUpperHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipUpperHorizontal_Element = new();
public global::System.Single LipLowerHorizontal { get => LipLowerHorizontal_Element.Data; set => LipLowerHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipLowerHorizontal_Element = new();
public global::System.Single MouthLeftSmileFrown { get => MouthLeftSmileFrown_Element.Data; set => MouthLeftSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthLeftSmileFrown_Element = new();
public global::System.Single MouthRightSmileFrown { get => MouthRightSmileFrown_Element.Data; set => MouthRightSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthRightSmileFrown_Element = new();
public global::System.Single MouthLeftDimple { get => MouthLeftDimple_Element.Data; set => MouthLeftDimple_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthLeftDimple_Element = new();
public global::System.Single MouthRightDimple { get => MouthRightDimple_Element.Data; set => MouthRightDimple_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthRightDimple_Element = new();
public global::System.Single MouthPout { get => MouthPout_Element.Data; set => MouthPout_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthPout_Element = new();
public global::System.Single MouthPoutLeft { get => MouthPoutLeft_Element.Data; set => MouthPoutLeft_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthPoutLeft_Element = new();
public global::System.Single MouthPoutRight { get => MouthPoutRight_Element.Data; set => MouthPoutRight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> MouthPoutRight_Element = new();
public global::System.Single LipTopOverturn { get => LipTopOverturn_Element.Data; set => LipTopOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopOverturn_Element = new();
public global::System.Single LipTopLeftOverturn { get => LipTopLeftOverturn_Element.Data; set => LipTopLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopLeftOverturn_Element = new();
public global::System.Single LipTopRightOverturn { get => LipTopRightOverturn_Element.Data; set => LipTopRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopRightOverturn_Element = new();
public global::System.Single LipBottomOverturn { get => LipBottomOverturn_Element.Data; set => LipBottomOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomOverturn_Element = new();
public global::System.Single LipBottomLeftOverturn { get => LipBottomLeftOverturn_Element.Data; set => LipBottomLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomLeftOverturn_Element = new();
public global::System.Single LipBottomRightOverturn { get => LipBottomRightOverturn_Element.Data; set => LipBottomRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomRightOverturn_Element = new();
public global::System.Single LipTopOverUnder { get => LipTopOverUnder_Element.Data; set => LipTopOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopOverUnder_Element = new();
public global::System.Single LipTopLeftOverUnder { get => LipTopLeftOverUnder_Element.Data; set => LipTopLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopLeftOverUnder_Element = new();
public global::System.Single LipTopRightOverUnder { get => LipTopRightOverUnder_Element.Data; set => LipTopRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipTopRightOverUnder_Element = new();
public global::System.Single LipBottomOverUnder { get => LipBottomOverUnder_Element.Data; set => LipBottomOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomOverUnder_Element = new();
public global::System.Single LipBottomLeftOverUnder { get => LipBottomLeftOverUnder_Element.Data; set => LipBottomLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomLeftOverUnder_Element = new();
public global::System.Single LipBottomRightOverUnder { get => LipBottomRightOverUnder_Element.Data; set => LipBottomRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipBottomRightOverUnder_Element = new();
public global::System.Single LipLeftStretchTighten { get => LipLeftStretchTighten_Element.Data; set => LipLeftStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipLeftStretchTighten_Element = new();
public global::System.Single LipRightStretchTighten { get => LipRightStretchTighten_Element.Data; set => LipRightStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipRightStretchTighten_Element = new();
public global::System.Single LipsLeftPress { get => LipsLeftPress_Element.Data; set => LipsLeftPress_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipsLeftPress_Element = new();
public global::System.Single LipsRightPress { get => LipsRightPress_Element.Data; set => LipsRightPress_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LipsRightPress_Element = new();
public global::System.Single CheekLeftPuffSuck { get => CheekLeftPuffSuck_Element.Data; set => CheekLeftPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CheekLeftPuffSuck_Element = new();
public global::System.Single CheekRightPuffSuck { get => CheekRightPuffSuck_Element.Data; set => CheekRightPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CheekRightPuffSuck_Element = new();
public global::System.Single CheekLeftRaise { get => CheekLeftRaise_Element.Data; set => CheekLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CheekLeftRaise_Element = new();
public global::System.Single CheekRightRaise { get => CheekRightRaise_Element.Data; set => CheekRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CheekRightRaise_Element = new();
public global::System.Single NoseWrinkleLeft { get => NoseWrinkleLeft_Element.Data; set => NoseWrinkleLeft_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> NoseWrinkleLeft_Element = new();
public global::System.Single NoseWrinkleRight { get => NoseWrinkleRight_Element.Data; set => NoseWrinkleRight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> NoseWrinkleRight_Element = new();
public global::System.Single ChinRaiseBottom { get => ChinRaiseBottom_Element.Data; set => ChinRaiseBottom_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ChinRaiseBottom_Element = new();
public global::System.Single ChinRaiseTop { get => ChinRaiseTop_Element.Data; set => ChinRaiseTop_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ChinRaiseTop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DataSource", DataSource_Element.ToLinkReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier_Element.ToLinkField(context));
members.Add("Jaw", Jaw_Element.ToLinkField(context));
members.Add("JawOpen", JawOpen_Element.ToLinkField(context));
members.Add("Tongue", Tongue_Element.ToLinkField(context));
members.Add("TongueRoll", TongueRoll_Element.ToLinkField(context));
members.Add("LipUpperLeftRaise", LipUpperLeftRaise_Element.ToLinkField(context));
members.Add("LipUpperRightRaise", LipUpperRightRaise_Element.ToLinkField(context));
members.Add("LipLowerLeftRaise", LipLowerLeftRaise_Element.ToLinkField(context));
members.Add("LipLowerRightRaise", LipLowerRightRaise_Element.ToLinkField(context));
members.Add("LipUpperHorizontal", LipUpperHorizontal_Element.ToLinkField(context));
members.Add("LipLowerHorizontal", LipLowerHorizontal_Element.ToLinkField(context));
members.Add("MouthLeftSmileFrown", MouthLeftSmileFrown_Element.ToLinkField(context));
members.Add("MouthRightSmileFrown", MouthRightSmileFrown_Element.ToLinkField(context));
members.Add("MouthLeftDimple", MouthLeftDimple_Element.ToLinkField(context));
members.Add("MouthRightDimple", MouthRightDimple_Element.ToLinkField(context));
members.Add("MouthPout", MouthPout_Element.ToLinkField(context));
members.Add("MouthPoutLeft", MouthPoutLeft_Element.ToLinkField(context));
members.Add("MouthPoutRight", MouthPoutRight_Element.ToLinkField(context));
members.Add("LipTopOverturn", LipTopOverturn_Element.ToLinkField(context));
members.Add("LipTopLeftOverturn", LipTopLeftOverturn_Element.ToLinkField(context));
members.Add("LipTopRightOverturn", LipTopRightOverturn_Element.ToLinkField(context));
members.Add("LipBottomOverturn", LipBottomOverturn_Element.ToLinkField(context));
members.Add("LipBottomLeftOverturn", LipBottomLeftOverturn_Element.ToLinkField(context));
members.Add("LipBottomRightOverturn", LipBottomRightOverturn_Element.ToLinkField(context));
members.Add("LipTopOverUnder", LipTopOverUnder_Element.ToLinkField(context));
members.Add("LipTopLeftOverUnder", LipTopLeftOverUnder_Element.ToLinkField(context));
members.Add("LipTopRightOverUnder", LipTopRightOverUnder_Element.ToLinkField(context));
members.Add("LipBottomOverUnder", LipBottomOverUnder_Element.ToLinkField(context));
members.Add("LipBottomLeftOverUnder", LipBottomLeftOverUnder_Element.ToLinkField(context));
members.Add("LipBottomRightOverUnder", LipBottomRightOverUnder_Element.ToLinkField(context));
members.Add("LipLeftStretchTighten", LipLeftStretchTighten_Element.ToLinkField(context));
members.Add("LipRightStretchTighten", LipRightStretchTighten_Element.ToLinkField(context));
members.Add("LipsLeftPress", LipsLeftPress_Element.ToLinkField(context));
members.Add("LipsRightPress", LipsRightPress_Element.ToLinkField(context));
members.Add("CheekLeftPuffSuck", CheekLeftPuffSuck_Element.ToLinkField(context));
members.Add("CheekRightPuffSuck", CheekRightPuffSuck_Element.ToLinkField(context));
members.Add("CheekLeftRaise", CheekLeftRaise_Element.ToLinkField(context));
members.Add("CheekRightRaise", CheekRightRaise_Element.ToLinkField(context));
members.Add("NoseWrinkleLeft", NoseWrinkleLeft_Element.ToLinkField(context));
members.Add("NoseWrinkleRight", NoseWrinkleRight_Element.ToLinkField(context));
members.Add("ChinRaiseBottom", ChinRaiseBottom_Element.ToLinkField(context));
members.Add("ChinRaiseTop", ChinRaiseTop_Element.ToLinkField(context));
}

}
}
