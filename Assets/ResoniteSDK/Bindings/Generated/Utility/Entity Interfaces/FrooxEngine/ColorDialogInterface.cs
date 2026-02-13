
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDialogInterface
// Generated on: pátek 13. února 2026 5:51:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorDialogInterface")]
public partial class ColorDialogInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>> TargetColor;
public global::FrooxEngine.IField<global::System.Boolean> Continuous;
public global::FrooxEngine.IField<global::System.Boolean> AllowAlpha;
public global::FrooxEngine.IField<global::System.Boolean> AllowHDR;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetColor", new ResoniteLink.Reference() { });
members.Add("Continuous", new ResoniteLink.Reference() { });
members.Add("AllowAlpha", new ResoniteLink.Reference() { });
members.Add("AllowHDR", new ResoniteLink.Reference() { });
}

}
}
