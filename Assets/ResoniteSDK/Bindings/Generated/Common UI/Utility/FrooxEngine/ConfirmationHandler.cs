
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConfirmationHandler
// Generated on: pátek 13. února 2026 23:21:38
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConfirmationHandler")]
public partial class ConfirmationHandler : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Label;
public global::FrooxEngine.IField<UnityEngine.ColorX> Color;
public global::System.String OriginalLabel;
public UnityEngine.ColorX OriginalColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Label", new ResoniteLink.Reference() { });
members.Add("Color", new ResoniteLink.Reference() { });
members.Add("OriginalLabel", OriginalLabel.ToResoniteLinkField());
members.Add("OriginalColor", OriginalColor.ToResoniteLinkField());
}

}
}
