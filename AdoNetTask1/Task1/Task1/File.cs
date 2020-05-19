using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace Task1
{
    class File
    {
        public Round Reader(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                char[] definitions = { ',', ' ', '.', ':', '\n' };
                String[] temp = sr.ReadToEnd().Split(definitions, StringSplitOptions.RemoveEmptyEntries);
                int requiredCountOfSymbols = 3; 
                if (temp.Length != requiredCountOfSymbols)
                {
                    throw new Exception("Count of symbols is not correct");
                }                
                if (float.TryParse(temp[0], out float x))
                {
                    if (float.TryParse(temp[1], out float y))
                    {
                        if (float.TryParse(temp[2], out float radius))
                        {
                            if (radius > 0)
                            {
                                return new Round(x, y, radius);
                            }
                            else
                            {
                                throw new ArgumentException("Radius should be more than 0");
                            }
                        }
                    }
                }
            }
            throw new ArgumentException("Data is not correct");
        }
    }
}
