
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedOrderedItemInterface<>
// Generated on: sobota 14. února 2026 8:58:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedOrderedItemInterface<>")]
public partial class FeedOrderedItemInterface<T> : global::FrooxEngine.FeedValueItemInterface<T>
	

{
    public global::FrooxEngine.IField<global::System.Boolean> IsFirst;
public global::FrooxEngine.IField<global::System.Boolean> IsLast;
public global::FrooxEngine.IField<global::System.String> MoveUpLabel;
public global::FrooxEngine.IField<global::System.String> MoveDownLabel;
public global::FrooxEngine.IField<global::System.String> MakeFirstLabel;
public global::FrooxEngine.IField<global::System.String> MakeLastLabel;
public global::FrooxEngine.SyncDelegate<global::System.Action> MoveUp;
public global::FrooxEngine.SyncDelegate<global::System.Action> MoveDown;
public global::FrooxEngine.SyncDelegate<global::System.Action> MakeFirst;
public global::FrooxEngine.SyncDelegate<global::System.Action> MakeLast;
public global::FrooxEngine.IField<global::System.Boolean> HasMoveUp;
public global::FrooxEngine.IField<global::System.Boolean> HasMoveDown;
public global::FrooxEngine.IField<global::System.Boolean> HasMakeFirst;
public global::FrooxEngine.IField<global::System.Boolean> HasMakeLast;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsFirst", IsFirst.ToResoniteReference(context));
members.Add("IsLast", IsLast.ToResoniteReference(context));
members.Add("MoveUpLabel", MoveUpLabel.ToResoniteReference(context));
members.Add("MoveDownLabel", MoveDownLabel.ToResoniteReference(context));
members.Add("MakeFirstLabel", MakeFirstLabel.ToResoniteReference(context));
members.Add("MakeLastLabel", MakeLastLabel.ToResoniteReference(context));
members.Add("MoveUp", MoveUp.ToResoniteReference(context));
members.Add("MoveDown", MoveDown.ToResoniteReference(context));
members.Add("MakeFirst", MakeFirst.ToResoniteReference(context));
members.Add("MakeLast", MakeLast.ToResoniteReference(context));
members.Add("HasMoveUp", HasMoveUp.ToResoniteReference(context));
members.Add("HasMoveDown", HasMoveDown.ToResoniteReference(context));
members.Add("HasMakeFirst", HasMakeFirst.ToResoniteReference(context));
members.Add("HasMakeLast", HasMakeLast.ToResoniteReference(context));
}

}
}
