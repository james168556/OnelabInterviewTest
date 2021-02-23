namespace OnelabInterviewTest
{
    public class Queen
    {
        public int Row;
        public int Column;

        public Queen(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return $"({Row},{Column})";
        }
    }
}
