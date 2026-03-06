
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Field<>
// Generated on: pátek 6. března 2026 14:18:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.IField<T> Field { get => Field_Element.Data; set => Field_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Field_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field_Element.ToLinkReference(context));
}

}
}
