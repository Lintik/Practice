bool sudoku2(char[][] grid) {
    //check row
    char[] t = new char[9];
    for(int i = 0; i < 9; i++){
        var temp = grid[i].Where(x => x != '.');
        if(temp.Count() != temp.Distinct().Count()) return false;
    }
    //check column
    for(int i = 0; i < 9; i++){
        for(int j = 0; j < 9; j++){
            t[j] = grid[j][i];
        }
        if(t.Where(x => x != '.').Count() != t.Where(x => x != '.').Distinct().Count()) return false;
    }
    //check 3x3 grid
    List<char> s = new List<char>();
    for(int i = 0; i < 9; i+=3)
        for(int j = 0; j < 9; j+=3){
            for(int a = i; a < i + 3; a++){
                for(int b = j; b < j + 3; b++){
                    if(grid[a][b] != '.')
                        s.Add(grid[a][b]);
                }
            }
            if(s.Count() != s.Distinct().Count()) return false;
            s.Clear();
        }
    return true;
}
