
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCheckbox
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCheckbox")]
public partial class LegacyCheckbox : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ICheckbox, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsChecked;
public global::System.Boolean IsEnabled;
public global::FrooxEngine.IField<global::System.Boolean> DriveField;
public global::System.Boolean AllowWriteBack;
public global::System.Single Size;
public global::System.Single BevelPercent;
public UnityEngine.ColorX Color;
public global::FrooxEngine.BevelBoxMesh _shellMesh;
public global::FrooxEngine.BevelBoxMesh _checkMesh;
public global::FrooxEngine.LegacyHorizontalChoiceBar _titleBar;
public global::FrooxEngine.IField<UnityEngine.Vector3> _shellSize;
public global::FrooxEngine.IField<global::System.Single> _shellBevel;
public global::FrooxEngine.IField<UnityEngine.Vector3> _checkSize;
public global::FrooxEngine.IField<global::System.Single> _checkBevel;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.PBS_RimMetallic _shellMaterial;
public global::FrooxEngine.PBS_RimMetallic _checkMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsChecked", IsChecked.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("DriveField", DriveField.ToResoniteReference(context));
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("BevelPercent", BevelPercent.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_shellMesh", _shellMesh.ToResoniteReference(context));
members.Add("_checkMesh", _checkMesh.ToResoniteReference(context));
members.Add("_titleBar", _titleBar.ToResoniteReference(context));
members.Add("_shellSize", _shellSize.ToResoniteReference(context));
members.Add("_shellBevel", _shellBevel.ToResoniteReference(context));
members.Add("_checkSize", _checkSize.ToResoniteReference(context));
members.Add("_checkBevel", _checkBevel.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_shellMaterial", _shellMaterial.ToResoniteReference(context));
members.Add("_checkMaterial", _checkMaterial.ToResoniteReference(context));
}

}
}
