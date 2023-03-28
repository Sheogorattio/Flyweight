using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract public class Unit
    {
        protected static string name;
        protected static int power;
        public int Power { get { return power; } }
        protected static int speed;
        public int Speed { get { return speed; } }
        protected int x;
        protected int y;
        abstract public void Show(int x, int y);
        public string GetName() { return name; }
    }

    public class Infantry : Unit
    {
        public Infantry() 
        {
            name = "Infantry";
            power = 10;
            speed = 20;
        }
        override public void Show(int x, int y) 
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(("Infantry ({0}, {1})",this.x, this.y).ToString());
        }
    }

    public class TransportVehicle: Unit
    {
        public TransportVehicle()
        {
            name = "Transport vehicle";
            power = 0;
            speed = 30;
        }
        override public void Show(int x , int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(("Transport vehicle ({0}, {1})", this.x, this.y).ToString());
        }
    }
    public class HeavyBattleMachine : Unit
    {
        public HeavyBattleMachine()
        {
            name = "Heavy battle machine";
            power = 30;
            speed = 20;
        }
        override public void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(("Heavy battle machine ({0}, {1})", this.x, this.y).ToString());
        }
    }

    public class UnitFactory
    {
        List<Unit> list = new List<Unit>();
        public void AddUnit(Unit obj)
        {
            list.Add(obj);
        }
        public List<Unit> GetUnits(Unit obj)
        {
            List<Unit> res = new List<Unit>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetName() == obj.GetName()) res.Add(list[i]);
            }
            if(res.Count == 0) res.Add(obj);
            return res;
        }
    }
}