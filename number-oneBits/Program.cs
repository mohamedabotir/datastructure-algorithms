﻿   int HammingWeight(uint n) {
        int count = 0;

	while (n != 0)
	{
		uint curr = n;

		if ((curr & 1) == 1) // 1&1 = 1
			count++;

		n >>= 1;
	}

	return count;
    }