using Content.Shared.Radio;
using Content.Shared.StationRecords;

namespace Content.Shared._Funkystation.Payouts.Components;

/// <summary>
/// A component for Payout Console storing an active station record key and a currently applied filter
/// </summary>
[RegisterComponent]
[Access(typeof(SharedScripSystem))]
public sealed partial class PayoutsConsoleComponent : Component
{
    /// <summary>
    /// Currently active station record key.
    /// There is no station parameter as the console uses the current station.
    /// </summary>
    [DataField]
    public uint? ActiveKey;

    /// <summary>
    /// Currently applied filter.
    /// </summary>
    [DataField]
    public StationRecordsFilter? Filter;

    /// <summary>
    /// Channel to send messages to when someone's status gets changed.
    /// </summary>
    // [DataField]
    // public ProtoId<RadioChannelPrototype> PayoutsChannel = "";
}
