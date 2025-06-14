using Content.Shared._Funkystation.Payouts.Components;
using Content.Shared.Access.Systems;
using Robust.Client.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Client._Funkystation.Payouts;

public sealed class PayoutsConsoleBoundUserinterface : BoundUserInterface
{
    [Dependency] private readonly IPrototypeManager _proto = default!;
    [Dependency] private readonly IRobustRandom _random = default!;
    [Dependency] private readonly IPlayerManager _playerManager = default!;
    private readonly AccessReaderSystem _accessReader;

    public PayoutsConsoleBoundUserinterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
        _accessReader = EntMan.System<AccessReaderSystem>();
    }

    protected override void Open()
    {
        base.Open();

        var comp = EntMan.GetComponent<PayoutsConsoleComponent>(Owner);

    }


}
