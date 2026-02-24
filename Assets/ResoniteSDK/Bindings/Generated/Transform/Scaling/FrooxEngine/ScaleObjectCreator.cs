
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObjectCreator
// Generated on: úterý 24. února 2026 18:20:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObjectCreator")]
public partial class ScaleObjectCreator : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleObjectManager Manager;
public global::FrooxEngine.Slot Template;
public global::FrooxEngine.IField<global::System.String> TemplateNameField;
public global::FrooxEngine.IField<global::System.Double> TemplateSizeField;
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance> _sizeParser;
public global::FrooxEngine.FresnelMaterial _material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Manager", Manager.ToResoniteReference(context));
members.Add("Template", Template.ToResoniteReference(context));
members.Add("TemplateNameField", TemplateNameField.ToResoniteReference(context));
members.Add("TemplateSizeField", TemplateSizeField.ToResoniteReference(context));
members.Add("_sizeParser", _sizeParser.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
}

}
}
