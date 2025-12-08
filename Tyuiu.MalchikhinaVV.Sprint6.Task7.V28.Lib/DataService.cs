using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }
            int rowIndex = 6;

            for (int j = 0; j < colCount; j++)
            {
                if (matrix[rowIndex, j] != 13)
                {
                    matrix[rowIndex, j] = 0;
                }
            }
            return matrix;
        }
    }
}
