
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeLinearDriver+Eye
// Generated on: středa 25. února 2026 16:14:46
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.EyeSide Side;
public global::FrooxEngine.Slot ProjectionPlanePoint;
public global::FrooxEngine.IField<UnityEngine.Vector2> PositionOffset;
public global::FrooxEngine.IField<global::System.Single> LookLeft;
public global::FrooxEngine.IField<global::System.Single> LookUp;
public global::FrooxEngine.IField<global::System.Single> LookRight;
public global::FrooxEngine.IField<global::System.Single> LookDown;
public global::FrooxEngine.IField<global::System.Single> OpenCloseTarget;
public global::FrooxEngine.IField<global::System.Single> PupilSizeTarget;
public global::FrooxEngine.IField<global::System.Single> WidenTarget;
public global::FrooxEngine.IField<global::System.Single> SqueezeTarget;
public global::FrooxEngine.IField<global::System.Single> FrownTarget;
public global::FrooxEngine.IField<global::System.Single> InnerBrowRaiseTarget;
public global::FrooxEngine.IField<global::System.Single> InnerBrowLowerTarget;
public global::FrooxEngine.IField<global::System.Single> OuterBrowRaiseTarget;
public global::FrooxEngine.IField<global::System.Single> OuterBrowLowerTarget;
public global::System.Single MinInputCloseness;
public global::System.Single MaxInputCloseness;
public global::System.Single OpenState;
public global::System.Single ClosedState;
public global::System.Single MinInputPupilSize;
public global::System.Single MaxInputPupilSize;
public global::System.Single MinOutputPupilSize;
public global::System.Single MaxOutputPupilSize;
public global::System.Single MinInputWiden;
public global::System.Single MaxInputWiden;
public global::System.Single MinOutputWiden;
public global::System.Single MaxOutputWiden;
public global::System.Single MinInputSqueeze;
public global::System.Single MaxInputSqueeze;
public global::System.Single MinOutputSqueeze;
public global::System.Single MaxOutputSqueeze;
public global::System.Single MinInputFrown;
public global::System.Single MaxInputFrown;
public global::System.Single MinOutputFrown;
public global::System.Single MaxOutputFrown;
public global::System.Single MinInputInnerBrowRaise;
public global::System.Single MaxInputInnerBrowRaise;
public global::System.Single MinOutputInnerBrowRaise;
public global::System.Single MaxOutputInnerBrowRaise;
public global::System.Single MinInputInnerBrowLower;
public global::System.Single MaxInputInnerBrowLower;
public global::System.Single MinOutputInnerBrowLower;
public global::System.Single MaxOutputInnerBrowLower;
public global::System.Single MinInputOuterBrowRaise;
public global::System.Single MaxInputOuterBrowRaise;
public global::System.Single MinOutputOuterBrowRaise;
public global::System.Single MaxOutputOuterBrowRaise;
public global::System.Single MinInputOuterBrowLower;
public global::System.Single MaxInputOuterBrowLower;
public global::System.Single MinOutputOuterBrowLower;
public global::System.Single MaxOutputOuterBrowLower;
public global::System.Single LookMultiply;
public global::System.Single LookPower;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("ProjectionPlanePoint", ProjectionPlanePoint.ToResoniteReference(context));
members.Add("PositionOffset", PositionOffset.ToResoniteReference(context));
members.Add("LookLeft", LookLeft.ToResoniteReference(context));
members.Add("LookUp", LookUp.ToResoniteReference(context));
members.Add("LookRight", LookRight.ToResoniteReference(context));
members.Add("LookDown", LookDown.ToResoniteReference(context));
members.Add("OpenCloseTarget", OpenCloseTarget.ToResoniteReference(context));
members.Add("PupilSizeTarget", PupilSizeTarget.ToResoniteReference(context));
members.Add("WidenTarget", WidenTarget.ToResoniteReference(context));
members.Add("SqueezeTarget", SqueezeTarget.ToResoniteReference(context));
members.Add("FrownTarget", FrownTarget.ToResoniteReference(context));
members.Add("InnerBrowRaiseTarget", InnerBrowRaiseTarget.ToResoniteReference(context));
members.Add("InnerBrowLowerTarget", InnerBrowLowerTarget.ToResoniteReference(context));
members.Add("OuterBrowRaiseTarget", OuterBrowRaiseTarget.ToResoniteReference(context));
members.Add("OuterBrowLowerTarget", OuterBrowLowerTarget.ToResoniteReference(context));
members.Add("MinInputCloseness", MinInputCloseness.ToResoniteLinkField());
members.Add("MaxInputCloseness", MaxInputCloseness.ToResoniteLinkField());
members.Add("OpenState", OpenState.ToResoniteLinkField());
members.Add("ClosedState", ClosedState.ToResoniteLinkField());
members.Add("MinInputPupilSize", MinInputPupilSize.ToResoniteLinkField());
members.Add("MaxInputPupilSize", MaxInputPupilSize.ToResoniteLinkField());
members.Add("MinOutputPupilSize", MinOutputPupilSize.ToResoniteLinkField());
members.Add("MaxOutputPupilSize", MaxOutputPupilSize.ToResoniteLinkField());
members.Add("MinInputWiden", MinInputWiden.ToResoniteLinkField());
members.Add("MaxInputWiden", MaxInputWiden.ToResoniteLinkField());
members.Add("MinOutputWiden", MinOutputWiden.ToResoniteLinkField());
members.Add("MaxOutputWiden", MaxOutputWiden.ToResoniteLinkField());
members.Add("MinInputSqueeze", MinInputSqueeze.ToResoniteLinkField());
members.Add("MaxInputSqueeze", MaxInputSqueeze.ToResoniteLinkField());
members.Add("MinOutputSqueeze", MinOutputSqueeze.ToResoniteLinkField());
members.Add("MaxOutputSqueeze", MaxOutputSqueeze.ToResoniteLinkField());
members.Add("MinInputFrown", MinInputFrown.ToResoniteLinkField());
members.Add("MaxInputFrown", MaxInputFrown.ToResoniteLinkField());
members.Add("MinOutputFrown", MinOutputFrown.ToResoniteLinkField());
members.Add("MaxOutputFrown", MaxOutputFrown.ToResoniteLinkField());
members.Add("MinInputInnerBrowRaise", MinInputInnerBrowRaise.ToResoniteLinkField());
members.Add("MaxInputInnerBrowRaise", MaxInputInnerBrowRaise.ToResoniteLinkField());
members.Add("MinOutputInnerBrowRaise", MinOutputInnerBrowRaise.ToResoniteLinkField());
members.Add("MaxOutputInnerBrowRaise", MaxOutputInnerBrowRaise.ToResoniteLinkField());
members.Add("MinInputInnerBrowLower", MinInputInnerBrowLower.ToResoniteLinkField());
members.Add("MaxInputInnerBrowLower", MaxInputInnerBrowLower.ToResoniteLinkField());
members.Add("MinOutputInnerBrowLower", MinOutputInnerBrowLower.ToResoniteLinkField());
members.Add("MaxOutputInnerBrowLower", MaxOutputInnerBrowLower.ToResoniteLinkField());
members.Add("MinInputOuterBrowRaise", MinInputOuterBrowRaise.ToResoniteLinkField());
members.Add("MaxInputOuterBrowRaise", MaxInputOuterBrowRaise.ToResoniteLinkField());
members.Add("MinOutputOuterBrowRaise", MinOutputOuterBrowRaise.ToResoniteLinkField());
members.Add("MaxOutputOuterBrowRaise", MaxOutputOuterBrowRaise.ToResoniteLinkField());
members.Add("MinInputOuterBrowLower", MinInputOuterBrowLower.ToResoniteLinkField());
members.Add("MaxInputOuterBrowLower", MaxInputOuterBrowLower.ToResoniteLinkField());
members.Add("MinOutputOuterBrowLower", MinOutputOuterBrowLower.ToResoniteLinkField());
members.Add("MaxOutputOuterBrowLower", MaxOutputOuterBrowLower.ToResoniteLinkField());
members.Add("LookMultiply", LookMultiply.ToResoniteLinkField());
members.Add("LookPower", LookPower.ToResoniteLinkField());
}

}
            }
}
