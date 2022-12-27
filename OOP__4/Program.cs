using System;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OOP__4
{
    class Program 
    { 
        static void Main()
        {
            Ruby ruby = new Ruby("Рубин", "Драгоценный камень, имеющий красный цвет", "Разновидность корунда", 4);
            Diamond diamond = new Diamond("Алмаз", "Драгоценный камень, самый твердый среди минералов","", 4);
            Emerald emerald = new Emerald("Изумруд", "Драгоценный камень, являющийся камнем 1 порядка","", 4);
            Flint flint = new Flint("Кремень","Камень, ипользуемый в ремесле","С помощью него изготавливается оружие");
            Thread thread = new Thread("Нить", "Длинный предмет","В данный момент товара нет в наличии");
            Printer printer = new Printer();

            object[] AllClasses = new object[] { ruby, diamond, emerald, flint, thread };
            foreach(object o in AllClasses)
            {
                printer.Print(o);
                Console.WriteLine();
            }

            Products products = new("Товар", "Описание Товара");
            
            products.DoClone();
            ((IProducts)products).DoClone();

            Necklace container = new Necklace();
            
            try
            {
                CNecklace necklace1 = new CNecklace("Рубин", "Темный Изумруд", "Маленький Алмаз", 15, 3, 4);
                container.Add(necklace1);
                CNecklace necklace2 = new CNecklace("Светлый Рубин", "Обычный Изумруд", "Большой Алмаз", 13, 10, 5);
                container.Add(necklace2);
                CNecklace necklace3 = new CNecklace("Темно-крансый Рубин", "Маленький Изумруд", "Обычный Алмаз", 5, 13, 44);
                container.Add(necklace3);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Превышен список ожерелий : " + e.Message + e.InnerException + e.Source);
            }
            catch(ProductsException e)
            {
                Console.WriteLine("Введено неверное значение карат!");
                Console.WriteLine(e.Message + e.InnerException + e.Source);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Введено число, заходящее за диапазон 0 - 50" + e.Message + e.InnerException + e.Source);
            }
            finally
            {
                container.Print();
            }


            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("flint.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, flint);
                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Flint newFlint = (Flint)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
            }

            //------------------------------------------//

            string json = JsonSerializer.Serialize(flint);
            Console.WriteLine(json);
            Flint rFlint = JsonSerializer.Deserialize<Flint>(json);
            Console.WriteLine(rFlint.stroke);

            //---------------------------------------//
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Flint));
            using (FileStream fs = new FileStream("flint.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, flint);

                Console.WriteLine("Object has been serialized");
            }

            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                Flint FFlint = xmlSerializer.Deserialize(fs) as Flint;
            }

            //------------------------------------------------------------//

            List<Flint> list = new List<Flint>();
            string newjson = JsonSerializer.Serialize(list);
            Console.WriteLine(newjson);

        }
        public static void SoapWriteFile(object objGraph, string fileName)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, objGraph);
            }
        }

        static void Deserialize()
        {
            Hashtable addresses = null;
            FileStream fs = new FileStream("DataFile.soap", FileMode.Open);
            try
            {
                SoapFormatter formatter = new SoapFormatter();

                addresses = (Hashtable)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            foreach (DictionaryEntry de in addresses)
            {
                Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
            }
        }


    }

}