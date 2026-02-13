
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Tool
// Generated on: pátek 13. února 2026 5:52:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Tool")]
public abstract partial class Tool : global::FrooxEngine.Component, global::FrooxEngine.ITool, global::FrooxEngine.IMaterialApplyPolicy, global::FrooxEngine.ITouchable, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.LinkTarget<global::FrooxEngine.ITool> _equipLink;
public global::FrooxEngine.Slot TipReference;
public global::System.Boolean BlockGripEquip;
public global::System.Boolean BlockRemoteEquip;
public global::System.String EquipName;
public global::FrooxEngine.InteractionHandler _overrideActiveTool;
public global::System.Boolean _gripPosesGenerated;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_equipLink", new ResoniteLink.EmptyElement());
members.Add("TipReference", new ResoniteLink.Reference() { });
members.Add("BlockGripEquip", BlockGripEquip.ToResoniteLinkField());
members.Add("BlockRemoteEquip", BlockRemoteEquip.ToResoniteLinkField());
members.Add("EquipName", EquipName.ToResoniteLinkField());
members.Add("_overrideActiveTool", new ResoniteLink.Reference() { });
members.Add("_gripPosesGenerated", _gripPosesGenerated.ToResoniteLinkField());
}

}
}
