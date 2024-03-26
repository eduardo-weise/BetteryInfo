namespace BetteryInfo.Enums;

public enum BatteryStatus : ushort
{
    /// <summary>
    /// The battery is currently being charged.
    /// </summary>
    Discharging = 1,

    /// <summary>
    /// The battery is discharging (providing power to the system).
    /// </summary>
    Charging = 2,

    /// <summary>
    /// The Status property does not apply to this context, 
    /// possibly because a battery is not present.
    /// </summary>
    NotApplicable = 3,

    /// <summary>
    /// The battery has some charge remaining, but is not fully charged.
    /// </summary>
    PartiallyCharged = 4,

    /// <summary>
    /// The battery is fully charged and ready to provide power to the system.
    /// </summary>
    FullCharged = 5,

    /// <summary>
    /// The state of the battery is unknown.
    /// </summary>
    Unknown = 6,

    /// <summary>
    /// The battery is depleted and can no longer provide power to the system.
    /// </summary>
    Dead = 7,

    /// <summary>
    /// An error has been detected with the battery. 
    /// Consult system logs or diagnostics for more information.
    /// </summary>
    Error = 8,
}
