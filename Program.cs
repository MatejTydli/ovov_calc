Utils.Console.ConsoleExceptionSolver.ConsoleExceptionSolverCZ(Deleg);

void Deleg()
{
    string[] nazvyDisciplin = {
        "sedesatka",
        "dalka",
        "trojskok",
        "medicimbal",
        "kriket",
        "dribling",
        "kliky",
        "sedlehy",
        "shyby",
        "svihadlo"
    };

    Console.WriteLine("Vysledky prosim piste (a pripadne zaokrouhlujte na) ve formatu: 199 nebo 1.9 nebo 1.89, jednotky netreba.");

    int body = 0;
    foreach (string nazevDiscipliny in nazvyDisciplin)
    {
        Console.WriteLine("Napiste prosim vysledek v discipline {0}:", nazevDiscipliny);

        double vysledek = Convert.ToDouble(Console.ReadLine().Trim());
        double minulaRadka = -1f;
        int pocitadloBodu = 0;

        foreach (string radka in File.ReadAllLines(@$"tabulky/{nazevDiscipliny}.txt"))
        {
            double aktualniRadka = Convert.ToDouble(radka);
            if (nazevDiscipliny != nazvyDisciplin[0])
            {
                if (aktualniRadka > vysledek) break;
            }
            else
            {
                if (aktualniRadka < vysledek) break;
            }

            minulaRadka = aktualniRadka;
            pocitadloBodu += 10;
        }

        body += pocitadloBodu;

        Console.WriteLine("Body za {0}: {1}", nazevDiscipliny, pocitadloBodu);
        Console.WriteLine("Dosud sectene body: {0}", body);
    }

    Console.WriteLine("Celkove body: {0}", body);
}