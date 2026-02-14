
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialTool
// Generated on: sobota 14. února 2026 8:58:37
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialTool")]
public partial class MaterialTool : global::FrooxEngine.OrbCartridgeTool

{
    public global::FrooxEngine.AssetToolReplacementMode ReplacementMode;
public global::System.Single AreaRadius;
public global::FrooxEngine.Slot _areaIndicator;
public global::FrooxEngine.IField<global::System.Single> _areaIndicatorRadius;
public global::FrooxEngine.IField<UnityEngine.Vector3> _areaIndicatorOffset;
public global::FrooxEngine.IField<global::System.Boolean> _areaIndicatorActive;
public global::FrooxEngine.IField<global::System.Boolean> _knobControlActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReplacementMode", ReplacementMode.ToResoniteLinkField());
members.Add("AreaRadius", AreaRadius.ToResoniteLinkField());
members.Add("_areaIndicator", _areaIndicator.ToResoniteReference(context));
members.Add("_areaIndicatorRadius", _areaIndicatorRadius.ToResoniteReference(context));
members.Add("_areaIndicatorOffset", _areaIndicatorOffset.ToResoniteReference(context));
members.Add("_areaIndicatorActive", _areaIndicatorActive.ToResoniteReference(context));
members.Add("_knobControlActive", _knobControlActive.ToResoniteReference(context));
}

}
}
