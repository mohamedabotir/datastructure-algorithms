int SingleNumber(int[] nums) {
          var dict = new Dictionary<int,int>();
        for(var i=0;i<nums.Length;i++)
        {
            if(dict.ContainsKey(nums[i]))  
                dict.Remove(nums[i]);
            else 
                dict.Add(nums[i],nums[i]); 
        }
        foreach(var i in dict.Keys)  return i; 
        return int.MaxValue;
    }