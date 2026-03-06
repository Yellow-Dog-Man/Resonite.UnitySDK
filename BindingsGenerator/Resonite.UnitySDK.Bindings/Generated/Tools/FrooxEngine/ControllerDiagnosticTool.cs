
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ControllerDiagnosticTool
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ControllerDiagnosticTool")]
public partial class ControllerDiagnosticTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.TextRenderer _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_text", _text_Element.ToLinkReference(context));
}

}
}
