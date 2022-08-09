Dictionary<int,int> dict = new Dictionary<int,int>();
     int ClimbStairs(int n) {
        
        if(n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            if(dict.ContainsKey(n))
            {
                return dict[n];
            }
            else
            {
                dict[n] = ClimbStairs(n-1) + ClimbStairs(n-2);
                return dict[n];
            }
        }
    }