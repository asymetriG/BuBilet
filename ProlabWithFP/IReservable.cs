using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public interface IReservable
    {
        void confirmReservation(Transport ts, int seat, bool reversed, List<KeyValuePair<List<string>, List<int>>> seatsToUpdate);
    }
}
