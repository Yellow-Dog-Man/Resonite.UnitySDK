
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialTool
// Generated on: pátek 13. února 2026 5:52:24
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReplacementMode", ReplacementMode.ToResoniteLinkField());
members.Add("AreaRadius", AreaRadius.ToResoniteLinkField());
members.Add("_areaIndicator", new ResoniteLink.Reference() { });
members.Add("_areaIndicatorRadius", new ResoniteLink.Reference() { });
members.Add("_areaIndicatorOffset", new ResoniteLink.Reference() { });
members.Add("_areaIndicatorActive", new ResoniteLink.Reference() { });
members.Add("_knobControlActive", new ResoniteLink.Reference() { });
}

}
}
