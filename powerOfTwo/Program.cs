    bool IsPowerOfTwo(int n) {
      double res = (double)n;
            while (res >= 1)
            {
                if (res == 1) return true;
                res /= 2;
            }
            return false; 
    }