
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MysterySettings
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MysterySettings")]
public partial class MysterySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MysterySettings>

{
    public global::FrooxEngine.MysterySettings.ResoniteDifficulty Difficulty { get => Difficulty_Element.Data; set => Difficulty_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MysterySettings.ResoniteDifficulty>, global::FrooxEngine.MysterySettings.ResoniteDifficulty> Difficulty_Element = new();
public global::System.Boolean Loooong { get => Loooong_Element.Data; set => Loooong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Loooong_Element = new();
public global::System.Boolean TheTruth { get => TheTruth_Element.Data; set => TheTruth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TheTruth_Element = new();
public global::System.Boolean MirrorMirrors { get => MirrorMirrors_Element.Data; set => MirrorMirrors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MirrorMirrors_Element = new();
public global::System.Boolean PhantomSense { get => PhantomSense_Element.Data; set => PhantomSense_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PhantomSense_Element = new();
public global::System.Single Expressiveness { get => Expressiveness_Element.Data; set => Expressiveness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Expressiveness_Element = new();
public global::System.Boolean Ghosts { get => Ghosts_Element.Data; set => Ghosts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Ghosts_Element = new();
public global::System.Boolean MoreFPS { get => MoreFPS_Element.Data; set => MoreFPS_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MoreFPS_Element = new();
public global::System.Boolean PreciousToggle { get => PreciousToggle_Element.Data; set => PreciousToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreciousToggle_Element = new();
public global::System.Boolean ToggleToggle { get => ToggleToggle_Element.Data; set => ToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggle { get => ToggleToggleToggle_Element.Data; set => ToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggleToggle { get => ToggleToggleToggleToggle_Element.Data; set => ToggleToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggleToggleToggle { get => ToggleToggleToggleToggleToggle_Element.Data; set => ToggleToggleToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggleToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggleToggleToggleToggle { get => ToggleToggleToggleToggleToggleToggle_Element.Data; set => ToggleToggleToggleToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggleToggleToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggleToggleToggleToggleToggle { get => ToggleToggleToggleToggleToggleToggleToggle_Element.Data; set => ToggleToggleToggleToggleToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggleToggleToggleToggleToggle_Element = new();
public global::System.Boolean ToggleToggleToggleToggleToggleToggleToggleToggle { get => ToggleToggleToggleToggleToggleToggleToggleToggle_Element.Data; set => ToggleToggleToggleToggleToggleToggleToggleToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ToggleToggleToggleToggleToggleToggleToggleToggle_Element = new();
public global::System.Nullable<global::System.DateTime> PreciousToggleStart { get => PreciousToggleStart_Element.Data; set => PreciousToggleStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> PreciousToggleStart_Element = new();
public global::System.Nullable<global::System.TimeSpan> PreciousToggleDuration { get => PreciousToggleDuration_Element.Data; set => PreciousToggleDuration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.TimeSpan>>, global::System.Nullable<global::System.TimeSpan>> PreciousToggleDuration_Element = new();
public global::System.String MysteriousMessage { get => MysteriousMessage_Element.Data; set => MysteriousMessage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> MysteriousMessage_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Difficulty", Difficulty_Element.ToLinkField(context));
members.Add("Loooong", Loooong_Element.ToLinkField(context));
members.Add("TheTruth", TheTruth_Element.ToLinkField(context));
members.Add("MirrorMirrors", MirrorMirrors_Element.ToLinkField(context));
members.Add("PhantomSense", PhantomSense_Element.ToLinkField(context));
members.Add("Expressiveness", Expressiveness_Element.ToLinkField(context));
members.Add("Ghosts", Ghosts_Element.ToLinkField(context));
members.Add("MoreFPS", MoreFPS_Element.ToLinkField(context));
members.Add("PreciousToggle", PreciousToggle_Element.ToLinkField(context));
members.Add("ToggleToggle", ToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggle", ToggleToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggleToggle", ToggleToggleToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggleToggleToggle", ToggleToggleToggleToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggleToggleToggleToggle", ToggleToggleToggleToggleToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggleToggleToggleToggleToggle", ToggleToggleToggleToggleToggleToggleToggle_Element.ToLinkField(context));
members.Add("ToggleToggleToggleToggleToggleToggleToggleToggle", ToggleToggleToggleToggleToggleToggleToggleToggle_Element.ToLinkField(context));
members.Add("PreciousToggleStart", PreciousToggleStart_Element.ToLinkField(context));
members.Add("PreciousToggleDuration", PreciousToggleDuration_Element.ToLinkField(context));
members.Add("MysteriousMessage", MysteriousMessage_Element.ToLinkField(context));
}

}
}
