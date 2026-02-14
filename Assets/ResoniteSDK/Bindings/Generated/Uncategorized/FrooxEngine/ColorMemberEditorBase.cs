
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorMemberEditorBase
// Generated on: sobota 14. února 2026 8:58:42
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
