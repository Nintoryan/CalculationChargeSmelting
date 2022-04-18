using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CalculationChargeSmelting
{
    public static class MaterialManager
    {
        public static Materials Current = new Materials();
        private static string path;
        public static void Load()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Выберите файл материалов";
            fileDialog.ShowDialog();
            path = fileDialog.FileName;
            Current = JsonConvert.DeserializeObject<Materials>(File.ReadAllText(path));
        }
        public static void LoadInternal()
        {
            Current = JsonConvert.DeserializeObject<Materials>(File.ReadAllText(path));
        }
        public static void SaveInternal()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(Current));
        }
    }

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
        public List<ChemicalElement> chemicalElements = new List<ChemicalElement>();
        public float UgarPersent;
        public string Name;
        public override string ToString()
        {
            var s = $"{Name}\n";
            foreach(var e in chemicalElements)
            {
                s += $"-{e} \n";
            }
            return s;
        }
    }

    public static class ChemicalElements
    {
        public static ChemicalElement[] chemicalElements = new ChemicalElement[]
        {
            new ChemicalElement("Be",4),
            new ChemicalElement("C",6),
            new ChemicalElement("Mg",12),
            new ChemicalElement("Al",13),
            new ChemicalElement("Si",14),
            new ChemicalElement("P",15),
            new ChemicalElement("S",16),
            new ChemicalElement("Ti",22),
            new ChemicalElement("Cr",24),
            new ChemicalElement("Mn",25),
            new ChemicalElement("Fe",26),
            new ChemicalElement("Ni",28),
            new ChemicalElement("Cu",29),
            new ChemicalElement("Zn",30),
            new ChemicalElement("Sn",50),
            new ChemicalElement("Pb",82),
    };
        public static ChemicalElement GetByName(string name)
        {
            return chemicalElements.First(c => c.Name == name);
        }
    }
    [Serializable]
    public class ChemicalElement
    {
        public string Name { get; private set;}
        public int Number { get; private set;}

        public decimal Persent;

        public decimal Ugar;
        public ChemicalElement(string name, int number, decimal persent = 0,decimal ugar= 0)
        {
            Name = name;
            Number = number;
            Persent = persent;
            Ugar = ugar;
        }
        public override string ToString()
        {
            return $"{Name} - {Persent:0.0}% - Угар={Ugar}%";
        }
    }
}
