namespace D15_Inlämningsuppgift_3
{
    internal class Program
    {
        public class Element
        {
            public string grundämne, typ;
            public int z; //atomnummer
            public double smältpunkt, kokpunkt;

            public void print()
            {
                Console.WriteLine($"Grundämne: {grundämne} Atomnummer: {z}");
                Console.WriteLine($"    Typ: {typ}");
                Console.WriteLine($"    Smältpunkt: {smältpunkt} K");
                Console.WriteLine($"    Kokpunkt: {kokpunkt} K");
            }
        }
        static void Main(string[] args)
        {
            Element syre = new Element()
            {
                grundämne = "syre",
                z = 8,
                typ = "ickemetall",
                smältpunkt = 54.36,
                kokpunkt = 90.188,
            };
            Element järn = new Element()
            {
                grundämne = "järn",
                z = 26,
                typ = "metall",
                smältpunkt = 1811,
                kokpunkt = 3134,
            };
            Element guld = new Element()
            {
                grundämne = "guld",
                z = 79,
                typ = "metall",
                smältpunkt = 1337.33,
                kokpunkt = 3243,
            };
            //syre.print();
            //järn.print();
            //guld.print();

            Element[] grundämnen = new Element[6]
            {
                syre,
                järn,
                guld,
                new Element()
                {
                    grundämne = "väte",
                    z = 1,
                    typ = "ickemetall",
                    smältpunkt = 13.99,
                    kokpunkt = 20.271 },
                new Element()
                {
                    grundämne = "brom",
                    z = 35,
                    typ = "ickemetall",
                    smältpunkt = 265.8,
                    kokpunkt = 332.0 },
                new Element()
                {
                    grundämne = "kvicksilver",
                    z = 80,
                    typ = "metall",
                    smältpunkt = 234.3210,
                    kokpunkt = 629.88 } 
            };

            foreach(Element G in grundämnen)
            {
                G.print();
            }
            Console.WriteLine("==== Lista alla metaller! ====");
            foreach (Element G in grundämnen)
            {
                if (G.typ == "metall")
                {
                    G.print();
                }
                    
            }
            Console.WriteLine("-------(Uppgift 7)------");
            Console.WriteLine("Grundämne med smältpunkt under 273.16 K och kokpunkt över 273.16 K: ");
            Console.WriteLine();
            foreach (Element G in grundämnen)
            {
                if (G.smältpunkt < 273.16 && G.kokpunkt > 273.16 )
                {
                    G.print();
                }
            }
            
            Console.ReadKey();
        }
    }
}