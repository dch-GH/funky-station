using Robust.Shared.Prototypes;

namespace Content.Shared._Funkystation.Payouts;

[Serializable, DataDefinition]
[Prototype("paymentSalary")]
public sealed partial class PaymentSalaryPrototype : IPrototype
{
    [IdDataField] public string ID { get; private set; } = default!;

    /// <summary>
    /// The roles that has this applied to their salary.
    /// </summary>
    [DataField("roles")] public List<string> Roles = new List<string>();

    [DataField("salary")] public int Salary = 0;
}
