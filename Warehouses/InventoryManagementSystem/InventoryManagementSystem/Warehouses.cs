//Isaac Altice
//Student ID : 801077284
//Assignment 2
using System;
using System.IO;
using System.Text;

namespace WarehouseProject
{
    class Warehouses
    {
        private string name;// fields for warehouse objects
        private int part102;
        private int part215;
        private int part410;
        private int part525;
        private int part711;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }// set and get methods for warehouse objects

        public int Part102
        {
            get { return part102; }
            set { part102 = value; }
        }
        public int Part215
        {
            get { return part215; }
            set { part215 = value; }
        }
        public int Part410
        {
            get { return part410; }
            set { part410 = value; }
        }
        public int Part525
        {
            get { return part525; }
            set { part525 = value; }
        }
        public int Part711
        {
            get { return part711; }
            set { part711 = value; }
        }
        public Warehouses(string inName, int inPart102, int inPart215, int inPart410, int inPart525, int inPart711)
        {
            name = inName;
            part102 = inPart102;
            part215 = inPart215;
            part410 = inPart410;
            part525 = inPart525;
            part711 = inPart711;
        }//constructor with 6 parameters to be read from inventory file
        public Warehouses()
        {
            name = "";
            part102 = 0;
            part215 = 0;
            part410 = 0;
            part525 = 0;
            part711 = 0;
        }//default constructor
        public void UpdateInventory(string operation, int part, int quantity)
        {
            int value;
            if (operation == "P")
            {
                switch (part)
                {
                    case 102:
                        value = (this.Part102);
                        value += quantity;
                        this.Part102 = value;
                        break;
                    case 215:
                        value = (this.Part215);
                        value += quantity;
                        this.Part215 = value;
                        break;
                    case 410:
                        value = (this.Part410);
                        value += quantity;
                        this.Part410 = value;
                        break;
                    case 525:
                        value = (this.Part525);
                        value += quantity;
                        this.Part525 = value;
                        break;
                    case 711:
                        value = (this.Part711);
                        value += quantity;
                        this.Part711 = value;
                        break;
                    default:
                        Console.WriteLine("Invalid part number, no inventory update made.");
                        break;
                }
            }
            else if (operation == "S")
            {
                switch (part)
                {
                    case 102:
                        if (this.Part102 - quantity < 0)
                            Console.WriteLine("Sell quantity greater than inventory, no inventory update made.");
                        else
                        {
                            value = (this.Part102);
                            value -= quantity;
                            this.Part102 = value;
                        }
                        break;
                    case 215:
                        if (this.Part215 - quantity < 0)
                            Console.WriteLine("Sell quantity greater than inventory, no inventory update made.");
                        else
                        {
                            value = (this.Part215);
                            value -= quantity;
                            this.Part215 = value;
                        }
                        break;
                    case 410:
                        if (this.Part410 - quantity < 0)
                            Console.WriteLine("Sell quantity greater than inventory, no inventory update made.");
                        else
                            this.Part410 -= quantity;
                        break;
                    case 525:
                        if (this.Part525 - quantity < 0)
                            Console.WriteLine("Sell quantity greater than inventory, no inventory update made.");
                        else
                        {
                            value = (this.Part525);
                            value -= quantity;
                            this.Part525 = value;
                        }
                        break;
                    case 711:
                        if (this.Part711 - quantity < 0)
                            Console.WriteLine("Sell quantity greater than inventory, no inventory update made.");
                        else
                        {
                            value = (this.Part711);
                            value -= quantity;
                            this.Part711 = value;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid part number, no inventory update made.");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Invalid transaction option.");
                Console.WriteLine("Enter P for purchase.");
                Console.WriteLine("Enter S for sell.");
            }


        }// updates inventory using the parameters from transaction file
        public static void Main(string[] args)// driver
        {
            string[] data;// used to hold data from files after each line is split into required parts using the delimiter
            string record;// used to hold lines of data from files

            Console.WriteLine("Welcome to the Inventory Management System\n\n");
            Warehouses[] warehouseList = new Warehouses[6];// creates a array for the 6 warehoues

            for(int i = 0; i < 6; i++)
            {
                warehouseList[i] = new Warehouses(); // initializes 6 warehouses with defualt values
            }
            try
            {
                const char DELIM = ',';// delimiter used in text files
                const string FILENAMEINV = "Inventory.txt";//file holds 6 lines of text containing the quantity of each part, each lines represents a warehouse
                const string FILENAMETRANS = "Transactions.txt";// file holds transactions, each line represents a transaction with a type, part number, and quantity
                FileStream inFile = new FileStream(FILENAMEINV, FileMode.Open, FileAccess.Read);// opens inventory file 
                StreamReader reader = new StreamReader(inFile);// declares reader to pull data from file
                record = reader.ReadLine();// record holds each line of inventory contianing initial part amounts
                int warehouseNum = 0;// variable to hold position on warehouse array
                Warehouses Atlanta = null;// declare all objects of type Warehouse
                Warehouses Baltimore = null;
                Warehouses Chicago = null;
                Warehouses Denver = null;
                Warehouses Ely = null;
                Warehouses Fargo = null;
                while (record != null)// loop until all data from inventory file is processed
                {
                    data = record.Split(DELIM);// splits each line of data into 5 parts for part quantities and stores in data array
                    switch (warehouseNum)//uses data from inventory file to create each warehouse object and store in the warehouse type array warehouselist
                    {
                        case 0:
                            Atlanta = new Warehouses("Atlanta", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Atlanta;
                        break;
                        case 1:
                            Baltimore = new Warehouses("Baltimore", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Baltimore;
                            break;
                        case 2:
                            Chicago = new Warehouses("Chicago", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Chicago;
                            break;
                        case 3:
                            Denver = new Warehouses("Denver", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Denver;
                            break;
                        case 4:
                            Ely = new Warehouses("Ely", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Ely;
                            break;
                        case 5:
                            Fargo = new Warehouses("Fargo", Int32.Parse(data[0]),
                                Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]));
                            warehouseList[warehouseNum] = Fargo;
                            break;
                    }
                    warehouseNum += 1;
                    Array.Clear(data, 0, 5);
                    record = reader.ReadLine();

                }
                reader.Close();
                inFile.Close();
                
                Console.WriteLine("Initial Inventory\n");
                Inventory.DisplayInventory(Atlanta, Baltimore, Chicago, Denver, Ely, Fargo);
                Console.WriteLine("\n\n Adding transactions for today\n");
                FileStream inFile1 = new FileStream(FILENAMETRANS, FileMode.Open, FileAccess.Read);
                StreamReader reader1 = new StreamReader(inFile1);
                
                string record1 = reader1.ReadLine();

                while (record1 != null )// loops through each line of transactions file changing the values of the correct warehouse object
                {
                    
                        data = record1.Split(DELIM);
                        if (data[0] == "S")
                        {
                        int totalToSell = Int32.Parse(data[2]);
                        int sellValue = 0;
                        int whatWarehouse = 0;
                        int whatPart = Int32.Parse(data[1]);
                            while (totalToSell > 0)
                            {

                                whatWarehouse = Inventory.MaxWarehouses(warehouseList, Int32.Parse(data[1]));
                                switch(whatPart)
                                {
                                case 102:
                                    if (totalToSell > (warehouseList[whatWarehouse].Part102))
                                    {
                                        sellValue = (warehouseList[whatWarehouse].Part102);
                                        totalToSell = totalToSell - sellValue;
                                    }
                                    else
                                    {
                                        sellValue = totalToSell;
                                        totalToSell = 0;
                                    }
                                    break;
                                case 215:
                                    if (totalToSell > (warehouseList[whatWarehouse].Part215))
                                    {
                                        sellValue = (warehouseList[whatWarehouse].Part215);
                                        totalToSell = totalToSell - sellValue;
                                    }
                                    else
                                    {
                                        sellValue = totalToSell;
                                        totalToSell = 0;
                                    }
                                    break;
                                case 410:
                                    if (totalToSell > (warehouseList[whatWarehouse].Part410))
                                    {
                                        sellValue = (warehouseList[whatWarehouse].Part410);
                                        totalToSell = totalToSell - sellValue;
                                    }
                                    else
                                    {
                                        sellValue = totalToSell;
                                        totalToSell = 0;
                                    }
                                    break;
                                case 525:
                                    if (totalToSell > (warehouseList[whatWarehouse].Part525))
                                    {
                                        sellValue = (warehouseList[whatWarehouse].Part525);
                                        totalToSell = totalToSell - sellValue;
                                    }
                                    else
                                    {
                                        sellValue = totalToSell;
                                        totalToSell = 0;
                                    }
                                    break;
                                case 711:
                                    if (totalToSell > (warehouseList[whatWarehouse].Part711))
                                    {
                                        sellValue = (warehouseList[whatWarehouse].Part711);
                                        totalToSell = totalToSell - sellValue;
                                    }
                                    else
                                    {
                                        sellValue = totalToSell;
                                        totalToSell = 0;
                                    }
                                    break;
                                }
                            Console.WriteLine("Transaction: Warehouse:{0}  Operation: {1}  Part:{2}  Quantity: {3}", warehouseList[Inventory.MaxWarehouses(warehouseList, whatPart)].Name, data[0], whatPart, sellValue);
                            warehouseList[Inventory.MaxWarehouses(warehouseList, whatPart)].UpdateInventory(data[0], whatPart, sellValue);
                               
                            }
                        }
                        if (data[0] == "P")
                        {
                        Console.WriteLine("Transaction: Warehouse:{0}  Operation: {1}  Part:{2}  Quantity: {3}", warehouseList[Inventory.MinWarehouses(warehouseList, Int32.Parse(data[1]))].Name, data[0], data[1], data[2]);
                        warehouseList[Inventory.MinWarehouses(warehouseList, Int32.Parse(data[1]))].UpdateInventory(data[0], Int32.Parse(data[1]), Int32.Parse(data[2]));
                            
                        }
                        Console.WriteLine("Update Inventory: \n");
                        Inventory.DisplayInventory(Atlanta, Baltimore, Chicago, Denver, Ely, Fargo);
                        Array.Clear(data, 0, 3);
                        record1 = reader1.ReadLine();
                 }
                reader.Close();
                inFile.Close();
                Console.WriteLine("Transactions Completed for today, starting End Of Day");
                FileStream outFile = new FileStream(FILENAMEINV, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);//writes the values of updated warehouse inventories to the inventory file 
                writer.WriteLine(Atlanta.Part102 + "" + DELIM + " " + Atlanta.Part215 + DELIM + " " + Atlanta.Part410 + 
                    DELIM + " " + Atlanta.Part525 + DELIM + " " + Atlanta.Part711);
                writer.WriteLine(Baltimore.Part102 + "" + DELIM + " " + Baltimore.Part215 + DELIM + " " + Baltimore.Part410 +
                    DELIM + " " + Baltimore.Part525 + DELIM + " " + Baltimore.Part711);
                writer.WriteLine(Chicago.Part102 + "" + DELIM + " " + Chicago.Part215 + DELIM + " " + Chicago.Part410 +
                    DELIM + " " + Chicago.Part525 + DELIM + " " + Chicago.Part711);
                writer.WriteLine(Denver.Part102 + "" + DELIM + " " + Denver.Part215 + DELIM + " " + Denver.Part410 +
                    DELIM + " " + Denver.Part525 + DELIM + " " + Denver.Part711);
                writer.WriteLine(Ely.Part102 + "" + DELIM + " " + Ely.Part215 + DELIM + " " + Ely.Part410 +
                    DELIM + " " + Ely.Part525 + DELIM + " " + Ely.Part711);
                writer.WriteLine(Fargo.Part102 + "" + DELIM + " " + Fargo.Part215 + DELIM + " " + Fargo.Part410 +
                    DELIM + " " + Fargo.Part525 + DELIM + " " + Fargo.Part711);

                writer.Close();
                outFile.Close();
                Console.WriteLine("Final Inventory for today:");
                Inventory.DisplayInventory(Atlanta, Baltimore, Chicago, Denver, Ely, Fargo);
            }
            catch (Exception e)
            {
               Console.WriteLine("Exception: " + e.Message);
            }
}
        

    }
   
}
