using System.Runtime.Versioning;
using BetteryInfo;

namespace BatteryInfo.Services.Linux;

[SupportedOSPlatform("linux")]
public class InformationService : IInformationService
{
    public static void GetInformation()
    {
        string batteryPath = "/sys/class/power_supply/BAT0"; // Assuming first battery

        if (!Directory.Exists(batteryPath))
        {
            Console.WriteLine("Battery directory not found: {0}", batteryPath);
            return;
        }

        var batteryInfo = new Battery
        {
            Caption = "Bateria do Sistema",
            DeviceID = "BAT0" // Assuming first battery
        };

        // Read battery level
        string levelString = File.ReadAllText(Path.Combine(batteryPath, "capacity"));
        batteryInfo.EstimatedChargeRemaining = ushort.Parse(levelString.Trim());

        // Read battery status (charging/discharging/full)
        string statusString = File.ReadAllText(Path.Combine(batteryPath, "status"));
        //batteryInfo.BatteryStatus = statusString.Trim();

        // Availability (always assumed to be "Em Execução/Potência Total" on battery)
        //batteryInfo.Availability = "Em Execução/Potência Total";

        // Read additional information (if available)
        try
        {
            batteryInfo.FullChargeCapacity = uint.Parse(File.ReadAllText(Path.Combine(batteryPath, "full_charge_capacity")));
        }
        catch (Exception) { } // Ignore errors if file doesn't exist

        try
        {
            batteryInfo.Name = File.ReadAllText(Path.Combine(batteryPath, "name"));
        }
        catch (Exception) { } // Ignore errors if file doesn't exist

        // Similarly, try reading other files like:
        //  - "cycle_count"
        //  - "voltage_now"
        //  - "power_now"
        //  - etc.
    }
}