using BetteryInfo.Enums;
using System.Text;

namespace BetteryInfo;

public class Battery
{
    /// <summary>
    /// Indica a disponibilidade e o status da bateria.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - Running/Full Power (3): A bateria está funcionando e com carga completa.
    /// - Unknown (2): O status da bateria é desconhecido.
    /// - Outros valores são documentados na MSDN.
    /// </remarks>
    public Availability Availability { get; set; }

    /// <summary>
    /// Tempo necessário para carregar completamente a bateria (não suportado).
    /// </summary>
    /// <remarks>
    /// Esta propriedade é obsoleta e não deve ser usada.
    /// </remarks>
    public uint BatteryRechargeTime { get; set; }

    /// <summary>
    /// Indica o status da bateria.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - Discharging (1): A bateria está descarregando.
    /// - Unknown (2): O status da bateria é desconhecido.
    /// - Fully Charged (3): A bateria está completamente carregada.
    /// - Outros valores são documentados na MSDN.
    /// </remarks>
    public BatteryStatus BatteryStatus { get; set; }

    // <summary>
    /// Uma breve descrição da bateria.
    /// </summary>
    public string Caption { get; set; }

    /// <summary>
    /// Tipo de química da bateria utilizada.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - Lithium-ion (6): Bateria de íon de lítio.
    /// - Unknown (2): O tipo de química da bateria é desconhecido.
    /// - Outros valores são documentados na MSDN.
    /// </remarks>
    public Chemistry Chemistry { get; set; }

    /// <summary>
    /// Código de erro do Gerenciador de Configuração do Windows (se houver).
    /// </summary>
    public uint ConfigManagerErrorCode { get; set; }

    /// <summary>
    /// True se uma configuração definida pelo usuário está sendo usada para a bateria.
    /// </summary>
    public bool ConfigManagerUserConfig { get; set; }

    /// <summary>
    /// Nome da primeira classe na hierarquia de herança usada para criar esta instância.
    /// </summary>
    public string CreationClassName { get; set; }

    /// <summary>
    /// Uma descrição detalhada da bateria.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Capacidade de design da bateria em miliwatt-hora.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Miliwatt-hora (mWh)
    //// Exemplo: "DesignCapacity: 50000 mWh"
    /// </remarks>
    public uint DesignCapacity { get; set; }

    /// <summary>
    /// Tensão de design da bateria em milivolts.
    /// </summary>
    public ulong DesignVoltage { get; set; }

    /// <summary>
    /// Identificador único da bateria.
    /// </summary>
    public string DeviceID { get; set; }

    /// <summary>
    /// True se o erro previamente reportado (se houver) foi corrigido.
    /// </summary>
    public bool ErrorCleared { get; set; }

    /// <summary>
    /// Descrição do erro reportado na propriedade LastErrorCode (se houver).
    /// </summary>
    public string ErrorDescription { get; set; }

    /// <summary>
    /// Porcentagem estimada da carga completa restante.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Porcentagem (%)
    //// Exemplo: "EstimatedChargeRemaining: 80%"
    /// </remarks>
    public ushort EstimatedChargeRemaining { get; set; }

    /// <summary>
    /// Tempo estimado em minutos restante na bateria sob as condições de carga atuais.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Minutos (min)
    //// Exemplo: "EstimatedRunTime: 240 min"
    /// </remarks>
    public uint EstimatedRunTime { get; set; }

    /// <summary>
    /// Tempo de vida útil esperado da bateria em minutos, assumindo que a bateria esteja completamente carregada.
    /// </summary>
    /// <remarks>
    /// Esta propriedade é obsoleta e não deve ser usada.
    /// </remarks>
    public uint ExpectedBatteryLife { get; set; }

    /// <summary>
    /// Vida útil estimada da bateria em minutos assumindo uma carga completa.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Minutos (min)
    //// Exemplo: "ExpectedLife: 600 min"
    /// </remarks>
    public uint ExpectedLife { get; set; }

    /// <summary>
    /// Capacidade de carga total da bateria em miliwatt-hora.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Miliwatt-hora (mWh)
    //// Exemplo: "FullChargeCapacity: 45000 mWh"
    /// </remarks>
    public uint FullChargeCapacity { get; set; }

    // <summary>
    /// Data e hora em que a bateria foi instalada.
    /// </summary>
    public DateTime InstallDate { get; set; }

    /// <summary>
    /// Último código de erro reportado pela bateria.
    /// </summary>
    public uint LastErrorCode { get; set; }

    /// <summary>
    /// Tempo máximo necessário para carregar completamente a bateria em minutos.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Minutos (min)
    //// Exemplo: "MaxRechargeTime: 120 min"
    /// </remarks>
    public uint MaxRechargeTime { get; set; }

    /// <summary>
    /// Nome da bateria.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Identificador de dispositivo Plug and Play do Windows da bateria.
    /// </summary>
    /// <remarks>
    /// Exemplo: "*PNP030b"
    /// </remarks>
    public string PNPDeviceID { get; set; }

    /// <summary>
    /// Indica os recursos específicos de gerenciamento de energia da bateria.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - Unknown (0): Desconhecido.
    /// - Not Supported (1): Não suportado.
    /// - Disabled (2): Desativado.
    /// - Outros valores são documentados na MSDN.
    /// </remarks>
    public ushort[] PowerManagementCapabilities { get; set; }

    /// <summary>
    /// True se a bateria suporta recursos de gerenciamento de energia.
    /// </summary>
    public bool PowerManagementSupported { get; set; }

    /// <summary>
    /// Número da versão da Especificação de Dados suportada pela bateria (se aplicável).
    /// </summary>
    public string SmartBatteryVersion { get; set; }

    /// <summary>
    /// Status atual da bateria.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - OK: A bateria está funcionando corretamente.
    /// - Error: A bateria está com um erro.
    /// - Degraded: A bateria está degradada.
    /// - Outros valores são documentados na MSDN.
    /// </remarks>
    public string Status { get; set; }

    /// <summary>
    /// Estado da bateria conforme definido pelo padrão CIM.
    /// </summary>
    /// <remarks>
    /// Os valores possíveis são:
    /// - Unknown (2): Desconhecido.
    /// - Enabled (3): Ativado.
    /// - Disabled (4): Desativado.
    /// - Not Applicable (5): Não aplicável.
    /// </remarks>
    public StatusInfo StatusInfo { get; set; }

    /// <summary>
    /// Nome da classe que criou a instância no sistema.
    /// </summary>
    public string SystemCreationClassName { get; set; }

    /// <summary>
    /// Nome do sistema.
    /// </summary>
    public string SystemName { get; set; }

    /// <summary>
    /// Tempo decorrido em segundos desde que o sistema foi ligado pela última vez na bateria.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Segundos (s)
    //// Exemplo: "TimeOnBattery: 7200 s"
    /// </remarks>
    public uint TimeOnBattery { get; set; }

    /// <summary>
    /// Tempo restante estimado para carregar completamente a bateria em minutos, na taxa de carga e uso atuais.
    /// </summary>
    /// <remarks>
    //// Unidade de Medida: Minutos (min)
    //// Exemplo: "TimeToFullCharge: 60 min"
    /// </remarks>
    public uint TimeToFullCharge { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        // Iterate through all properties and add them to the string
        foreach (var property in GetType().GetProperties())
        {
            var propertyName = property.Name;
            var propertyValue = property.GetValue(this);

            if (propertyName == nameof(PowerManagementCapabilities))
            {
                for (int i = 0; i < PowerManagementCapabilities.Length; i++)
                {
                    sb.Append($"{propertyName}: [{GetEnumDescription<PowerManagementCapabilities>(PowerManagementCapabilities[i])}");

                    if (i < PowerManagementCapabilities.Length -1)
                    {
                        sb.Append(" ,");
                    }
                }

                sb.AppendLine("]");
                continue;
            }

            sb.AppendLine($"{propertyName}: {propertyValue}");
        }

        return sb.ToString();
    }

    private static string? GetEnumDescription<T>(ushort code)
    {
        return Enum.GetName(typeof(T), code);
    }
}