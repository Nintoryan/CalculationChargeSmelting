using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationChargeSmelting
{
    class Calculator
    {
        public List<(Material, decimal)> CalculateShicht(List<Material> shichtMaterials, Material targetMat, decimal sumWeight)
        {
            //Потребное содержание элементов целевого сплава в шихте
            var A = new Dictionary<string, decimal>();
            foreach(var e in targetMat.chemicalElements)
            {
                A.Add(e.Name, e.Persent * 100 / (100 - e.Ugar));
            }
        }
    }
}
