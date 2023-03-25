using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Parser
{
    public const string InputFile = "..\\..\\..\\addresses.csv";
    public const string OutputFile = "..\\..\\..\\addresses.txt";

    public static IEnumerable<Address> Read()
    {
        using var input = File.OpenText(InputFile);
        var addresses = new List<Address>();
        input.ReadLine();
        int counter = 1;
        var ud = "(unknowData)";
        while (!input.EndOfStream)
        {
            var line = input.ReadLine();
            counter++;
            var chunks = line.Split(",")!;
            for (int i = 0; i < chunks.Length; i++)
            {
                if (chunks[i] == "") chunks[i] = ud;
            }


            if (chunks.Length == 7)
            {
                var name = chunks[0];
                var surname = chunks[1];
                var secondName = chunks[2];
                var street = chunks[3];
                var city = chunks[4];
                var province = chunks[5];
                var ZIP = chunks[6];
                var address = new Address(name, surname, secondName, street, city, province, ZIP);
                addresses.Add(address);
            }
            else if (chunks.Length == 4)
            {
                var name = chunks[0];
                var surname = ud;
                var street = ud;
                var city = chunks[1];
                var province = chunks[2];
                var ZIP = chunks[3];
                var address = new Address(name, surname, street, city, province, ZIP);
                addresses.Add(address);

            }
            else if (chunks.Length == 6)
            {
                var name = chunks[0];
                var surname = chunks[1];
                var street = chunks[2];
                var city = chunks[3];
                var province = chunks[4];
                var ZIP = chunks[5];
                var address = new Address(name, surname, street, city, province, ZIP);
                addresses.Add(address);
            }
            else
            {
                Console.WriteLine($"La riga n. {counter} non è valida");
                continue;
            }

        }
        return addresses;
    }

    public static void Write(IEnumerable<Address> addresses)
    {
        using var output = File.CreateText(OutputFile);
        output.WriteLine("Lista di Indirizzi:");
        foreach (var address in addresses)
        {
            output.WriteLine();
            output.WriteLine("----------------");
            output.WriteLine($"Nome e Cognome: {address.Name} {address.SecondName} {address.Surname}");
            output.WriteLine($"Indirizzo: {address.Street}, {address.City} ({address.Province}), {address.ZIP}");
            output.WriteLine("----------------");

        }
    }
}
