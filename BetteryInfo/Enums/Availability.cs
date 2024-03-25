namespace BetteryInfo.Enums;

public enum Availability : ushort
{
    /// <summary>
    /// The availability of the battery falls outside the defined categories.
    /// </summary>
    Other = 1,

    /// <summary>
    /// The availability of the battery is unknown.
    /// </summary>
    Unknown = 2,

    /// <summary>
    /// The battery is available and functioning normally.
    /// </summary>
    Available = 3,

    /// <summary>
    /// A warning condition exists with the battery, requiring attention.
    /// </summary>
    Warning = 4,

    /// <summary>
    /// The battery is undergoing diagnostics or testing.
    /// </summary>
    InTest = 5,

    /// <summary>
    /// The Availability property does not apply to this context, 
    /// possibly because a battery is not present.
    /// </summary>
    NotApplicable = 6,

    /// <summary>
    /// The system is powered off and the battery is not in use.
    /// </summary>
    PowerOff = 7,

    /// <summary>
    /// The system is not connected to an external power source and is relying on the battery.
    /// </summary>
    OffLine = 8,

    /// <summary>
    /// The battery is not currently in use (unclear if available or unavailable).
    /// </summary>
    OffDuty = 9,

    /// <summary>
    /// The battery's capacity or performance is degraded.
    /// </summary>
    Degraded = 10,

    /// <summary>
    /// The battery is not physically installed in the system.
    /// </summary>
    NotInstalled = 11,

    /// <summary>
    /// An error occurred during battery installation.
    /// </summary>
    InstallError = 12,

    /// <summary>
    /// The power saving mode is unknown.
    /// </summary>
    PowerSaveUnknown = 13,

    /// <summary>
    /// The system is in a low power mode to conserve battery power.
    /// </summary>
    PowerSaveLowPowerMode = 14,

    /// <summary>
    /// The system is in standby mode, potentially using battery power.
    /// </summary>
    PowerSaveStandby = 15,

    /// <summary>
    /// The system is undergoing a power cycle (restart).
    /// </summary>
    PowerCycle = 16,

    /// <summary>
    /// A power saving warning is present, indicating potential battery concerns.
    /// </summary>
    PowerSaveWarning = 17,

    /// <summary>
    /// The operation or process involving the battery is paused.
    /// </summary>
    Paused = 18,

    /// <summary>
    /// The battery is not ready for use, potentially due to charging or initialization.
    /// </summary>
    NotReady = 19,

    /// <summary>
    /// The battery is not properly configured for use.
    /// </summary>
    NotConfigured = 20,

    /// <summary>
    /// The battery is in a quiescent state, meaning it is in a low-power mode with minimal activity.
    /// </summary>
    Quiesced = 21,
}
