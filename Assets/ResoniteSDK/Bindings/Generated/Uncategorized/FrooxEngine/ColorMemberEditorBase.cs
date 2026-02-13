
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorMemberEditorBase
// Generated on: pátek 13. února 2026 5:52:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorMemberEditorBase")]
public abstract partial class ColorMemberEditorBase : global::FrooxEngine.MemberEditor

{
    public global::System.Boolean Labels;
public global::System.Boolean Vertical;
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDrive;
public global::FrooxEngine.IField<UnityEngine.ColorX> _colorDriveNoAlpha;
public global::FrooxEngine.ColorDialogInterface _colorDialog;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Labels", Labels.ToResoniteLinkField());
members.Add("Vertical", Vertical.ToResoniteLinkField());
members.Add("_colorDrive", new ResoniteLink.Reference() { });
members.Add("_colorDriveNoAlpha", new ResoniteLink.Reference() { });
members.Add("_colorDialog", new ResoniteLink.Reference() { });
}

}
}
