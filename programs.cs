using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Pc_parts
{   


        
    internal class programs
    {
        adatbazis adatbazis;

        private adatbazis data;
        public void fill(adatbazis adatbazis)
        {
            data = adatbazis;


            if (data.orderible_ware.Count() == 0)
            {
                import();
            }
        }
        public void import()
        {
            using (System.IO.StreamReader read = new StreamReader("pcparts.txt"))
            {
                while (!read.EndOfStream)
                {
                    string[] temp = read.ReadLine().Split(";");
                    data.orderible_ware.Add(new products { Type = temp[0],Name = temp[1], Price = Convert.ToInt32(temp[3]) });
                }
            }
        }
            public void txtdatabase()
        {
            string folder = "temp.txt";
            if (File.Exists(folder))
            {
            }
            else
            {
                using (StreamWriter streamWriter = File.CreateText(folder)) ;

            } 
        }

    }
    
}
