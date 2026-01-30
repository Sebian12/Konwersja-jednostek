Console.WriteLine("1. Konwersja stopni (celsjusz -> fahrenheit)");
Console.WriteLine("2. Konwersja stopni (fahrenheit -> celsjusz)");
Console.WriteLine("3. Konwersja stopni (celsjusz -> kelwin)");
Console.WriteLine("4. Konwersja stopni (kelwin -> celsjusz)");
Console.WriteLine("5. Konwersja długości (metry -> stopy)");
Console.WriteLine("6. Konwersja długości (stopy -> metry)");
Console.WriteLine("7. Konwersja długości (kilometry -> mile)");
Console.WriteLine("8. Konwersja długości (mile -> kilometry)");
Console.WriteLine("9. Konwersja długości (metry -> cale)");
Console.WriteLine("10. Konwersja długości (cale -> metry)");

Console.Write("Wybierz opcję (1-10): ");
int wybor = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double KonwertujCelsjuszNaFahrenheit(double C) {
    return Math.Round((C * 9 / 5) + 32, 2);
}

double KonwertujFahrenheitNaCelsjusz(double F)
{
    return Math.Round((F - 32) * 5 / 9, 2);
}

double KonwertujCelsjuszNaKelwin(double C) {
    return Math.Round(C + 273.15, 2);
}
double KonwertujKelwinNaCelsjusz(double K) {
    return Math.Round(K - 273.15, 2);
}

double KonwertujMetryNaStopy(double metry)
{
    return Math.Round(metry * 3.28084, 2);
}

double KonwertujStopyNaMetry(double stopy)
{
    return Math.Round(stopy / 3.28084, 2);
}

double KonwertujKilometryNaMile(double kilometry)
{
    return Math.Round(kilometry * 0.621371, 2);
}

double KonwertujMileNaKilometry(double mile)
{
    return Math.Round(mile / 0.621371, 2);
}

double KonwertujMetryNaCale(double metry)
{
    return Math.Round(metry * 39.3701, 2);
}

double KonwertujCaleNaMetry(double cale)
{
    return Math.Round(cale / 39.3701, 2);
}

switch (wybor) {
    case 1:
        Console.Write("Podaj wartość w stopniach Celsjusza: ");
        double Celsjusz = double.Parse(Console.ReadLine()!);
        double fahrenheit = KonwertujCelsjuszNaFahrenheit(Celsjusz);
        Console.WriteLine($"Wynik: {fahrenheit} stopni Fahrenheit");
        break;
    case 2:
        Console.Write("Podaj wartość w stopniach Fahrenheit: ");
        double Fahrenheit = double.Parse(Console.ReadLine()!);
        double celsjusz = KonwertujFahrenheitNaCelsjusz(Fahrenheit);
        Console.WriteLine($"Wynik: {celsjusz} stopni Celsjusza");
        break;
    case 3:
        Console.Write("Podaj wartość w stopniach Celsjusza: ");
        double CelsjuszKelwin = double.Parse(Console.ReadLine()!);
        double kelwin = KonwertujCelsjuszNaKelwin(CelsjuszKelwin);
        Console.WriteLine($"Wynik: {kelwin} stopni Kelwin");
        break;
    case 4:
        Console.Write("Podaj wartość w stopniach Kelwin: ");
        double Kelwin = double.Parse(Console.ReadLine()!);
        double celsjuszKelwin = KonwertujKelwinNaCelsjusz(Kelwin);
        Console.WriteLine($"Wynik: {celsjuszKelwin} stopni Celsjusza");
        break;
    case 5:
        Console.Write("Podaj wartość w metrach: ");
        double metry = double.Parse(Console.ReadLine()!);
        double stopy = KonwertujMetryNaStopy(metry);
        Console.WriteLine($"Wynik: {stopy} stóp");
        break;
    case 6:
        Console.Write("Podaj wartość w stopach: ");
        double Stopy = double.Parse(Console.ReadLine()!);
        double Metry = KonwertujStopyNaMetry(Stopy);
        Console.WriteLine($"Wynik: {Metry} metrów");
        break;
    case 7:
        Console.Write("Podaj wartość w kilometrach: ");
        double Kilometry = double.Parse(Console.ReadLine()!);
        double Mile = KonwertujKilometryNaMile(Kilometry);
        Console.WriteLine($"Wynik: {Mile} mil");
        break;
    case 8:
        Console.Write("Podaj wartość w milach: ");
        double mile = double.Parse(Console.ReadLine()!);
        double kilometry = KonwertujMileNaKilometry(mile);
        Console.WriteLine($"Wynik: {kilometry} kilometrów");
        break;
    case 9:
        Console.Write("Podaj wartość w metrach: ");
        double metryInput = double.Parse(Console.ReadLine()!);
        double cale = KonwertujMetryNaCale(metryInput);
        Console.WriteLine($"Wynik: {cale} cali");
        break;
    case 10:
        Console.Write("Podaj wartość w calach: ");
        double caleInput = double.Parse(Console.ReadLine()!);
        double metryOutput = KonwertujCaleNaMetry(caleInput);
        Console.WriteLine($"Wynik: {metryOutput} metrów");
        break;
    default:
        Console.WriteLine("Nieprawidłowy wybór.");
        break;
}

Console.WriteLine();
Console.WriteLine("Naciśnij enter aby zakończyć");
Console.ReadKey();
