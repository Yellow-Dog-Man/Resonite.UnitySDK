
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Tool
// Generated on: středa 25. února 2026 16:14:10
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_equipLink", new ResoniteLink.EmptyElement());
members.Add("TipReference", TipReference.ToResoniteReference(context));
members.Add("BlockGripEquip", BlockGripEquip.ToResoniteLinkField());
members.Add("BlockRemoteEquip", BlockRemoteEquip.ToResoniteLinkField());
members.Add("EquipName", EquipName.ToResoniteLinkField());
members.Add("_overrideActiveTool", _overrideActiveTool.ToResoniteReference(context));
members.Add("_gripPosesGenerated", _gripPosesGenerated.ToResoniteLinkField());
}

}
}
