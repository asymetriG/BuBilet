using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public interface IProfitable
    {
        Bus searchBus(string busName);
        Airplane searchAirplane(string airplaneName);
        Train searchTrain(string trainName);
        void calculateProfit(out int dailyCost, out int weeklyCost, out int totalEarnings, out int totalProfit);
    }
}
