
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualKeyboard
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualKeyboard")]
public partial class VirtualKeyboard : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::System.Boolean ShiftActive;
public global::System.Boolean HoldShift;
public global::FrooxEngine.IField<global::System.Boolean> TextPreviewActive;
public global::FrooxEngine.IText TextPreview;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShiftActive", ShiftActive.ToResoniteLinkField());
members.Add("HoldShift", HoldShift.ToResoniteLinkField());
members.Add("TextPreviewActive", TextPreviewActive.ToResoniteReference(context));
members.Add("TextPreview", TextPreview.ToResoniteReference(context));
}

}
}
