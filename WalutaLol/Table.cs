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
        Rate[] rates
    );

    internal record class Rate
    (
        string currency,
        string code,
        double mid
    );
}
