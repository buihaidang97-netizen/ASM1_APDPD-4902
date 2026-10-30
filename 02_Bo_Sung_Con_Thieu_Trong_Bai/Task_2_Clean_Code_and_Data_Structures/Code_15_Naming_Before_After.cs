// Unclear: what is x, what does Calc return?
public float Calc(List<float> x, int y)
{
    return x.Sum() / y;
}
 
// Clean: the name and parameters explain the rule
public float CalculateAverageScore(List<float> scores, int numberOfAssignments)
{
    return scores.Sum() / numberOfAssignments;
}
