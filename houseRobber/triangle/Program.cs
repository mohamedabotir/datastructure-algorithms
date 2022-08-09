   int MinimumTotal(IList<IList<int>> triangle) {
        int[] dp = new int[triangle.Count + 1];
		foreach (IList<int> row in triangle.Reverse()) {
			// Converted each row list to an array for easy access of items
			int[] rowItem = row.ToArray();
			for (int i = 0; i < rowItem.Length; i++) {
				//Create an array to store the min result from bottom
				// Try converting the array to a tree like structure to visualise
				dp[i] = rowItem[i] + Math.Min(dp[i], dp[i+1]);
			}
		}
		
		return dp[0];
    }