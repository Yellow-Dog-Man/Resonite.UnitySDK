
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwoFactorCodeDialog
// Generated on: pátek 6. března 2026 14:19:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwoFactorCodeDialog")]
public partial class TwoFactorCodeDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _code { get => _code_Element.Data; set => _code_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _code_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_code", _code_Element.ToLinkReference(context));
}

}
}
