using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WalutaLol
{
    internal record class Table
    (
        string table,
        string no,
        string effectiveDate,
        Rates[] rates
    );

    internal record class Rates
    (
        string currency,
        string code,
        double mid
    );
}
