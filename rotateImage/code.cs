int[][] rotateImage(int[][] a) {
    int N = a.Length;
    // Consider all squares one by one
    for (int x = 0; x < N / 2; x++){
        // Consider elements in group of 4 in 
        // current square
        for (int y = x; y < N-x-1; y++){
            // store current cell in temp variable
            int temp = a[x][y];
 
            // move values from left to top
            a[x][y] = a[N-1-y][x];
 
            // move values from bottom to left
            a[N-1-y][x] = a[N-1-x][N-1-y];
 
            // move values from right to bottom
            a[N-1-x][N-1-y] = a[y][N-1-x];
 
            // assign temp to right
            a[y][N-1-x] = temp;
        }
    }
    return a;
}
