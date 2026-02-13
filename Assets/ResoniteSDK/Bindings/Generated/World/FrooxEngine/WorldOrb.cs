
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldOrb
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldOrb")]
public partial class WorldOrb : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IWorldLink, global::FrooxEngine.IMaterialApplyPolicy, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.User SessionStartingUser;
public System.Uri URL;
public System.Collections.Generic.List<System.Uri> ActiveSessionURLs;
public global::FrooxEngine.WorldOrb.VisitState Visit;
public global::System.Int32 ActiveUsers;
public global::System.Boolean RecordStateUpdated;
public global::System.Boolean IsPublic;
public global::System.Boolean CanModify;
public UnityEngine.ColorX LongPressIndicatorColor;
public global::System.Single LongPressTime;
public global::FrooxEngine.RingMesh _longPressIndicator;
public global::FrooxEngine.UnlitMaterial _longPressIndicatorMaterial;
public System.Uri _lastFetchedUrl;
public global::System.Boolean _isReadOnly;
public global::FrooxEngine.Slot _orbRoot;
public global::FrooxEngine.Slot _infoRoot;
public global::FrooxEngine.StaticTexture2D _thumbTex;
public global::FrooxEngine.Projection360Material _thumbMaterial;
public global::FrooxEngine.PBS_RimMetallic _shellMaterial;
public global::FrooxEngine.TextRenderer _nameText;
public global::FrooxEngine.TextRenderer _creatorText;
public global::FrooxEngine.TextRenderer _visitsText;
public global::FrooxEngine.TextRenderer _usersText;
public global::FrooxEngine.IField<UnityEngine.Vector3> _namePosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _creatorPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visitsPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _usersPosition;
public global::FrooxEngine.IField<global::System.String> _userCountText;
public global::FrooxEngine.IField<UnityEngine.Vector3> _sizeDrive;
public global::FrooxEngine.Slot _iconSlot;
public global::FrooxEngine.StaticTexture2D _iconTexture;
public global::FrooxEngine.UnlitMaterial _iconMaterial;
public global::FrooxEngine.IField<UnityEngine.Vector3> _iconPosition;
public global::FrooxEngine.NewWorldDialog _sessionStartDialog;
public global::System.Double _lastTouch;
public global::System.Double _lastFlash;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SessionStartingUser", new ResoniteLink.Reference() { });
members.Add("URL", URL.ToResoniteLinkField());
members.Add("ActiveSessionURLs", new ResoniteLink.SyncList()
{
    Elements = ActiveSessionURLs.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("Visit", Visit.ToResoniteLinkField());
members.Add("ActiveUsers", ActiveUsers.ToResoniteLinkField());
members.Add("RecordStateUpdated", RecordStateUpdated.ToResoniteLinkField());
members.Add("IsPublic", IsPublic.ToResoniteLinkField());
members.Add("CanModify", CanModify.ToResoniteLinkField());
members.Add("LongPressIndicatorColor", LongPressIndicatorColor.ToResoniteLinkField());
members.Add("LongPressTime", LongPressTime.ToResoniteLinkField());
members.Add("_longPressIndicator", new ResoniteLink.Reference() { });
members.Add("_longPressIndicatorMaterial", new ResoniteLink.Reference() { });
members.Add("_lastFetchedUrl", _lastFetchedUrl.ToResoniteLinkField());
members.Add("_isReadOnly", _isReadOnly.ToResoniteLinkField());
members.Add("_orbRoot", new ResoniteLink.Reference() { });
members.Add("_infoRoot", new ResoniteLink.Reference() { });
members.Add("_thumbTex", new ResoniteLink.Reference() { });
members.Add("_thumbMaterial", new ResoniteLink.Reference() { });
members.Add("_shellMaterial", new ResoniteLink.Reference() { });
members.Add("_nameText", new ResoniteLink.Reference() { });
members.Add("_creatorText", new ResoniteLink.Reference() { });
members.Add("_visitsText", new ResoniteLink.Reference() { });
members.Add("_usersText", new ResoniteLink.Reference() { });
members.Add("_namePosition", new ResoniteLink.Reference() { });
members.Add("_creatorPosition", new ResoniteLink.Reference() { });
members.Add("_visitsPosition", new ResoniteLink.Reference() { });
members.Add("_usersPosition", new ResoniteLink.Reference() { });
members.Add("_userCountText", new ResoniteLink.Reference() { });
members.Add("_sizeDrive", new ResoniteLink.Reference() { });
members.Add("_iconSlot", new ResoniteLink.Reference() { });
members.Add("_iconTexture", new ResoniteLink.Reference() { });
members.Add("_iconMaterial", new ResoniteLink.Reference() { });
members.Add("_iconPosition", new ResoniteLink.Reference() { });
members.Add("_sessionStartDialog", new ResoniteLink.Reference() { });
members.Add("_lastTouch", _lastTouch.ToResoniteLinkField());
members.Add("_lastFlash", _lastFlash.ToResoniteLinkField());
}

}
}
