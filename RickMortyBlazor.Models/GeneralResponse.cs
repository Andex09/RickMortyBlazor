using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMortyBlazor.Models
{
    public class GeneralResponse<T>
    {
        public Info Info { get; set; }
        public List<T> Results { get; set; }
    }
}
