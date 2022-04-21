using System;
using System.Linq;

namespace CalculationChargeSmelting.Scripts
{
    public static class ChemicalElements
    {
        public static ChemicalElement[] chemicalElements = new ChemicalElement[]
        {
            ChemicalElement.Be,
            ChemicalElement.C,            
            ChemicalElement.Mg,
            ChemicalElement.Al,
            ChemicalElement.Si,
            ChemicalElement.P,
            ChemicalElement.S,
            ChemicalElement.Ti,
            ChemicalElement.Cr,
            ChemicalElement.Mn,
            ChemicalElement.Fe,
            ChemicalElement.Ni,
            ChemicalElement.Cu,
            ChemicalElement.Zn,
            ChemicalElement.Sn,
            ChemicalElement.Pb,
    };
        public static ChemicalElement GetByName(string name)
        {
            return chemicalElements.First(c => c.ToString() == name);
        }
    }
    [Serializable]
    public enum ChemicalElement
    {
        Be = 4,
        C = 6,
        Mg = 12,
        Al = 13,
        Si = 14,
        P = 15,
        S = 16,
        Ti = 22,
        Cr = 24,
        Mn = 25,
        Fe = 26,
        Ni = 28,
        Cu = 29,
        Zn = 30,
        Sn = 50,
        Pb = 82,
    }
}
