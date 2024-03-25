namespace BetteryInfo.Enums;

public enum PowerManagementCapabilities : ushort
{
    /// <summary>
    /// The power management capabilities of the battery are unknown.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Power management features are not supported by the battery or system.
    /// </summary>
    NotSupported = 1,

    /// <summary>
    /// Power management features are currently disabled.
    /// </summary>
    Disabled = 2,

    /// <summary>
    /// Power management features are enabled.
    /// </summary>
    Enabled = 3,

    /// <summary>
    /// The system can automatically enter power saving modes based on specific conditions.
    /// </summary>
    PowerSavingModesEnteredAutomatically = 4,

    /// <summary>
    /// The system's power state can be set programmatically (e.g., through sleep or hibernate modes).
    /// </summary>
    PowerStateSettable = 5,

    /// <summary>
    /// The battery supports power cycling (repeatedly discharging and charging) without damage.
    /// </summary>
    PowerCyclingSupported = 6,

    /// <summary>
    /// The system supports timed wake events where the system can be woken up from sleep at a specific time.
    /// </summary>
    TimedWakeSupported = 7,
}
