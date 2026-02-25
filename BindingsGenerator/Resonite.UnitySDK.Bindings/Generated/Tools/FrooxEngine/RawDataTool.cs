
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RawDataTool
// Generated on: středa 25. února 2026 16:14:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RawDataTool")]
public partial class RawDataTool : global::FrooxEngine.Tool

{
    public UnityEngine.Vector3 LocalTipOffset;
public global::FrooxEngine.Slot LocalTipReference;
public global::System.Boolean UseLaser;
public global::System.Boolean BlockPrimaryWhenTouching;
public global::System.Boolean UseSecondary;
public global::System.Boolean AllowUseWhenHolding;
public global::System.Boolean Equipped;
public System.String ControllerType;
public global::Renderite.Shared.Chirality ControllerSide;
public global::System.Single PrimaryStrength;
public UnityEngine.Vector2 SecondaryAxis;
public global::System.Boolean Primary;
public global::System.Boolean Secondary;
public global::FrooxEngine.ValueStream<global::System.Single> _primaryStrengthStream;
public global::FrooxEngine.ValueStream<UnityEngine.Vector2> _secondaryAxisStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> _primaryStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> _secondaryStream;
public global::System.Single _rawStrength;
public UnityEngine.Vector2 _rawAxis;
public global::System.Boolean _rawPrimary;
public global::System.Boolean _rawSecondary;
public global::System.String PrimaryActionDescription;
public global::System.String SecondaryActionDescription;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalTipOffset", LocalTipOffset.ToResoniteLinkField());
members.Add("LocalTipReference", LocalTipReference.ToResoniteReference(context));
members.Add("UseLaser", UseLaser.ToResoniteLinkField());
members.Add("BlockPrimaryWhenTouching", BlockPrimaryWhenTouching.ToResoniteLinkField());
members.Add("UseSecondary", UseSecondary.ToResoniteLinkField());
members.Add("AllowUseWhenHolding", AllowUseWhenHolding.ToResoniteLinkField());
members.Add("Equipped", Equipped.ToResoniteLinkField());
members.Add("ControllerType", ControllerType.ToResoniteLinkField());
members.Add("ControllerSide", ControllerSide.ToResoniteLinkField());
members.Add("PrimaryStrength", PrimaryStrength.ToResoniteLinkField());
members.Add("SecondaryAxis", SecondaryAxis.ToResoniteLinkField());
members.Add("Primary", Primary.ToResoniteLinkField());
members.Add("Secondary", Secondary.ToResoniteLinkField());
members.Add("_primaryStrengthStream", _primaryStrengthStream.ToResoniteReference(context));
members.Add("_secondaryAxisStream", _secondaryAxisStream.ToResoniteReference(context));
members.Add("_primaryStream", _primaryStream.ToResoniteReference(context));
members.Add("_secondaryStream", _secondaryStream.ToResoniteReference(context));
members.Add("_rawStrength", _rawStrength.ToResoniteLinkField());
members.Add("_rawAxis", _rawAxis.ToResoniteLinkField());
members.Add("_rawPrimary", _rawPrimary.ToResoniteLinkField());
members.Add("_rawSecondary", _rawSecondary.ToResoniteLinkField());
members.Add("PrimaryActionDescription", PrimaryActionDescription.ToResoniteLinkField());
members.Add("SecondaryActionDescription", SecondaryActionDescription.ToResoniteLinkField());
}

}
}
