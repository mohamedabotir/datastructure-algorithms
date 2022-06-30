 int MinMoves2(int[] nums) {
        
        
        
        int steps = 0;
        Array.Sort(nums);
        int mid = nums[nums.Length/2];
            for(int i=0;i<nums.Length;i++){
                steps+=Math.Abs(nums[i]-mid);
            }
        return steps;
    }