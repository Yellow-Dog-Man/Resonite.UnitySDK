
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedOrderedItemInterface<>
// Generated on: pátek 13. února 2026 5:52:18
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsFirst", new ResoniteLink.Reference() { });
members.Add("IsLast", new ResoniteLink.Reference() { });
members.Add("MoveUpLabel", new ResoniteLink.Reference() { });
members.Add("MoveDownLabel", new ResoniteLink.Reference() { });
members.Add("MakeFirstLabel", new ResoniteLink.Reference() { });
members.Add("MakeLastLabel", new ResoniteLink.Reference() { });
members.Add("MoveUp", new ResoniteLink.Reference() { });
members.Add("MoveDown", new ResoniteLink.Reference() { });
members.Add("MakeFirst", new ResoniteLink.Reference() { });
members.Add("MakeLast", new ResoniteLink.Reference() { });
members.Add("HasMoveUp", new ResoniteLink.Reference() { });
members.Add("HasMoveDown", new ResoniteLink.Reference() { });
members.Add("HasMakeFirst", new ResoniteLink.Reference() { });
members.Add("HasMakeLast", new ResoniteLink.Reference() { });
}

}
}
