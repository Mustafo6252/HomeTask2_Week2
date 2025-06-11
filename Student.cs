namespace Homework2_week2;

public class Student
{
    public string Name;
    public int GradeLevel;
    public int[] Scores=new int[4];

    public double GetAverage()
    {
      
        double sum = 0;
        for (int i = 0; i < 4; i++)
        {
            sum += Scores[i];
        }
        return sum / Scores.Length;
    }

}