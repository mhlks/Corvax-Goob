using Content.Shared.Tag;
using Robust.Shared.Prototypes;

namespace Content.Shared._SS220.Hookah.Components;

[RegisterComponent]
public sealed partial class SmokingFuelComponent : Component
{
    public const string TobaccoSlotId = "tobacco_slot";

    [DataField]
    public int TobaccoPuffs;

    [DataField]
    public ProtoId<TagPrototype> TobaccoTag = "Tobacco";

    [DataField]
    public int PuffsPerPack = 20;

    public float CoalTime;
}
