int sumInRange(int[] nums, int[][] queries) {
    Int64 sum = 0;
    int y = (int)Math.Pow(10, 9) + 7;
    Int64[] cumulativeSum = new Int64[nums.Length];
    cumulativeSum[0] = nums[0];
    for(int i = 1; i < nums.Length; i++){
        cumulativeSum[i] += nums[i] + cumulativeSum[i-1];
    }
    
    for(int i = 0; i < queries.Length; i++){
        if(queries[i][0] - 1 < 0)
            sum += cumulativeSum[queries[i][1]];
        else
            sum += cumulativeSum[queries[i][1]] - cumulativeSum[queries[i][0] - 1];
    }
    if(y + sum < 0){
        return (int)(y - Math.Abs(sum) % y);
    }
    return (int)((y + sum) % y);
}
