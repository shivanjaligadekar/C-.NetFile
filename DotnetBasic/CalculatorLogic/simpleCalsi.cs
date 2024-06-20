namespace CalculatorLogic
{
    public class simpleCalsi
    {
        public int AddNos(int fno,int sno) {
            return fno + sno;
        }
        public int GetMultiplyAndDiv(int fno,int sno, out int divAns) 
        {
            int mulAns=fno * sno;
            divAns = fno / sno;
            return mulAns;
        }
        public Tuple<int,int> GetMultipleValues(int a , int b)
        {
            int min, max;
            if (a > b)
            {
                min = b;
                max = a;
            }
            else
            {
                max = b;
                min = a;
            }
            return new Tuple<int,int>(min, max);
        }
        public void swapNos(ref int fno, ref int sno)
        {
            int temp;
            temp = sno;
            sno = fno;
            fno = temp;
            Console.WriteLine("In the library the value of fno" + fno);
            Console.WriteLine("in the library the value of sno" + sno);
        }
    }
}
