
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Checkbox
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Checkbox")]
public partial class Checkbox : global::FrooxEngine.UIX.UIComponent, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> State_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> TargetState { get => TargetState_Element.Data; set => TargetState_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> TargetState_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> CheckVisual { get => CheckVisual_Element.Data; set => CheckVisual_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> CheckVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State_Element.ToLinkField(context));
members.Add("TargetState", TargetState_Element.ToLinkReference(context));
members.Add("CheckVisual", CheckVisual_Element.ToLinkReference(context));
}

}
}
