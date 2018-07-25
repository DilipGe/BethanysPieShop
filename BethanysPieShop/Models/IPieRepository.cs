using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        //IEnumerable<Pie> PiesOfWeek { get; }

        //Pie GetPieByID(int pieId);
    }
}
