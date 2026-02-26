
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConfirmationHandler
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConfirmationHandler")]
public partial class ConfirmationHandler : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> Color_Element = new();
public global::System.String OriginalLabel { get => OriginalLabel_Element.Data; set => OriginalLabel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OriginalLabel_Element = new();
public UnityEngine.ColorX OriginalColor { get => OriginalColor_Element.Data; set => OriginalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OriginalColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Label", Label_Element.ToLinkReference(context));
members.Add("Color", Color_Element.ToLinkReference(context));
members.Add("OriginalLabel", OriginalLabel_Element.ToLinkField(context));
members.Add("OriginalColor", OriginalColor_Element.ToLinkField(context));
}

}
}
