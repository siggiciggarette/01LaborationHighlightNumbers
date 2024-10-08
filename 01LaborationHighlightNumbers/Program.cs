string input = "29535123p48723487597645723645"; // Hårdkodad sträng
int length = input.Length; // Strängens längd

// Yttre loop för att bestämma startpunkten
for (int start = 0; start < length; start++)
{
    // Inre loop för att bestämma längden på delsträngen
    for (int end = start + 1; end <= length; end++)
    {
        string substring = input.Substring(start, end - start); // Extrahera delsträngen
        
}
bool IsAllDigits(string str)
{
    foreach (char c in str)
    {
        if (!char.IsDigit(c)) // Om ett tecken inte är en siffra, returnera false
        {
            return false;
        }
    }
    return true; // Alla tecken är siffror
}

bool IsValidNumber(string str)
{
    return str.Length > 1 && str[0] == str[^1] && IsAllDigits(str);
}

for (int start = 0; start < length; start++)
{
    for (int end = start + 1; end <= length; end++)
    {
        string substring = input.Substring(start, end - start);

        if (IsValidNumber(substring)) // Kontrollera om det är ett giltigt tal
        {
            Console.WriteLine($"Hittat giltigt tal: {substring}");
        }
    }
}

Console.ForegroundColor = ConsoleColor.Red; // Ändra färgen till röd
Console.Write("Text i röd färg");
Console.ResetColor(); // Återställ till standardfärg


for (int start = 0; start < length; start++)
{
    for (int end = start + 1; end <= length; end++)
    {
        string substring = input.Substring(start, end - start);

        if (IsValidNumber(substring)) // Kontrollera om det är ett giltigt tal
        {
            // Skriv ut hela strängen med delsträngen markerad
            for (int i = 0; i < length; i++)
            {
                if (i >= start && i < end) 
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.Write(input[i]);
                    Console.ResetColor(); // Återställ färgen
                }
                else
                {
                    Console.Write(input[i]); // Resten av strängen
                }
            }
            Console.WriteLine(); // Radbyte efter varje utskrift
        }
    }
}


List<long> validNumbers = new List<long>();

for (int start = 0; start < length; start++)
{
    for (int end = start + 1; end <= length; end++)
    {
        string substring = input.Substring(start, end - start);

        if (IsValidNumber(substring))
        {
            // Skriv ut som tidigare
            for (int i = 0; i < length; i++)
            {
                if (i >= start && i < end)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(input[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine(); // Radbyte

            // Lägg till delsträngen i listan och konvertera den till ett tal
            validNumbers.Add(long.Parse(substring));
        }
    }
}
