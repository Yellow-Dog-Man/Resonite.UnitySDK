
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualKeyboard
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualKeyboard")]
public partial class VirtualKeyboard : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::System.Boolean ShiftActive { get => ShiftActive_Element.Data; set => ShiftActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShiftActive_Element = new();
public global::System.Boolean HoldShift { get => HoldShift_Element.Data; set => HoldShift_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HoldShift_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> TextPreviewActive { get => TextPreviewActive_Element.Data; set => TextPreviewActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> TextPreviewActive_Element = new();
public global::FrooxEngine.IText TextPreview { get => TextPreview_Element.Data; set => TextPreview_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IText>, global::FrooxEngine.IText> TextPreview_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShiftActive", ShiftActive_Element.ToLinkField(context));
members.Add("HoldShift", HoldShift_Element.ToLinkField(context));
members.Add("TextPreviewActive", TextPreviewActive_Element.ToLinkReference(context));
members.Add("TextPreview", TextPreview_Element.ToLinkReference(context));
}

}
}
