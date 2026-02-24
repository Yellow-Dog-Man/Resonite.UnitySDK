
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldOrb
// Generated on: úterý 24. února 2026 18:20:27
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionStartingUser", SessionStartingUser.ToResoniteReference(context));
members.Add("URL", URL.ToResoniteLinkField());
members.Add("ActiveSessionURLs", new ResoniteLink.SyncList()
{
    Elements = ActiveSessionURLs.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("Visit", Visit.ToResoniteLinkField());
members.Add("ActiveUsers", ActiveUsers.ToResoniteLinkField());
members.Add("RecordStateUpdated", RecordStateUpdated.ToResoniteLinkField());
members.Add("IsPublic", IsPublic.ToResoniteLinkField());
members.Add("CanModify", CanModify.ToResoniteLinkField());
members.Add("LongPressIndicatorColor", LongPressIndicatorColor.ToResoniteLinkField());
members.Add("LongPressTime", LongPressTime.ToResoniteLinkField());
members.Add("_longPressIndicator", _longPressIndicator.ToResoniteReference(context));
members.Add("_longPressIndicatorMaterial", _longPressIndicatorMaterial.ToResoniteReference(context));
members.Add("_lastFetchedUrl", _lastFetchedUrl.ToResoniteLinkField());
members.Add("_isReadOnly", _isReadOnly.ToResoniteLinkField());
members.Add("_orbRoot", _orbRoot.ToResoniteReference(context));
members.Add("_infoRoot", _infoRoot.ToResoniteReference(context));
members.Add("_thumbTex", _thumbTex.ToResoniteReference(context));
members.Add("_thumbMaterial", _thumbMaterial.ToResoniteReference(context));
members.Add("_shellMaterial", _shellMaterial.ToResoniteReference(context));
members.Add("_nameText", _nameText.ToResoniteReference(context));
members.Add("_creatorText", _creatorText.ToResoniteReference(context));
members.Add("_visitsText", _visitsText.ToResoniteReference(context));
members.Add("_usersText", _usersText.ToResoniteReference(context));
members.Add("_namePosition", _namePosition.ToResoniteReference(context));
members.Add("_creatorPosition", _creatorPosition.ToResoniteReference(context));
members.Add("_visitsPosition", _visitsPosition.ToResoniteReference(context));
members.Add("_usersPosition", _usersPosition.ToResoniteReference(context));
members.Add("_userCountText", _userCountText.ToResoniteReference(context));
members.Add("_sizeDrive", _sizeDrive.ToResoniteReference(context));
members.Add("_iconSlot", _iconSlot.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture.ToResoniteReference(context));
members.Add("_iconMaterial", _iconMaterial.ToResoniteReference(context));
members.Add("_iconPosition", _iconPosition.ToResoniteReference(context));
members.Add("_sessionStartDialog", _sessionStartDialog.ToResoniteReference(context));
members.Add("_lastTouch", _lastTouch.ToResoniteLinkField());
members.Add("_lastFlash", _lastFlash.ToResoniteLinkField());
}

}
}
