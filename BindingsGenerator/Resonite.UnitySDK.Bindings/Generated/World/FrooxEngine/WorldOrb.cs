
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldOrb
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldOrb")]
public partial class WorldOrb : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IWorldLink, global::FrooxEngine.IMaterialApplyPolicy, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.User SessionStartingUser { get => SessionStartingUser_Element.Data; set => SessionStartingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> SessionStartingUser_Element = new();
public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<System.Uri>, System.Uri, Field<global::FrooxEngine.Sync<System.Uri>, System.Uri>> ActiveSessionURLs = new();
public global::FrooxEngine.WorldOrb.VisitState Visit { get => Visit_Element.Data; set => Visit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.WorldOrb.VisitState>, global::FrooxEngine.WorldOrb.VisitState> Visit_Element = new();
public global::System.Int32 ActiveUsers { get => ActiveUsers_Element.Data; set => ActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveUsers_Element = new();
public global::System.Boolean RecordStateUpdated { get => RecordStateUpdated_Element.Data; set => RecordStateUpdated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RecordStateUpdated_Element = new();
public global::System.Boolean IsPublic { get => IsPublic_Element.Data; set => IsPublic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPublic_Element = new();
public global::System.Boolean CanModify { get => CanModify_Element.Data; set => CanModify_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanModify_Element = new();
public UnityEngine.ColorX LongPressIndicatorColor { get => LongPressIndicatorColor_Element.Data; set => LongPressIndicatorColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LongPressIndicatorColor_Element = new();
public global::System.Single LongPressTime { get => LongPressTime_Element.Data; set => LongPressTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LongPressTime_Element = new();
public global::FrooxEngine.RingMesh _longPressIndicator { get => _longPressIndicator_Element.Data; set => _longPressIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RingMesh>, global::FrooxEngine.RingMesh> _longPressIndicator_Element = new();
public global::FrooxEngine.UnlitMaterial _longPressIndicatorMaterial { get => _longPressIndicatorMaterial_Element.Data; set => _longPressIndicatorMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _longPressIndicatorMaterial_Element = new();
public System.Uri _lastFetchedUrl { get => _lastFetchedUrl_Element.Data; set => _lastFetchedUrl_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> _lastFetchedUrl_Element = new();
public global::System.Boolean _isReadOnly { get => _isReadOnly_Element.Data; set => _isReadOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isReadOnly_Element = new();
public global::FrooxEngine.Slot _orbRoot { get => _orbRoot_Element.Data; set => _orbRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _orbRoot_Element = new();
public global::FrooxEngine.Slot _infoRoot { get => _infoRoot_Element.Data; set => _infoRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _infoRoot_Element = new();
public global::FrooxEngine.StaticTexture2D _thumbTex { get => _thumbTex_Element.Data; set => _thumbTex_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _thumbTex_Element = new();
public global::FrooxEngine.Projection360Material _thumbMaterial { get => _thumbMaterial_Element.Data; set => _thumbMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Projection360Material>, global::FrooxEngine.Projection360Material> _thumbMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _shellMaterial { get => _shellMaterial_Element.Data; set => _shellMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _shellMaterial_Element = new();
public global::FrooxEngine.TextRenderer _nameText { get => _nameText_Element.Data; set => _nameText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _nameText_Element = new();
public global::FrooxEngine.TextRenderer _creatorText { get => _creatorText_Element.Data; set => _creatorText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _creatorText_Element = new();
public global::FrooxEngine.TextRenderer _visitsText { get => _visitsText_Element.Data; set => _visitsText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _visitsText_Element = new();
public global::FrooxEngine.TextRenderer _usersText { get => _usersText_Element.Data; set => _usersText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _usersText_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _namePosition { get => _namePosition_Element.Data; set => _namePosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _namePosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _creatorPosition { get => _creatorPosition_Element.Data; set => _creatorPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _creatorPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visitsPosition { get => _visitsPosition_Element.Data; set => _visitsPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visitsPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _usersPosition { get => _usersPosition_Element.Data; set => _usersPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _usersPosition_Element = new();
public global::FrooxEngine.IField<global::System.String> _userCountText { get => _userCountText_Element.Data; set => _userCountText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _userCountText_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _sizeDrive { get => _sizeDrive_Element.Data; set => _sizeDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _sizeDrive_Element = new();
public global::FrooxEngine.Slot _iconSlot { get => _iconSlot_Element.Data; set => _iconSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _iconSlot_Element = new();
public global::FrooxEngine.StaticTexture2D _iconTexture { get => _iconTexture_Element.Data; set => _iconTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _iconTexture_Element = new();
public global::FrooxEngine.UnlitMaterial _iconMaterial { get => _iconMaterial_Element.Data; set => _iconMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _iconMaterial_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _iconPosition { get => _iconPosition_Element.Data; set => _iconPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _iconPosition_Element = new();
public global::FrooxEngine.NewWorldDialog _sessionStartDialog { get => _sessionStartDialog_Element.Data; set => _sessionStartDialog_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.NewWorldDialog>, global::FrooxEngine.NewWorldDialog> _sessionStartDialog_Element = new();
public global::System.Double _lastTouch { get => _lastTouch_Element.Data; set => _lastTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> _lastTouch_Element = new();
public global::System.Double _lastFlash { get => _lastFlash_Element.Data; set => _lastFlash_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> _lastFlash_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SessionStartingUser", SessionStartingUser_Element.Data.ToResoniteReference(context));
members.Add("URL", URL_Element.Data.ToResoniteLinkField());
members.Add("ActiveSessionURLs", new ResoniteLink.SyncList()
{
    Elements = ActiveSessionURLs.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("Visit", Visit_Element.Data.ToResoniteLinkField());
members.Add("ActiveUsers", ActiveUsers_Element.Data.ToResoniteLinkField());
members.Add("RecordStateUpdated", RecordStateUpdated_Element.Data.ToResoniteLinkField());
members.Add("IsPublic", IsPublic_Element.Data.ToResoniteLinkField());
members.Add("CanModify", CanModify_Element.Data.ToResoniteLinkField());
members.Add("LongPressIndicatorColor", LongPressIndicatorColor_Element.Data.ToResoniteLinkField());
members.Add("LongPressTime", LongPressTime_Element.Data.ToResoniteLinkField());
members.Add("_longPressIndicator", _longPressIndicator_Element.Data.ToResoniteReference(context));
members.Add("_longPressIndicatorMaterial", _longPressIndicatorMaterial_Element.Data.ToResoniteReference(context));
members.Add("_lastFetchedUrl", _lastFetchedUrl_Element.Data.ToResoniteLinkField());
members.Add("_isReadOnly", _isReadOnly_Element.Data.ToResoniteLinkField());
members.Add("_orbRoot", _orbRoot_Element.Data.ToResoniteReference(context));
members.Add("_infoRoot", _infoRoot_Element.Data.ToResoniteReference(context));
members.Add("_thumbTex", _thumbTex_Element.Data.ToResoniteReference(context));
members.Add("_thumbMaterial", _thumbMaterial_Element.Data.ToResoniteReference(context));
members.Add("_shellMaterial", _shellMaterial_Element.Data.ToResoniteReference(context));
members.Add("_nameText", _nameText_Element.Data.ToResoniteReference(context));
members.Add("_creatorText", _creatorText_Element.Data.ToResoniteReference(context));
members.Add("_visitsText", _visitsText_Element.Data.ToResoniteReference(context));
members.Add("_usersText", _usersText_Element.Data.ToResoniteReference(context));
members.Add("_namePosition", _namePosition_Element.Data.ToResoniteReference(context));
members.Add("_creatorPosition", _creatorPosition_Element.Data.ToResoniteReference(context));
members.Add("_visitsPosition", _visitsPosition_Element.Data.ToResoniteReference(context));
members.Add("_usersPosition", _usersPosition_Element.Data.ToResoniteReference(context));
members.Add("_userCountText", _userCountText_Element.Data.ToResoniteReference(context));
members.Add("_sizeDrive", _sizeDrive_Element.Data.ToResoniteReference(context));
members.Add("_iconSlot", _iconSlot_Element.Data.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture_Element.Data.ToResoniteReference(context));
members.Add("_iconMaterial", _iconMaterial_Element.Data.ToResoniteReference(context));
members.Add("_iconPosition", _iconPosition_Element.Data.ToResoniteReference(context));
members.Add("_sessionStartDialog", _sessionStartDialog_Element.Data.ToResoniteReference(context));
members.Add("_lastTouch", _lastTouch_Element.Data.ToResoniteLinkField());
members.Add("_lastFlash", _lastFlash_Element.Data.ToResoniteLinkField());
}

}
}
