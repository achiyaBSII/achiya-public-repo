using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationSuggestion
{
    public class Io
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public DataPoint DataPoint { get; set; }
    }
}
