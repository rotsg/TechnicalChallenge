using Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Data> Get()
        {
            List<Data> data = new List<Data>();
            var options = new CsvOptions { AllowNewLineInEnclosedFieldValues = true };
            string csv = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DB\looptrack.csv"));
            if (!String.IsNullOrEmpty(csv))
            {
                foreach (var line in CsvReader.ReadFromText(csv, options))
                {
                    data.Add(new Data()
                    {
                        SerialNumber = line["SerialNumber"],
                        Enterprise = line["Enterprise"],
                        Solicitude = line["Solicitude"],
                        User = line["User"],
                        Km = line["Km"],
                        Price = line["Price"]
                    });
                }
            }
            return data;
        }

    }
}
