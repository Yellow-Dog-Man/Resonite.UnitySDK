
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Receiver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Receiver")]
public partial class OSC_Receiver : global::FrooxEngine.OSC_Handler

{
    public global::System.Int32 Port { get => Port_Element.Data; set => Port_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Port_Element = new();
public global::System.Boolean IsListening { get => IsListening_Element.Data; set => IsListening_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsListening_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Port", Port_Element.ToLinkField(context));
members.Add("IsListening", IsListening_Element.ToLinkField(context));
}

}
}
