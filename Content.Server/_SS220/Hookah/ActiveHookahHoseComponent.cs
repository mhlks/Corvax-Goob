using System;

namespace Content.Server._SS220.Hookah;

[RegisterComponent]
public sealed partial class ActiveHookahHoseComponent : Component
{
    public TimeSpan Accum;
}
