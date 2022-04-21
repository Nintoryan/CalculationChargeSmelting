using CalculationChargeSmelting.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculationChargeSmelting
{

    [Serializable]
    public class Materials
    {
        public List<Material> materials = new List<Material>();
        public Material GetByName(string name)
        {
            return materials.First(m => m.ToString() == name);
        }
    }
    [Serializable]
    public class Material
    {
        public Dictionary<ChemicalElement, int> Compound {get;private set;} = new Dictionary<ChemicalElement, int>();
        private int _sumPersent => Compound.Sum(c => c.Value);
        public string Name;

        public Material(string name, Dictionary<ChemicalElement, int> chemicalElements = null)
        {
            if(chemicalElements != null)
                Compound = chemicalElements;
            Name = name;
        }
        public bool AddElement(ChemicalElement chemicalElement, int persent)
        {
            if (_sumPersent + persent > 100)
                return false;
            if (Compound.ContainsKey(chemicalElement))
            {
                Compound[chemicalElement] += persent;
                return true;
            }
            Compound.Add(chemicalElement, persent);
            return true;
        }
        public bool RemoveElement(ChemicalElement chemicalElement)
        {
            if (Compound.ContainsKey(chemicalElement))
            {
                Compound.Remove(chemicalElement);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Modificate(List<ChemicalElement> mainElemets)
        {
            for(int i = 0; i < mainElemets.Count; i++)
            {
                if (!Compound.ContainsKey(mainElemets[i]))
                {
                    Compound.Add(mainElemets[i],0);
                }
            }
            foreach(var e in Compound.Keys)
            {
                if (!mainElemets.Contains(e))
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            var s = $"{Name}\n";
            foreach(var e in Compound)
            {
                s += $"• {e} \n";
            }
            return s;
        }
    }
}
