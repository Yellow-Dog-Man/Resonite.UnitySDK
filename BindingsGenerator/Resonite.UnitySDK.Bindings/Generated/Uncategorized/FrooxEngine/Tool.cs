
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Tool
// Generated on: čtvrtek 26. února 2026 10:04:32
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
    public global::FrooxEngine.LinkTarget<global::FrooxEngine.ITool> _equipLink = new();
public global::FrooxEngine.Slot TipReference { get => TipReference_Element.Data; set => TipReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipReference_Element = new();
public global::System.Boolean BlockGripEquip { get => BlockGripEquip_Element.Data; set => BlockGripEquip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockGripEquip_Element = new();
public global::System.Boolean BlockRemoteEquip { get => BlockRemoteEquip_Element.Data; set => BlockRemoteEquip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockRemoteEquip_Element = new();
public global::System.String EquipName { get => EquipName_Element.Data; set => EquipName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> EquipName_Element = new();
public global::FrooxEngine.InteractionHandler _overrideActiveTool { get => _overrideActiveTool_Element.Data; set => _overrideActiveTool_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractionHandler>, global::FrooxEngine.InteractionHandler> _overrideActiveTool_Element = new();
public global::System.Boolean _gripPosesGenerated { get => _gripPosesGenerated_Element.Data; set => _gripPosesGenerated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _gripPosesGenerated_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_equipLink", new ResoniteLink.EmptyElement());
members.Add("TipReference", TipReference_Element.Data.ToResoniteReference(context));
members.Add("BlockGripEquip", BlockGripEquip_Element.Data.ToResoniteLinkField());
members.Add("BlockRemoteEquip", BlockRemoteEquip_Element.Data.ToResoniteLinkField());
members.Add("EquipName", EquipName_Element.Data.ToResoniteLinkField());
members.Add("_overrideActiveTool", _overrideActiveTool_Element.Data.ToResoniteReference(context));
members.Add("_gripPosesGenerated", _gripPosesGenerated_Element.Data.ToResoniteLinkField());
}

}
}
