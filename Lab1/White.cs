namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            if (d > 0) { answer = true; }
            else { answer = false; }

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            if (n % 2 == 0) { answer = true; }
            else { answer = false; }

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            if (a > b) { answer = a; }
            else { answer = b; }

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            if (Math.Abs(d) > Math.Abs(f)) { answer = f; }
            else { answer = d; }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1) { answer = 1; }
            else { answer = x; }


            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;
            
            double des = 1e-6;

            if (Math.Abs(x * x + y * y - r * r) <= des)
            {
                answer = true;
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            int s = n * n;
            if (s - n > 2 * n)
            {
                if (n % 2 == 0) { answer = true; }
                else { answer = false; }
            }
            else { return answer; }
            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            if (L <= 30)
            {
                if (T + M >= 5 && M % 2 == 0) { answer |= true; }
            }

            return answer;
        }
    }
}
