
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextEditorParser<>
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
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
    public global::System.Boolean ParseContinuously { get => ParseContinuously_Element.Data; set => ParseContinuously_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParseContinuously_Element = new();
public global::System.Boolean UpdateStringFromValue { get => UpdateStringFromValue_Element.Data; set => UpdateStringFromValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UpdateStringFromValue_Element = new();
public T ParsedValue { get => ParsedValue_Element.Data; set => ParsedValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ParsedValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParseContinuously", ParseContinuously_Element.ToLinkField(context));
members.Add("UpdateStringFromValue", UpdateStringFromValue_Element.ToLinkField(context));
members.Add("ParsedValue", ParsedValue_Element.ToLinkField(context));
}

}
}
