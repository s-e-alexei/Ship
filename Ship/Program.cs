using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double[]> st = new List<Double[]>();
        //(@"C:\\Users\\Alex\\source\\repos\\Ship\\Ship\\Ship\\MarineRepository\\Compartments\\Data\\CargoHold1.csv"))
        //:\Users\Alex\source\repos\Ship\Ship\Ship\Resource1.resx
        //C: \Users\USER\source\repos\Ship\Ship\MarineRepository\Compartments\Data
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Ship\\Ship\\MarineRepository\\Compartments\\Data\\CargoHold1.csv"))
                    st.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }
            List<Cargo> cargo = new List<Cargo>();
            foreach (Double[] item in st)
            {
                cargo.Add(new Cargo(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9]));
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(st[5][9]);
            //Console.Read();

            Console.WriteLine("Input vi:");
            double vi = 250;//Convert.ToDouble(Console.ReadLine());
            double xmin = 0, xmax = 33.36;
            //  for (int i = 0; i < cargo.Count; i++)
            //Console.WriteLine(st1[0]);

            for (int i = 0; i < cargo[i].X; i++)
            {
                if (cargo[i].Volume > vi)
                {
                    xmin = i - 1; //x1 = xmin
                    xmax = i; //x2 =  xmax  
                    break;
                }
            }
            int ymin = -1, ymax = -1;
            for (int k = 0; k < cargo.Count; k++)
            {
                if (cargo[k].Y > vi)
                {
                    ymin = k - 1; //y1 = ymin
                    ymax = k; //y2 =  ymax  
                    break;
                }
            }
            int zmin = -1, zmax = -1;
            for (int n = 0; n < cargo.Count; n++)
            {
                if (cargo[n].Z > vi)
                {
                    ymin = n - 1; //y1 = ymin
                    ymax = n; //y2 =  ymax  
                    break;
                }
            }
            int vmin = -1, vmax = -1;
            for (int j = 0; j < cargo.Count; j++)
            {
                //Console.WriteLine(st1[0]);

                if (cargo[j].Volume > vi)
                {
                    vmin = j - 1; //v1 = vmin
                    vmax = j; //v2 =  vmax  
                    break;
                }
            }



            Console.WriteLine(xmin + "   " + xmax);
            Console.WriteLine(ymin + "   " + ymax);
            Console.WriteLine(zmin + "   " + zmax);

            // int vmin = Cargo.[1].GetMinElement();
            // int minValue = numbers.Cast<int>().Max();

            double xi = Math.Abs((((xmax - xmin)) / (cargo[vmax].Volume - cargo[vmin].Volume)) * (vi - vmin) + xmax);
            double yi = Math.Abs(((ymax - ymin)) / (cargo[vmax].Volume - cargo[vmin].Volume) * (vi - vmin) + ymax);
            double zi = Math.Abs(((zmax - zmin)) / (cargo[vmax].Volume - cargo[vmin].Volume) * (vi - vmin) + zmax);
            //double y = ((cargo[x1].Y == cargo[x2].Y) ? cargo[x1].Y : Math.Abs((x - x1) * (cargo[x1].Y - cargo[x2].Y) / (x2 - x1)));
            Console.WriteLine(xi);
            Console.WriteLine(yi);
            Console.WriteLine(zi);
            Console.WriteLine(vmax);
            Console.WriteLine(vmin);
            Console.Read();

        }


        //double[,] v = new double[5, 2];
        //v[0, 0] = 0.1; v[0, 1] = 64.69;
        //v[1, 0] = 1.1; v[1, 1] = 1673;
        //v[2, 0] = 2.1; v[2, 1] = 3468;
        //v[3, 0] = 3.1; v[3, 1] = 5311;
        //v[4, 0] = 4.1; v[4, 1] = 7177;


        //delegate void UI


        //class MyEvent
        //{
        //    // Объявляем событие
        //    public event UI UserEvent;

        //    // Используем метод для запуска события
        //    public void OnUserEvent()
        //    {
        //        UserEvent();
        //    }
        //}

        //class UserInfo
        //{
        //    string uiName, uiFamily;
        //    int uiAge;

        //    public UserInfo(string Name, string Family, int Age)
        //    {
        //        this.Name = Name;
        //        this.Family = Family;
        //        this.Age = Age;
        //    }




    }
}