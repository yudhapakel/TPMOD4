using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4
{
    internal class KodePos
    {
        private Dictionary<string, string> kodePosTable = new Dictionary<string, string>()
    {
        { "Jakarta", "10110" },
        { "Bandung", "40111" },
        { "Surabaya", "60111" },
        { "Yogyakarta", "55111" }
    };

        public string GetKodePos(string kota)
        {
            if (kodePosTable.ContainsKey(kota))
            {
                return kodePosTable[kota];
            }
            return "Kode pos tidak ditemukan";
        }
    }
}
