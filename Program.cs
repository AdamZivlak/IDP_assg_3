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
            syre.print();
            järn.print();
            guld.print();
        }
    }
}