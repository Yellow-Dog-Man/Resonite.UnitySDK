
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorMemberEditorBase
// Generated on: středa 25. února 2026 16:14:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorMemberEditorBase")]
public abstract partial class ColorMemberEditorBase : global::FrooxEngine.MemberEditor

{
    public global::System.Boolean Labels;
public global::System.Boolean Vertical;
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDrive;
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDriveNoAlpha;
public global::FrooxEngine.ColorDialogInterface _colorDialog;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Labels", Labels.ToResoniteLinkField());
members.Add("Vertical", Vertical.ToResoniteLinkField());
members.Add("_colorDrive", _colorDrive.ToResoniteReference(context));
members.Add("_colorDriveNoAlpha", _colorDriveNoAlpha.ToResoniteReference(context));
members.Add("_colorDialog", _colorDialog.ToResoniteReference(context));
}

}
}
