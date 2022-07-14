 public int[] RunningSum(int[] nums) {
        int p=0;
        for(int i=1;i<nums.Length;i++){
            nums[i]+=nums[p];
            p++;
        }
        return nums;
    }