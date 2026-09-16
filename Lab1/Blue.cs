namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a * b > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            // code here
            double a = 0.0001;
            int n = (int)d;
            if (Math.Abs(d - n) > a)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // end

                return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b == 0) answer = false;
            else if (a % b == 0) answer = true;
            else answer = false;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);
            if (d1 > f1 && d1 > g1) answer = d;
            if (f1 > g1 && f1 > d1) answer = f;
            if (g1 > f1 && g1 > d1) answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            if (-1 < x && x <= 0) answer = x + 1;
            if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}
