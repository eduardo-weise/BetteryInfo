using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryInfo.Services
{
    public interface IInformationService
    {
        /// <summary>
        /// Busca as informações da bateria
        /// </summary>
        static abstract void GetInformation();
    }
}
