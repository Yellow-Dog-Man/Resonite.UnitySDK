
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Field<>
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Field<>")]
public partial class OSC_Field<T> : global::FrooxEngine.OSC_ValueHandler<T>
	

{
    public global::FrooxEngine.IField<T> Field;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Field", new ResoniteLink.Reference() { });
}

}
}
