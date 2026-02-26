
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialTool
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialTool")]
public partial class MaterialTool : global::FrooxEngine.OrbCartridgeTool

{
    public global::FrooxEngine.AssetToolReplacementMode ReplacementMode { get => ReplacementMode_Element.Data; set => ReplacementMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AssetToolReplacementMode>, global::FrooxEngine.AssetToolReplacementMode> ReplacementMode_Element = new();
public global::System.Single AreaRadius { get => AreaRadius_Element.Data; set => AreaRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AreaRadius_Element = new();
public global::FrooxEngine.Slot _areaIndicator { get => _areaIndicator_Element.Data; set => _areaIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _areaIndicator_Element = new();
public global::FrooxEngine.IField<global::System.Single> _areaIndicatorRadius { get => _areaIndicatorRadius_Element.Data; set => _areaIndicatorRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _areaIndicatorRadius_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _areaIndicatorOffset { get => _areaIndicatorOffset_Element.Data; set => _areaIndicatorOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _areaIndicatorOffset_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _areaIndicatorActive { get => _areaIndicatorActive_Element.Data; set => _areaIndicatorActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _areaIndicatorActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _knobControlActive { get => _knobControlActive_Element.Data; set => _knobControlActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _knobControlActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReplacementMode", ReplacementMode_Element.Data.ToResoniteLinkField());
members.Add("AreaRadius", AreaRadius_Element.Data.ToResoniteLinkField());
members.Add("_areaIndicator", _areaIndicator_Element.Data.ToResoniteReference(context));
members.Add("_areaIndicatorRadius", _areaIndicatorRadius_Element.Data.ToResoniteReference(context));
members.Add("_areaIndicatorOffset", _areaIndicatorOffset_Element.Data.ToResoniteReference(context));
members.Add("_areaIndicatorActive", _areaIndicatorActive_Element.Data.ToResoniteReference(context));
members.Add("_knobControlActive", _knobControlActive_Element.Data.ToResoniteReference(context));
}

}
}
