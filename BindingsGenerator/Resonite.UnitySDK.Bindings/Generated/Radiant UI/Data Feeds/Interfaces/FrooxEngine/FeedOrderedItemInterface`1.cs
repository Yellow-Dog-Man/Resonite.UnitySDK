
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedOrderedItemInterface<>
// Generated on: čtvrtek 26. února 2026 15:09:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedOrderedItemInterface<>")]
public partial class FeedOrderedItemInterface<T> : global::FrooxEngine.FeedValueItemInterface<T>
	

{
    public global::FrooxEngine.IField<global::System.Boolean> IsFirst { get => IsFirst_Element.Data; set => IsFirst_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsFirst_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsLast { get => IsLast_Element.Data; set => IsLast_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsLast_Element = new();
public global::FrooxEngine.IField<global::System.String> MoveUpLabel { get => MoveUpLabel_Element.Data; set => MoveUpLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> MoveUpLabel_Element = new();
public global::FrooxEngine.IField<global::System.String> MoveDownLabel { get => MoveDownLabel_Element.Data; set => MoveDownLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> MoveDownLabel_Element = new();
public global::FrooxEngine.IField<global::System.String> MakeFirstLabel { get => MakeFirstLabel_Element.Data; set => MakeFirstLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> MakeFirstLabel_Element = new();
public global::FrooxEngine.IField<global::System.String> MakeLastLabel { get => MakeLastLabel_Element.Data; set => MakeLastLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> MakeLastLabel_Element = new();
public global::FrooxEngine.SyncDelegate<global::System.Action> MoveUp { get => MoveUp_Element.Data; set => MoveUp_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action>>, global::FrooxEngine.SyncDelegate<global::System.Action>> MoveUp_Element = new();
public global::FrooxEngine.SyncDelegate<global::System.Action> MoveDown { get => MoveDown_Element.Data; set => MoveDown_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action>>, global::FrooxEngine.SyncDelegate<global::System.Action>> MoveDown_Element = new();
public global::FrooxEngine.SyncDelegate<global::System.Action> MakeFirst { get => MakeFirst_Element.Data; set => MakeFirst_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action>>, global::FrooxEngine.SyncDelegate<global::System.Action>> MakeFirst_Element = new();
public global::FrooxEngine.SyncDelegate<global::System.Action> MakeLast { get => MakeLast_Element.Data; set => MakeLast_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action>>, global::FrooxEngine.SyncDelegate<global::System.Action>> MakeLast_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasMoveUp { get => HasMoveUp_Element.Data; set => HasMoveUp_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasMoveUp_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasMoveDown { get => HasMoveDown_Element.Data; set => HasMoveDown_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasMoveDown_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasMakeFirst { get => HasMakeFirst_Element.Data; set => HasMakeFirst_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasMakeFirst_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasMakeLast { get => HasMakeLast_Element.Data; set => HasMakeLast_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasMakeLast_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsFirst", IsFirst_Element.ToLinkReference(context));
members.Add("IsLast", IsLast_Element.ToLinkReference(context));
members.Add("MoveUpLabel", MoveUpLabel_Element.ToLinkReference(context));
members.Add("MoveDownLabel", MoveDownLabel_Element.ToLinkReference(context));
members.Add("MakeFirstLabel", MakeFirstLabel_Element.ToLinkReference(context));
members.Add("MakeLastLabel", MakeLastLabel_Element.ToLinkReference(context));
members.Add("MoveUp", MoveUp_Element.ToLinkReference(context));
members.Add("MoveDown", MoveDown_Element.ToLinkReference(context));
members.Add("MakeFirst", MakeFirst_Element.ToLinkReference(context));
members.Add("MakeLast", MakeLast_Element.ToLinkReference(context));
members.Add("HasMoveUp", HasMoveUp_Element.ToLinkReference(context));
members.Add("HasMoveDown", HasMoveDown_Element.ToLinkReference(context));
members.Add("HasMakeFirst", HasMakeFirst_Element.ToLinkReference(context));
members.Add("HasMakeLast", HasMakeLast_Element.ToLinkReference(context));
}

}
}
