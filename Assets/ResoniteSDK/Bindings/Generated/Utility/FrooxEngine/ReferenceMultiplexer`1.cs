
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceMultiplexer<>
// Generated on: úterý 24. února 2026 18:20:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceMultiplexer<>")]
public partial class ReferenceMultiplexer<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public global::System.Int32 Index;
public System.Collections.Generic.List<T> References;
public global::System.Boolean AllowWriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Index", Index.ToResoniteLinkField());
members.Add("References", new ResoniteLink.SyncList()
{
    Elements = References.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
}

}
}
