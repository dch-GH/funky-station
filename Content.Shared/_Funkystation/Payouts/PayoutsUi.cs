using Content.Shared.StationRecords;
using Robust.Shared.Serialization;

namespace Content.Shared._Funkystation.Payouts;

[Serializable, NetSerializable]
public enum PayoutsConsoleKey : byte
{
    Key
}

/// <summary>
/// </summary>
[Serializable, NetSerializable]
public sealed class PayoutsConsoleState : BoundUserInterfaceState
{
    public PayoutsConsoleState(Dictionary<uint, string>? recordListing, StationRecordsFilter? newFilter)
    {
    }

    /// <summary>
    /// Default state for opening the console
    /// </summary>
    public PayoutsConsoleState() : this(null, null)
    {
    }
}

