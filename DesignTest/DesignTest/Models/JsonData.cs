using System;
using System.IO;
using System.Text.Json;

namespace DesignTest.Models
{
    public static class JsonData
    {
        private static string _fileName = "data.json";
        private static int _baseValue = 50;
        public static int CostKm { get; }

        static JsonData()
        {
            if (!File.Exists(_fileName))
            {
                CostKm = _baseValue;
                return;
            }

            string jsonString = File.ReadAllText(_fileName);

            if (String.IsNullOrEmpty(jsonString))
            {
                CostKm = _baseValue;
                return;
            }

            int intJsonData = JsonSerializer.Deserialize<Int32>(jsonString);
            CostKm = intJsonData <= 0 ? _baseValue : intJsonData;
        }

        public static void WriteJsonKmCostData()
        {
            const int costKm = 666;
            string jsonString = JsonSerializer.Serialize(costKm);
            File.WriteAllText(_fileName, jsonString);
        }
    }
}
