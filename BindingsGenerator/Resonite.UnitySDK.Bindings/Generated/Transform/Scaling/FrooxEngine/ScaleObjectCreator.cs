
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObjectCreator
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObjectCreator")]
public partial class ScaleObjectCreator : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleObjectManager Manager { get => Manager_Element.Data; set => Manager_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ScaleObjectManager>, global::FrooxEngine.ScaleObjectManager> Manager_Element = new();
public global::FrooxEngine.Slot Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Template_Element = new();
public global::FrooxEngine.IField<global::System.String> TemplateNameField { get => TemplateNameField_Element.Data; set => TemplateNameField_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> TemplateNameField_Element = new();
public global::FrooxEngine.IField<global::System.Double> TemplateSizeField { get => TemplateSizeField_Element.Data; set => TemplateSizeField_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Double>>, global::FrooxEngine.IField<global::System.Double>> TemplateSizeField_Element = new();
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance> _sizeParser { get => _sizeParser_Element.Data; set => _sizeParser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance>>, global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance>> _sizeParser_Element = new();
public global::FrooxEngine.FresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Manager", Manager_Element.ToLinkReference(context));
members.Add("Template", Template_Element.ToLinkReference(context));
members.Add("TemplateNameField", TemplateNameField_Element.ToLinkReference(context));
members.Add("TemplateSizeField", TemplateSizeField_Element.ToLinkReference(context));
members.Add("_sizeParser", _sizeParser_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
}

}
}
