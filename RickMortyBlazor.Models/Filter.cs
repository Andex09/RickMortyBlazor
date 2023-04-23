using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMortyBlazor.Models
{
    public class Filter
    {
        public string? Name { get; set; }
        public Status? Status { get; set; }

    }

    public enum Status
    {
        Alive,
        Dead,
        Unknownd
    }

}
