List<float> scores = new List<float> { 6, 8, 10 };
 
float SumScores(List<float> values)
{
    float total = 0;
    foreach (float score in values)
    {
        total += score;
    }
    return total;
}
 
Console.WriteLine(SumScores(scores));
