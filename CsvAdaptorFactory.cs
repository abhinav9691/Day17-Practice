using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Practice
{
    internal class CsvAdaptorFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.
           Country country, string csvFilePath,
          string dataheaders)
        {
            if (string.IsNullOrEmpty(csvFilePath))
            {
                throw new ArgumentException($"'{nameof(csvFilePath)}' cannot be null or empty.", nameof(csvFilePath));
            }

            if (string.IsNullOrEmpty(dataheaders))
            {
                throw new ArgumentException($"'{nameof(dataheaders)}' cannot be null or empty.", nameof(dataheaders));
            }

            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataheaders);
                default:
                    return new Dictionary<string, CensusDTO>();
            }
        }
    }
}
