using System.Management;
using System.Runtime.Versioning;
using BetteryInfo;

namespace BatteryInfo.Services.Windows;

[SupportedOSPlatform("windows")]
public class InformationService : IInformationService
{
    public static void GetInformation()
    {
        var batteryInfo = new Battery();

        var properties = new ManagementObjectSearcher("SELECT * FROM Win32_Battery").Get().Cast<ManagementObject>().First().Properties;
        // Add properties to BatteryInfo object
        foreach (var property in properties)
        {
            var propertyName = property.Name;
            var propertyValue = property.Value;

            // Set the property value in BatteryInfo object
            var propertyInfo = typeof(Battery).GetProperty(propertyName);
            propertyInfo!.SetValue(batteryInfo, propertyValue);
        }

        Console.WriteLine(batteryInfo.ToString());
    }
}