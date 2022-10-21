using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class GerarLista
    {
        public List<Marketing> GerarListaMarketing()
        {
            var lista = new List<Marketing>();
            var fileName = @"C:\bulk\file3.txt";

            using var sr = new StreamReader(fileName);

            string line = sr.ReadLine();

            var culture = CultureInfo.InvariantCulture;

            while ((line = sr.ReadLine()) != null)
            {
                lista.Add(new Marketing()
                {
                    AssetID = line.Split(",")[0],
                    OfferID = Convert.ToInt16(line.Split(",")[1]),
                    TypeID = Convert.ToInt32(line.Split(",")[2]),
                    Valor = Convert.ToDecimal(line.Split(",")[3], culture)
                });
            }
            return lista;
        }

        public async Task<List<Marketing>> Lista2()
        {
            var lista = new List<Marketing>();
            var directoryInfo = new DirectoryInfo(@"C:\bulk\");
            var files = directoryInfo.GetFiles("file0.txt");
            var lines = await File.ReadAllLinesAsync(files[0].FullName);
            var culture = CultureInfo.InvariantCulture;

            foreach (var item in lines.Skip(1).ToArray())
            {
                var splitLine = item.Split(",");
                lista.Add(new Marketing()
                {
                    AssetID = splitLine[0],
                    OfferID = Convert.ToInt16(splitLine[1]),
                    TypeID = Convert.ToInt32(splitLine[2]),
                    Valor = Convert.ToDecimal(splitLine[3], culture)
                });
            }

            return lista;
        }
    }
}
