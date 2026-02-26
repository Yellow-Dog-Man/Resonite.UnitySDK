
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RawDataTool
// Generated on: čtvrtek 26. února 2026 15:08:58
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public UnityEngine.Vector3 LocalTipOffset { get => LocalTipOffset_Element.Data; set => LocalTipOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalTipOffset_Element = new();
public global::FrooxEngine.Slot LocalTipReference { get => LocalTipReference_Element.Data; set => LocalTipReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> LocalTipReference_Element = new();
public global::System.Boolean UseLaser { get => UseLaser_Element.Data; set => UseLaser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLaser_Element = new();
public global::System.Boolean BlockPrimaryWhenTouching { get => BlockPrimaryWhenTouching_Element.Data; set => BlockPrimaryWhenTouching_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockPrimaryWhenTouching_Element = new();
public global::System.Boolean UseSecondary { get => UseSecondary_Element.Data; set => UseSecondary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSecondary_Element = new();
public global::System.Boolean AllowUseWhenHolding { get => AllowUseWhenHolding_Element.Data; set => AllowUseWhenHolding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowUseWhenHolding_Element = new();
public global::System.Boolean Equipped { get => Equipped_Element.Data; set => Equipped_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Equipped_Element = new();
public System.String ControllerType { get => ControllerType_Element.Data; set => ControllerType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> ControllerType_Element = new();
public global::Renderite.Shared.Chirality ControllerSide { get => ControllerSide_Element.Data; set => ControllerSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> ControllerSide_Element = new();
public global::System.Single PrimaryStrength { get => PrimaryStrength_Element.Data; set => PrimaryStrength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> PrimaryStrength_Element = new();
public UnityEngine.Vector2 SecondaryAxis { get => SecondaryAxis_Element.Data; set => SecondaryAxis_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2>, UnityEngine.Vector2> SecondaryAxis_Element = new();
public global::System.Boolean Primary { get => Primary_Element.Data; set => Primary_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> Primary_Element = new();
public global::System.Boolean Secondary { get => Secondary_Element.Data; set => Secondary_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> Secondary_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> _primaryStrengthStream { get => _primaryStrengthStream_Element.Data; set => _primaryStrengthStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> _primaryStrengthStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector2> _secondaryAxisStream { get => _secondaryAxisStream_Element.Data; set => _secondaryAxisStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector2>>, global::FrooxEngine.ValueStream<UnityEngine.Vector2>> _secondaryAxisStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> _primaryStream { get => _primaryStream_Element.Data; set => _primaryStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> _primaryStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> _secondaryStream { get => _secondaryStream_Element.Data; set => _secondaryStream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> _secondaryStream_Element = new();
public global::System.Single _rawStrength { get => _rawStrength_Element.Data; set => _rawStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _rawStrength_Element = new();
public UnityEngine.Vector2 _rawAxis { get => _rawAxis_Element.Data; set => _rawAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _rawAxis_Element = new();
public global::System.Boolean _rawPrimary { get => _rawPrimary_Element.Data; set => _rawPrimary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _rawPrimary_Element = new();
public global::System.Boolean _rawSecondary { get => _rawSecondary_Element.Data; set => _rawSecondary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _rawSecondary_Element = new();
public global::System.String PrimaryActionDescription { get => PrimaryActionDescription_Element.Data; set => PrimaryActionDescription_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PrimaryActionDescription_Element = new();
public global::System.String SecondaryActionDescription { get => SecondaryActionDescription_Element.Data; set => SecondaryActionDescription_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SecondaryActionDescription_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalTipOffset", LocalTipOffset_Element.ToLinkField(context));
members.Add("LocalTipReference", LocalTipReference_Element.ToLinkReference(context));
members.Add("UseLaser", UseLaser_Element.ToLinkField(context));
members.Add("BlockPrimaryWhenTouching", BlockPrimaryWhenTouching_Element.ToLinkField(context));
members.Add("UseSecondary", UseSecondary_Element.ToLinkField(context));
members.Add("AllowUseWhenHolding", AllowUseWhenHolding_Element.ToLinkField(context));
members.Add("Equipped", Equipped_Element.ToLinkField(context));
members.Add("ControllerType", ControllerType_Element.ToLinkField(context));
members.Add("ControllerSide", ControllerSide_Element.ToLinkField(context));
members.Add("PrimaryStrength", PrimaryStrength_Element.ToLinkField(context));
members.Add("SecondaryAxis", SecondaryAxis_Element.ToLinkField(context));
members.Add("Primary", Primary_Element.ToLinkField(context));
members.Add("Secondary", Secondary_Element.ToLinkField(context));
members.Add("_primaryStrengthStream", _primaryStrengthStream_Element.ToLinkReference(context));
members.Add("_secondaryAxisStream", _secondaryAxisStream_Element.ToLinkReference(context));
members.Add("_primaryStream", _primaryStream_Element.ToLinkReference(context));
members.Add("_secondaryStream", _secondaryStream_Element.ToLinkReference(context));
members.Add("_rawStrength", _rawStrength_Element.ToLinkField(context));
members.Add("_rawAxis", _rawAxis_Element.ToLinkField(context));
members.Add("_rawPrimary", _rawPrimary_Element.ToLinkField(context));
members.Add("_rawSecondary", _rawSecondary_Element.ToLinkField(context));
members.Add("PrimaryActionDescription", PrimaryActionDescription_Element.ToLinkField(context));
members.Add("SecondaryActionDescription", SecondaryActionDescription_Element.ToLinkField(context));
}

}
}
