namespace BetteryInfo.Enums;

public enum StatusInfo : ushort
{
    /// <summary>
    /// The state of the logical device (battery) is not classified by the standard categories. 
    /// This could be due to:
    ///   * Unsupported battery technology.
    ///   * Temporary communication issue between the battery and system.
    ///   * Hardware malfunction.
    /// If possible, consult system logs or diagnostics for a more detailed status.
    /// </summary>
    Other = 1,

    /// <summary>
    /// The state of the logical device is unknown.
    /// </summary>
    Unknown = 2,

    /// <summary>
    /// The logical device is enabled.
    /// </summary>
    Enabled = 3,

    /// <summary>
    /// The logical device is disabled.
    /// </summary>
    Disabled = 4,

    /// <summary>
    /// The StatusInfo property does not apply to this logical device.
    /// </summary>
    NotApplicable = 5,
}
