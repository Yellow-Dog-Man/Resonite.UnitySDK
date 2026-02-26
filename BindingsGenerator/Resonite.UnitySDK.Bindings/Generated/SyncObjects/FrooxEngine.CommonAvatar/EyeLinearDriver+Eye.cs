
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver+Eye
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class EyeLinearDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver+Eye")]
public partial class Eye : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.EyeSide Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.EyeSide>, global::FrooxEngine.EyeSide> Side_Element = new();
public global::FrooxEngine.Slot ProjectionPlanePoint { get => ProjectionPlanePoint_Element.Data; set => ProjectionPlanePoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ProjectionPlanePoint_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> PositionOffset { get => PositionOffset_Element.Data; set => PositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> PositionOffset_Element = new();
public global::FrooxEngine.IField<global::System.Single> LookLeft { get => LookLeft_Element.Data; set => LookLeft_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> LookLeft_Element = new();
public global::FrooxEngine.IField<global::System.Single> LookUp { get => LookUp_Element.Data; set => LookUp_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> LookUp_Element = new();
public global::FrooxEngine.IField<global::System.Single> LookRight { get => LookRight_Element.Data; set => LookRight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> LookRight_Element = new();
public global::FrooxEngine.IField<global::System.Single> LookDown { get => LookDown_Element.Data; set => LookDown_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> LookDown_Element = new();
public global::FrooxEngine.IField<global::System.Single> OpenCloseTarget { get => OpenCloseTarget_Element.Data; set => OpenCloseTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> OpenCloseTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> PupilSizeTarget { get => PupilSizeTarget_Element.Data; set => PupilSizeTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> PupilSizeTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> WidenTarget { get => WidenTarget_Element.Data; set => WidenTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> WidenTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> SqueezeTarget { get => SqueezeTarget_Element.Data; set => SqueezeTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> SqueezeTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> FrownTarget { get => FrownTarget_Element.Data; set => FrownTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> FrownTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> InnerBrowRaiseTarget { get => InnerBrowRaiseTarget_Element.Data; set => InnerBrowRaiseTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> InnerBrowRaiseTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> InnerBrowLowerTarget { get => InnerBrowLowerTarget_Element.Data; set => InnerBrowLowerTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> InnerBrowLowerTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> OuterBrowRaiseTarget { get => OuterBrowRaiseTarget_Element.Data; set => OuterBrowRaiseTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> OuterBrowRaiseTarget_Element = new();
public global::FrooxEngine.IField<global::System.Single> OuterBrowLowerTarget { get => OuterBrowLowerTarget_Element.Data; set => OuterBrowLowerTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> OuterBrowLowerTarget_Element = new();
public global::System.Single MinInputCloseness { get => MinInputCloseness_Element.Data; set => MinInputCloseness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputCloseness_Element = new();
public global::System.Single MaxInputCloseness { get => MaxInputCloseness_Element.Data; set => MaxInputCloseness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputCloseness_Element = new();
public global::System.Single OpenState { get => OpenState_Element.Data; set => OpenState_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OpenState_Element = new();
public global::System.Single ClosedState { get => ClosedState_Element.Data; set => ClosedState_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClosedState_Element = new();
public global::System.Single MinInputPupilSize { get => MinInputPupilSize_Element.Data; set => MinInputPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputPupilSize_Element = new();
public global::System.Single MaxInputPupilSize { get => MaxInputPupilSize_Element.Data; set => MaxInputPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputPupilSize_Element = new();
public global::System.Single MinOutputPupilSize { get => MinOutputPupilSize_Element.Data; set => MinOutputPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputPupilSize_Element = new();
public global::System.Single MaxOutputPupilSize { get => MaxOutputPupilSize_Element.Data; set => MaxOutputPupilSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputPupilSize_Element = new();
public global::System.Single MinInputWiden { get => MinInputWiden_Element.Data; set => MinInputWiden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputWiden_Element = new();
public global::System.Single MaxInputWiden { get => MaxInputWiden_Element.Data; set => MaxInputWiden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputWiden_Element = new();
public global::System.Single MinOutputWiden { get => MinOutputWiden_Element.Data; set => MinOutputWiden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputWiden_Element = new();
public global::System.Single MaxOutputWiden { get => MaxOutputWiden_Element.Data; set => MaxOutputWiden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputWiden_Element = new();
public global::System.Single MinInputSqueeze { get => MinInputSqueeze_Element.Data; set => MinInputSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputSqueeze_Element = new();
public global::System.Single MaxInputSqueeze { get => MaxInputSqueeze_Element.Data; set => MaxInputSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputSqueeze_Element = new();
public global::System.Single MinOutputSqueeze { get => MinOutputSqueeze_Element.Data; set => MinOutputSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputSqueeze_Element = new();
public global::System.Single MaxOutputSqueeze { get => MaxOutputSqueeze_Element.Data; set => MaxOutputSqueeze_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputSqueeze_Element = new();
public global::System.Single MinInputFrown { get => MinInputFrown_Element.Data; set => MinInputFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputFrown_Element = new();
public global::System.Single MaxInputFrown { get => MaxInputFrown_Element.Data; set => MaxInputFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputFrown_Element = new();
public global::System.Single MinOutputFrown { get => MinOutputFrown_Element.Data; set => MinOutputFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputFrown_Element = new();
public global::System.Single MaxOutputFrown { get => MaxOutputFrown_Element.Data; set => MaxOutputFrown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputFrown_Element = new();
public global::System.Single MinInputInnerBrowRaise { get => MinInputInnerBrowRaise_Element.Data; set => MinInputInnerBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputInnerBrowRaise_Element = new();
public global::System.Single MaxInputInnerBrowRaise { get => MaxInputInnerBrowRaise_Element.Data; set => MaxInputInnerBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputInnerBrowRaise_Element = new();
public global::System.Single MinOutputInnerBrowRaise { get => MinOutputInnerBrowRaise_Element.Data; set => MinOutputInnerBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputInnerBrowRaise_Element = new();
public global::System.Single MaxOutputInnerBrowRaise { get => MaxOutputInnerBrowRaise_Element.Data; set => MaxOutputInnerBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputInnerBrowRaise_Element = new();
public global::System.Single MinInputInnerBrowLower { get => MinInputInnerBrowLower_Element.Data; set => MinInputInnerBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputInnerBrowLower_Element = new();
public global::System.Single MaxInputInnerBrowLower { get => MaxInputInnerBrowLower_Element.Data; set => MaxInputInnerBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputInnerBrowLower_Element = new();
public global::System.Single MinOutputInnerBrowLower { get => MinOutputInnerBrowLower_Element.Data; set => MinOutputInnerBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputInnerBrowLower_Element = new();
public global::System.Single MaxOutputInnerBrowLower { get => MaxOutputInnerBrowLower_Element.Data; set => MaxOutputInnerBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputInnerBrowLower_Element = new();
public global::System.Single MinInputOuterBrowRaise { get => MinInputOuterBrowRaise_Element.Data; set => MinInputOuterBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputOuterBrowRaise_Element = new();
public global::System.Single MaxInputOuterBrowRaise { get => MaxInputOuterBrowRaise_Element.Data; set => MaxInputOuterBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputOuterBrowRaise_Element = new();
public global::System.Single MinOutputOuterBrowRaise { get => MinOutputOuterBrowRaise_Element.Data; set => MinOutputOuterBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputOuterBrowRaise_Element = new();
public global::System.Single MaxOutputOuterBrowRaise { get => MaxOutputOuterBrowRaise_Element.Data; set => MaxOutputOuterBrowRaise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputOuterBrowRaise_Element = new();
public global::System.Single MinInputOuterBrowLower { get => MinInputOuterBrowLower_Element.Data; set => MinInputOuterBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInputOuterBrowLower_Element = new();
public global::System.Single MaxInputOuterBrowLower { get => MaxInputOuterBrowLower_Element.Data; set => MaxInputOuterBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInputOuterBrowLower_Element = new();
public global::System.Single MinOutputOuterBrowLower { get => MinOutputOuterBrowLower_Element.Data; set => MinOutputOuterBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOutputOuterBrowLower_Element = new();
public global::System.Single MaxOutputOuterBrowLower { get => MaxOutputOuterBrowLower_Element.Data; set => MaxOutputOuterBrowLower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOutputOuterBrowLower_Element = new();
public global::System.Single LookMultiply { get => LookMultiply_Element.Data; set => LookMultiply_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LookMultiply_Element = new();
public global::System.Single LookPower { get => LookPower_Element.Data; set => LookPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LookPower_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side_Element.ToLinkField(context));
members.Add("ProjectionPlanePoint", ProjectionPlanePoint_Element.ToLinkReference(context));
members.Add("PositionOffset", PositionOffset_Element.ToLinkReference(context));
members.Add("LookLeft", LookLeft_Element.ToLinkReference(context));
members.Add("LookUp", LookUp_Element.ToLinkReference(context));
members.Add("LookRight", LookRight_Element.ToLinkReference(context));
members.Add("LookDown", LookDown_Element.ToLinkReference(context));
members.Add("OpenCloseTarget", OpenCloseTarget_Element.ToLinkReference(context));
members.Add("PupilSizeTarget", PupilSizeTarget_Element.ToLinkReference(context));
members.Add("WidenTarget", WidenTarget_Element.ToLinkReference(context));
members.Add("SqueezeTarget", SqueezeTarget_Element.ToLinkReference(context));
members.Add("FrownTarget", FrownTarget_Element.ToLinkReference(context));
members.Add("InnerBrowRaiseTarget", InnerBrowRaiseTarget_Element.ToLinkReference(context));
members.Add("InnerBrowLowerTarget", InnerBrowLowerTarget_Element.ToLinkReference(context));
members.Add("OuterBrowRaiseTarget", OuterBrowRaiseTarget_Element.ToLinkReference(context));
members.Add("OuterBrowLowerTarget", OuterBrowLowerTarget_Element.ToLinkReference(context));
members.Add("MinInputCloseness", MinInputCloseness_Element.ToLinkField(context));
members.Add("MaxInputCloseness", MaxInputCloseness_Element.ToLinkField(context));
members.Add("OpenState", OpenState_Element.ToLinkField(context));
members.Add("ClosedState", ClosedState_Element.ToLinkField(context));
members.Add("MinInputPupilSize", MinInputPupilSize_Element.ToLinkField(context));
members.Add("MaxInputPupilSize", MaxInputPupilSize_Element.ToLinkField(context));
members.Add("MinOutputPupilSize", MinOutputPupilSize_Element.ToLinkField(context));
members.Add("MaxOutputPupilSize", MaxOutputPupilSize_Element.ToLinkField(context));
members.Add("MinInputWiden", MinInputWiden_Element.ToLinkField(context));
members.Add("MaxInputWiden", MaxInputWiden_Element.ToLinkField(context));
members.Add("MinOutputWiden", MinOutputWiden_Element.ToLinkField(context));
members.Add("MaxOutputWiden", MaxOutputWiden_Element.ToLinkField(context));
members.Add("MinInputSqueeze", MinInputSqueeze_Element.ToLinkField(context));
members.Add("MaxInputSqueeze", MaxInputSqueeze_Element.ToLinkField(context));
members.Add("MinOutputSqueeze", MinOutputSqueeze_Element.ToLinkField(context));
members.Add("MaxOutputSqueeze", MaxOutputSqueeze_Element.ToLinkField(context));
members.Add("MinInputFrown", MinInputFrown_Element.ToLinkField(context));
members.Add("MaxInputFrown", MaxInputFrown_Element.ToLinkField(context));
members.Add("MinOutputFrown", MinOutputFrown_Element.ToLinkField(context));
members.Add("MaxOutputFrown", MaxOutputFrown_Element.ToLinkField(context));
members.Add("MinInputInnerBrowRaise", MinInputInnerBrowRaise_Element.ToLinkField(context));
members.Add("MaxInputInnerBrowRaise", MaxInputInnerBrowRaise_Element.ToLinkField(context));
members.Add("MinOutputInnerBrowRaise", MinOutputInnerBrowRaise_Element.ToLinkField(context));
members.Add("MaxOutputInnerBrowRaise", MaxOutputInnerBrowRaise_Element.ToLinkField(context));
members.Add("MinInputInnerBrowLower", MinInputInnerBrowLower_Element.ToLinkField(context));
members.Add("MaxInputInnerBrowLower", MaxInputInnerBrowLower_Element.ToLinkField(context));
members.Add("MinOutputInnerBrowLower", MinOutputInnerBrowLower_Element.ToLinkField(context));
members.Add("MaxOutputInnerBrowLower", MaxOutputInnerBrowLower_Element.ToLinkField(context));
members.Add("MinInputOuterBrowRaise", MinInputOuterBrowRaise_Element.ToLinkField(context));
members.Add("MaxInputOuterBrowRaise", MaxInputOuterBrowRaise_Element.ToLinkField(context));
members.Add("MinOutputOuterBrowRaise", MinOutputOuterBrowRaise_Element.ToLinkField(context));
members.Add("MaxOutputOuterBrowRaise", MaxOutputOuterBrowRaise_Element.ToLinkField(context));
members.Add("MinInputOuterBrowLower", MinInputOuterBrowLower_Element.ToLinkField(context));
members.Add("MaxInputOuterBrowLower", MaxInputOuterBrowLower_Element.ToLinkField(context));
members.Add("MinOutputOuterBrowLower", MinOutputOuterBrowLower_Element.ToLinkField(context));
members.Add("MaxOutputOuterBrowLower", MaxOutputOuterBrowLower_Element.ToLinkField(context));
members.Add("LookMultiply", LookMultiply_Element.ToLinkField(context));
members.Add("LookPower", LookPower_Element.ToLinkField(context));
}

}
            }
}
