
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchChatDialog
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwitchChatDialog")]
public partial class TwitchChatDialog : global::FrooxEngine.LegacyCanvasPanel

{
    public global::System.Int32 MaxMessages { get => MaxMessages_Element.Data; set => MaxMessages_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxMessages_Element = new();
public global::FrooxEngine.TwitchInterface Interface { get => Interface_Element.Data; set => Interface_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TwitchInterface>, global::FrooxEngine.TwitchInterface> Interface_Element = new();
public global::FrooxEngine.UIX.TextField _channelName { get => _channelName_Element.Data; set => _channelName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _channelName_Element = new();
public global::FrooxEngine.UIX.Text _viewerCount { get => _viewerCount_Element.Data; set => _viewerCount_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _viewerCount_Element = new();
public global::FrooxEngine.Slot _messagesRoot { get => _messagesRoot_Element.Data; set => _messagesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _messagesRoot_Element = new();
public global::FrooxEngine.UIX.ScrollRect _messagesScrollRect { get => _messagesScrollRect_Element.Data; set => _messagesScrollRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ScrollRect>, global::FrooxEngine.UIX.ScrollRect> _messagesScrollRect_Element = new();
public global::FrooxEngine.UIX.Image _highlightPanel { get => _highlightPanel_Element.Data; set => _highlightPanel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _highlightPanel_Element = new();
public global::FrooxEngine.UIX.Text _highlightText { get => _highlightText_Element.Data; set => _highlightText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _highlightText_Element = new();
public global::FrooxEngine.DynamicSpriteFont _spriteSheet { get => _spriteSheet_Element.Data; set => _spriteSheet_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DynamicSpriteFont>, global::FrooxEngine.DynamicSpriteFont> _spriteSheet_Element = new();
public global::FrooxEngine.FontCollection _fontCollection { get => _fontCollection_Element.Data; set => _fontCollection_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FontCollection>, global::FrooxEngine.FontCollection> _fontCollection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxMessages", MaxMessages_Element.ToLinkField(context));
members.Add("Interface", Interface_Element.ToLinkReference(context));
members.Add("_channelName", _channelName_Element.ToLinkReference(context));
members.Add("_viewerCount", _viewerCount_Element.ToLinkReference(context));
members.Add("_messagesRoot", _messagesRoot_Element.ToLinkReference(context));
members.Add("_messagesScrollRect", _messagesScrollRect_Element.ToLinkReference(context));
members.Add("_highlightPanel", _highlightPanel_Element.ToLinkReference(context));
members.Add("_highlightText", _highlightText_Element.ToLinkReference(context));
members.Add("_spriteSheet", _spriteSheet_Element.ToLinkReference(context));
members.Add("_fontCollection", _fontCollection_Element.ToLinkReference(context));
}

}
}
