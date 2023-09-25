double n = 90;
double[] p = { 3, 2 };
double e = 400;

using (StreamWriter writer = new StreamWriter(@"dribling.txt"))
{

    int c = 0;
    do
    {
        writer.WriteLine(Math.Round(n, 2));
        if (c % 2 == 0)
        {
            n += p[1];
        }
        else
        {
            n += p[0];
        }

        c++;
    } while (n <= e);

    writer.Close();
}
