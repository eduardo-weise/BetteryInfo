namespace BetteryInfo.Enums;

public enum Chemistry : ushort
{
    /// <summary>
    /// The chemistry of the battery is unknown.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// The battery uses Lithium-ion (Li-ion) chemistry, a common type known for high energy density and long lifespan.
    /// </summary>
    LiIon = 4,

    /// <summary>
    /// The battery uses Lithium-polymer (Li-poly) chemistry, a variation of Li-ion offering flexibility in design but potentially lower lifespan.
    /// </summary>
    LiPolymer = 6,

    /// <summary>
    /// The battery uses Nickel-metal hydride (NiMH) chemistry, a rechargeable battery type offering good capacity and environmental friendliness, but with lower energy density than Li-ion.
    /// </summary>
    NiMH = 8,

    /// <summary>
    /// The battery uses Nickel-cadmium (NiCd) chemistry, a rechargeable battery type with lower capacity and environmental concerns compared to NiMH.
    /// </summary>
    NiCd = 9,

    /// <summary>
    /// The battery uses Lead-acid chemistry, a mature and widely used technology for automotive and deep-cycle applications, but with lower energy density and shorter lifespan compared to Li-ion.
    /// </summary>
    LeadAcid = 10,

    /// <summary>
    /// The battery uses Lithium primary chemistry, indicating a non-rechargeable Lithium-based battery.
    /// </summary>
    LitioPrimary = 11,

    /// <summary>
    /// The battery uses Nickel-iron (NiFe) chemistry, a less common rechargeable battery type known for long lifespan and safety, but with lower energy density.
    /// </summary>
    NiFe = 12,

    /// <summary>
    /// The chemistry of the battery falls outside the defined categories.
    /// </summary>
    Other = 13,
}
