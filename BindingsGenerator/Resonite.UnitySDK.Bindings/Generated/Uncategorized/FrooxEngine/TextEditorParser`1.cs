
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextEditorParser<>
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextEditorParser<>")]
public abstract partial class TextEditorParser<T> : global::FrooxEngine.Component, global::FrooxEngine.ITextEditorEventReceiver
	

{
    public global::System.Boolean ParseContinuously;
public global::System.Boolean UpdateStringFromValue;
public T ParsedValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParseContinuously", ParseContinuously.ToResoniteLinkField());
members.Add("UpdateStringFromValue", UpdateStringFromValue.ToResoniteLinkField());
members.Add("ParsedValue", ParsedValue.ToResoniteLinkField());
}

}
}
