using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndianCensusAnalyzer.CensusAnalyser;

namespace Day17_Practice
{
    internal class CensusAnalyserBase
    {
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath,
            string dataHeaders)
        {
            dataMap = new CsvAdaptorFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
