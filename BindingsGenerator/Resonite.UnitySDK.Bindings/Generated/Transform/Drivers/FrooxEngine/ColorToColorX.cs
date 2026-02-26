
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorToColorX
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorToColorX")]
public partial class ColorToColorX : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Color> SourceColor { get => SourceColor_Element.Data; set => SourceColor_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Color>>, global::FrooxEngine.IField<UnityEngine.Color>> SourceColor_Element = new();
public global::FrooxEngine.IField<global::Renderite.Shared.ColorProfile> SourceProfile { get => SourceProfile_Element.Data; set => SourceProfile_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::Renderite.Shared.ColorProfile>>, global::FrooxEngine.IField<global::Renderite.Shared.ColorProfile>> SourceProfile_Element = new();
public global::Renderite.Shared.ColorProfile DefaultProfile { get => DefaultProfile_Element.Data; set => DefaultProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> DefaultProfile_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> Target_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SourceColor", SourceColor_Element.Data.ToResoniteReference(context));
members.Add("SourceProfile", SourceProfile_Element.Data.ToResoniteReference(context));
members.Add("DefaultProfile", DefaultProfile_Element.Data.ToResoniteLinkField());
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("WriteBack", WriteBack_Element.Data.ToResoniteLinkField());
}

}
}
