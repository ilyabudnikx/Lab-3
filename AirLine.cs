using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class AirLine
    {
        private int id = 0;
        private string Destination = "";
        private short NumberOfAirline = 0;
        private int TypeAircraft = 0;
        private string Time = "";
        private string DaysOfWeek = "";
        private static int size = 0;
        private readonly uint AirId;

        public static void sizeoff()
        {
            Console.WriteLine("Количество объектов:" + size);
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string DestinationC
        {
            get { return this.Destination; }
            set { this.Destination = value; }
        }

        public short NumberOfAirlineC
        {
            get { return this.NumberOfAirline; }
            set { this.NumberOfAirline = value; }

        }

        public int TypeAircraftC
        {
            get { return this.TypeAircraft; }
            set { this.TypeAircraft = value; }

        }
        public string TimeC
        {
            get { return this.Time; }
            set { this.Time = value; }
        }

        public string DaysOfWeekC
        {
            get { return this.DaysOfWeek; }
            set { this.DaysOfWeek = value; }
        }
        public AirLine()
        {
            this.id = 0;
            this.Destination = "no";
            this.NumberOfAirline = 0;
            this.TypeAircraft = 0;
            this.TimeC = "no";
            this.DaysOfWeek = "";
            this.AirId = MakeHash(id, Destination, NumberOfAirline, TypeAircraft);
            size++;
        }

        public AirLine(int iden, string m, short mod, int y, string col, string c)
        {
            this.id = iden;
            this.Destination = m;
            this.NumberOfAirline = mod;
            this.TypeAircraft = y;
            this.TimeC = col;
            this.DaysOfWeek = c;
            this.AirId = MakeHash(id, Destination, NumberOfAirline, TypeAircraft);
            size++;
        }



        public AirLine(int iden, string m, int y)
        {
            this.id = iden;
            this.Destination = m;
            this.TypeAircraft = y;
            this.AirId = MakeHash(id, Destination, NumberOfAirline, TypeAircraft);
            size++;
        }
    }
    public partial class AirLine
    {
        public uint MakeHash(int id, string Destination, short NumberOfAirline, int TypeAircraft)
        {
            int intRes = Destination.Length + TypeAircraft * 9 - id;
            uint res = (uint)intRes;//явное преобразование
            return res;
        }

    }
    public class NewClass : System.Object//унаследование
    {
        public override bool Equals(object obj)//переопределение метода
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return base.Equals(obj);//ссылка  на родителя
        }
    }
}

