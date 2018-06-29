using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface INutritionStore
    {
        List<string> AddNutritions();
        List<string> AddBeverages();
    }
}
