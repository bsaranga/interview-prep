namespace Arrays
{
    public class CircularArray
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            int rotationAmount = d % (a.Count);
            var leftSubStr = a.Where((_,i) => i < rotationAmount);
            var rightSubStr = a.Where((_, i) => i >= rotationAmount);
            var rotatedArr = rightSubStr.Concat(leftSubStr);
            
            return rotatedArr.ToList();
        }
    }
}