
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MouthTrackingStreamManager
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MouthTrackingStreamManager")]
public partial class MouthTrackingStreamManager : global::FrooxEngine.Component, global::FrooxEngine.IMouthTrackingSourceComponent

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> IsTracking_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Jaw { get => Jaw_Element.Data; set => Jaw_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> Jaw_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> JawOpen { get => JawOpen_Element.Data; set => JawOpen_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> JawOpen_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Tongue { get => Tongue_Element.Data; set => Tongue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> Tongue_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> TongueRoll { get => TongueRoll_Element.Data; set => TongueRoll_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> TongueRoll_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperLeftRaise { get => LipUpperLeftRaise_Element.Data; set => LipUpperLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipUpperLeftRaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperRightRaise { get => LipUpperRightRaise_Element.Data; set => LipUpperRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipUpperRightRaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerLeftaise { get => LipLowerLeftaise_Element.Data; set => LipLowerLeftaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipLowerLeftaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerRightRaise { get => LipLowerRightRaise_Element.Data; set => LipLowerRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipLowerRightRaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipUpperHorizontal { get => LipUpperHorizontal_Element.Data; set => LipUpperHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipUpperHorizontal_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipLowerHorizontal { get => LipLowerHorizontal_Element.Data; set => LipLowerHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipLowerHorizontal_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthLeftSmileFrown { get => MouthLeftSmileFrown_Element.Data; set => MouthLeftSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthLeftSmileFrown_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthRightSmileFrown { get => MouthRightSmileFrown_Element.Data; set => MouthRightSmileFrown_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthRightSmileFrown_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthLeftDimple { get => MouthLeftDimple_Element.Data; set => MouthLeftDimple_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthLeftDimple_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthRightDimple { get => MouthRightDimple_Element.Data; set => MouthRightDimple_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthRightDimple_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthPoutLeft { get => MouthPoutLeft_Element.Data; set => MouthPoutLeft_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthPoutLeft_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> MouthPoutRight { get => MouthPoutRight_Element.Data; set => MouthPoutRight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> MouthPoutRight_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipTopLeftOverturn { get => LipTopLeftOverturn_Element.Data; set => LipTopLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipTopLeftOverturn_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipTopRightOverturn { get => LipTopRightOverturn_Element.Data; set => LipTopRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipTopRightOverturn_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomLeftOverturn { get => LipBottomLeftOverturn_Element.Data; set => LipBottomLeftOverturn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipBottomLeftOverturn_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomRightOverturn { get => LipBottomRightOverturn_Element.Data; set => LipBottomRightOverturn_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipBottomRightOverturn_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipTopLeftOverUnder { get => LipTopLeftOverUnder_Element.Data; set => LipTopLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipTopLeftOverUnder_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipTopRightOverUnder { get => LipTopRightOverUnder_Element.Data; set => LipTopRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipTopRightOverUnder_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomLeftOverUnder { get => LipBottomLeftOverUnder_Element.Data; set => LipBottomLeftOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipBottomLeftOverUnder_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipBottomRightOverUnder { get => LipBottomRightOverUnder_Element.Data; set => LipBottomRightOverUnder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipBottomRightOverUnder_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipLeftStretchTighten { get => LipLeftStretchTighten_Element.Data; set => LipLeftStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipLeftStretchTighten_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipRightStretchTighten { get => LipRightStretchTighten_Element.Data; set => LipRightStretchTighten_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipRightStretchTighten_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipsLeftPress { get => LipsLeftPress_Element.Data; set => LipsLeftPress_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipsLeftPress_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> LipsRightPress { get => LipsRightPress_Element.Data; set => LipsRightPress_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> LipsRightPress_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> CheekLeftPuffSuck { get => CheekLeftPuffSuck_Element.Data; set => CheekLeftPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> CheekLeftPuffSuck_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> CheekRightPuffSuck { get => CheekRightPuffSuck_Element.Data; set => CheekRightPuffSuck_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> CheekRightPuffSuck_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> CheekLeftRaise { get => CheekLeftRaise_Element.Data; set => CheekLeftRaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> CheekLeftRaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> CheekRightRaise { get => CheekRightRaise_Element.Data; set => CheekRightRaise_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> CheekRightRaise_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> NoseWrinkleLeft { get => NoseWrinkleLeft_Element.Data; set => NoseWrinkleLeft_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> NoseWrinkleLeft_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> NoseWrinkleRight { get => NoseWrinkleRight_Element.Data; set => NoseWrinkleRight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> NoseWrinkleRight_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> ChinRaiseBottom { get => ChinRaiseBottom_Element.Data; set => ChinRaiseBottom_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> ChinRaiseBottom_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> ChinRaiseTop { get => ChinRaiseTop_Element.Data; set => ChinRaiseTop_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> ChinRaiseTop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("IsTracking", IsTracking_Element.ToLinkReference(context));
members.Add("Jaw", Jaw_Element.ToLinkReference(context));
members.Add("JawOpen", JawOpen_Element.ToLinkReference(context));
members.Add("Tongue", Tongue_Element.ToLinkReference(context));
members.Add("TongueRoll", TongueRoll_Element.ToLinkReference(context));
members.Add("LipUpperLeftRaise", LipUpperLeftRaise_Element.ToLinkReference(context));
members.Add("LipUpperRightRaise", LipUpperRightRaise_Element.ToLinkReference(context));
members.Add("LipLowerLeftaise", LipLowerLeftaise_Element.ToLinkReference(context));
members.Add("LipLowerRightRaise", LipLowerRightRaise_Element.ToLinkReference(context));
members.Add("LipUpperHorizontal", LipUpperHorizontal_Element.ToLinkReference(context));
members.Add("LipLowerHorizontal", LipLowerHorizontal_Element.ToLinkReference(context));
members.Add("MouthLeftSmileFrown", MouthLeftSmileFrown_Element.ToLinkReference(context));
members.Add("MouthRightSmileFrown", MouthRightSmileFrown_Element.ToLinkReference(context));
members.Add("MouthLeftDimple", MouthLeftDimple_Element.ToLinkReference(context));
members.Add("MouthRightDimple", MouthRightDimple_Element.ToLinkReference(context));
members.Add("MouthPoutLeft", MouthPoutLeft_Element.ToLinkReference(context));
members.Add("MouthPoutRight", MouthPoutRight_Element.ToLinkReference(context));
members.Add("LipTopLeftOverturn", LipTopLeftOverturn_Element.ToLinkReference(context));
members.Add("LipTopRightOverturn", LipTopRightOverturn_Element.ToLinkReference(context));
members.Add("LipBottomLeftOverturn", LipBottomLeftOverturn_Element.ToLinkReference(context));
members.Add("LipBottomRightOverturn", LipBottomRightOverturn_Element.ToLinkReference(context));
members.Add("LipTopLeftOverUnder", LipTopLeftOverUnder_Element.ToLinkReference(context));
members.Add("LipTopRightOverUnder", LipTopRightOverUnder_Element.ToLinkReference(context));
members.Add("LipBottomLeftOverUnder", LipBottomLeftOverUnder_Element.ToLinkReference(context));
members.Add("LipBottomRightOverUnder", LipBottomRightOverUnder_Element.ToLinkReference(context));
members.Add("LipLeftStretchTighten", LipLeftStretchTighten_Element.ToLinkReference(context));
members.Add("LipRightStretchTighten", LipRightStretchTighten_Element.ToLinkReference(context));
members.Add("LipsLeftPress", LipsLeftPress_Element.ToLinkReference(context));
members.Add("LipsRightPress", LipsRightPress_Element.ToLinkReference(context));
members.Add("CheekLeftPuffSuck", CheekLeftPuffSuck_Element.ToLinkReference(context));
members.Add("CheekRightPuffSuck", CheekRightPuffSuck_Element.ToLinkReference(context));
members.Add("CheekLeftRaise", CheekLeftRaise_Element.ToLinkReference(context));
members.Add("CheekRightRaise", CheekRightRaise_Element.ToLinkReference(context));
members.Add("NoseWrinkleLeft", NoseWrinkleLeft_Element.ToLinkReference(context));
members.Add("NoseWrinkleRight", NoseWrinkleRight_Element.ToLinkReference(context));
members.Add("ChinRaiseBottom", ChinRaiseBottom_Element.ToLinkReference(context));
members.Add("ChinRaiseTop", ChinRaiseTop_Element.ToLinkReference(context));
}

}
}
