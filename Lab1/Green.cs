namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d)>=1)
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
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if (((d + f) / 2) > 0)
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
            double sum_ab = a + b;
            double sr_ab = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (sum_ab>sr_ab)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, b);
            answer = Math.Max(answer, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x)> 1)
            {
                answer = 0;
            }
            else
            {
                answer = Math.Pow(x,2) -1;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x > 0) ;
            {
                if ((y < 1 + x) && (x<1))
                {
                    answer = true;
                }
            else
            
                if (y < 1 - x)
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
    }
}
