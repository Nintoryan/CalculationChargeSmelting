using Newtonsoft.Json;
using System.IO;

namespace CalculationChargeSmelting
{
    public static class MaterialManager
    {
        private static Materials _current;
        private static string path = "D:/учёба/4курс/ВКР/материалы.txt";
        public static Materials Current
        {
            get
            {
                if (_current == null)
                {
                    _current = LoadInternal();
                }
                return _current;
            }
            set { _current = value; }
        }
        private static Materials LoadInternal()
        {
            var materials = JsonConvert.DeserializeObject<Materials>(File.ReadAllText(path));
            if (materials == null)
            {
                materials = new Materials();
            }
            return materials;
        }
        public static void Save()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(Current));
        }
        public static void Load()
        {
            var materials = JsonConvert.DeserializeObject<Materials>(File.ReadAllText(path));
            if (materials != null)
            {
                Current = materials;
            }
        }
    }
}
