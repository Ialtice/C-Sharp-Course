using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Inventory : Warehouses
    {
        
        public static void DisplayInventory(Warehouses Atlanta, Warehouses Baltimore, Warehouses Chicago,
            Warehouses Denver, Warehouses Ely, Warehouses Fargo)

        {
            Console.Write(String.Format("\n\n{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", "Warehouse Name", "Part 102", "Part 215", "Part 410", "Part 525", "Part 711"));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", Atlanta.Name, Atlanta.Part102, Atlanta.Part215, Atlanta.Part410, Atlanta.Part525, Atlanta.Part711));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", Baltimore.Name, Baltimore.Part102, Baltimore.Part215, Baltimore.Part410, Baltimore.Part525, Baltimore.Part711));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", Chicago.Name, Chicago.Part102, Chicago.Part215, Chicago.Part410, Chicago.Part525, Chicago.Part711));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", Denver.Name, Denver.Part102, Denver.Part215, Denver.Part410, Denver.Part525, Denver.Part711));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n", Ely.Name, Ely.Part102, Ely.Part215, Ely.Part410, Ely.Part525, Ely.Part711));
            Console.Write(String.Format("{0,-20} {1,-14} {2, -14}{3, -14}{4, -14} {5, -14}\n\n\n", Fargo.Name, Fargo.Part102, Fargo.Part215, Fargo.Part410, Fargo.Part525, Fargo.Part711));
        }// displays warehouse object data neatly
        public static int MaxWarehouses(Warehouses[] array, int partNum)//Param array of warehouses, and part num. returns warehouse index with the highest number of that part num 
        {
            int location = 5;// index of warehouse with most of part num
            int value = 0; // holds current max value of part num
            switch (partNum)
            {

                case 102:
                    value = array[5].Part102;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value <= array[i].Part102)
                        {
                            location = i;
                            value = array[i].Part102;
                        }
                    }
                    break;
                case 215:
                    value = array[5].Part215;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value <= array[i].Part215)
                        {
                            location = i;
                            value = array[i].Part215;
                        }
                    }
                    break;
                case 410:
                    value = array[5].Part410;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value <= array[i].Part410)
                        {
                            location = i;
                            value = array[i].Part410;
                        }
                    }
                    break;
                case 525:
                    value = array[5].Part525;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value <= array[i].Part525)
                        {
                            location = i;
                            value = array[i].Part525;
                        }
                    }
                    break;
                case 711:
                    value = array[5].Part711;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value <= array[i].Part711)
                        {
                            location = i;
                            value = array[i].Part711;
                        }
                    }
                    break;

            }
            return location;
        }
        public static int MinWarehouses(Warehouses[] array, int partNum)//Param array of warehouses, and part num.returns warehouse index with the lowest number of that part num
        {
            int location = 5;
            int value = 0;
            switch (partNum)
            {

                case 102:
                    value = array[5].Part102;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value >= array[i].Part102)
                        {
                            location = i;
                            value = array[i].Part102;
                        }
                    }
                    break;
                case 215:
                    value = array[5].Part215;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value >= array[i].Part215)
                        {
                            location = i;
                            value = array[i].Part215;
                        }
                    }
                    break;
                case 410:
                    value = array[5].Part410;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value >= array[i].Part410)
                        {
                            location = i;
                            value = array[i].Part410;
                        }
                    }
                    break;
                case 525:
                    value = array[5].Part525;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value >= array[i].Part525)
                        {
                            location = i;
                            value = array[i].Part525;
                        }
                    }
                    break;
                case 711:
                    value = array[5].Part711;
                    for (int i = 4; i >= 0; i--)
                    {
                        if (value >= array[i].Part711)
                        {
                            location = i;
                            value = array[i].Part711;
                        }
                    }
                    break;

            }
            return location;
        }

    }
}
