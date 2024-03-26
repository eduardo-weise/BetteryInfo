using Windows = BatteryInfo.Services.Windows.InformationService;
using Linux = BatteryInfo.Services.Linux.InformationService;

if (OperatingSystem.IsWindows())
    Windows.GetInformation();

if (OperatingSystem.IsLinux())
    Linux.GetInformation();

// Pausa para o usuário
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();