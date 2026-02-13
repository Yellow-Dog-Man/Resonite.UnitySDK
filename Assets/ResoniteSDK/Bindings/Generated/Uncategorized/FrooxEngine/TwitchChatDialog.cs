
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchChatDialog
// Generated on: pátek 13. února 2026 23:23:15
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MaxMessages", MaxMessages.ToResoniteLinkField());
members.Add("Interface", new ResoniteLink.Reference() { });
members.Add("_channelName", new ResoniteLink.Reference() { });
members.Add("_viewerCount", new ResoniteLink.Reference() { });
members.Add("_messagesRoot", new ResoniteLink.Reference() { });
members.Add("_messagesScrollRect", new ResoniteLink.Reference() { });
members.Add("_highlightPanel", new ResoniteLink.Reference() { });
members.Add("_highlightText", new ResoniteLink.Reference() { });
members.Add("_spriteSheet", new ResoniteLink.Reference() { });
members.Add("_fontCollection", new ResoniteLink.Reference() { });
}

}
}
