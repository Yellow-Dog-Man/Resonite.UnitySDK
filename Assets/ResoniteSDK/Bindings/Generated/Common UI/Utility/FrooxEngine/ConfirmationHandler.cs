
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConfirmationHandler
// Generated on: úterý 24. února 2026 18:17:46
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConfirmationHandler")]
public partial class ConfirmationHandler : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Label;
public global::FrooxEngine.IField<UnityEngine.ColorX> Color;
public global::System.String OriginalLabel;
public UnityEngine.ColorX OriginalColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Label", Label.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
members.Add("OriginalLabel", OriginalLabel.ToResoniteLinkField());
members.Add("OriginalColor", OriginalColor.ToResoniteLinkField());
}

}
}
