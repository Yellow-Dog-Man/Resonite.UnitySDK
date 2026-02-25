
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimpleAwayIndicator
// Generated on: středa 25. února 2026 16:14:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimpleAwayIndicator")]
public partial class SimpleAwayIndicator : global::FrooxEngine.Component, global::FrooxEngine.IMeshBakeEventReceiver, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> AwayMaterial;
public global::FrooxEngine.MeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> _oldMaterials;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("AwayMaterial", AwayMaterial.ToResoniteReference(context));
members.Add("Renderer", Renderer.ToResoniteReference(context));
members.Add("_oldMaterials", new ResoniteLink.SyncList()
{
    Elements = _oldMaterials.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
