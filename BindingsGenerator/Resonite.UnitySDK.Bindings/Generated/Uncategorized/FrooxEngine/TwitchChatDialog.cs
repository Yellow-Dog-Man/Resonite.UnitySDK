
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchChatDialog
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwitchChatDialog")]
public partial class TwitchChatDialog : global::FrooxEngine.LegacyCanvasPanel

{
    public global::System.Int32 MaxMessages;
public global::FrooxEngine.TwitchInterface Interface;
public global::FrooxEngine.UIX.TextField _channelName;
public global::FrooxEngine.UIX.Text _viewerCount;
public global::FrooxEngine.Slot _messagesRoot;
public global::FrooxEngine.UIX.ScrollRect _messagesScrollRect;
public global::FrooxEngine.UIX.Image _highlightPanel;
public global::FrooxEngine.UIX.Text _highlightText;
public global::FrooxEngine.DynamicSpriteFont _spriteSheet;
public global::FrooxEngine.FontCollection _fontCollection;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxMessages", MaxMessages.ToResoniteLinkField());
members.Add("Interface", Interface.ToResoniteReference(context));
members.Add("_channelName", _channelName.ToResoniteReference(context));
members.Add("_viewerCount", _viewerCount.ToResoniteReference(context));
members.Add("_messagesRoot", _messagesRoot.ToResoniteReference(context));
members.Add("_messagesScrollRect", _messagesScrollRect.ToResoniteReference(context));
members.Add("_highlightPanel", _highlightPanel.ToResoniteReference(context));
members.Add("_highlightText", _highlightText.ToResoniteReference(context));
members.Add("_spriteSheet", _spriteSheet.ToResoniteReference(context));
members.Add("_fontCollection", _fontCollection.ToResoniteReference(context));
}

}
}
