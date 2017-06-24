bool isCryptSolution(string[] crypt, char[][] solution) {
    Dictionary<char, int> dict = new Dictionary<char, int>();
    for(int i = 0; i < solution.Length;i++)
       dict.Add(solution[i][0], Convert.ToInt32(char.GetNumericValue(solution[i][1])));
    
    int addend1 = 0;
    int addend2 = 0;
    int sum= 0;
    
    for(int i = 0; i < crypt[0].Length; i++){
        addend1 *= 10;
        addend1 += dict[crypt[0][i]];
    }
    
    for(int i = 0; i < crypt[1].Length; i++){
        addend2 *= 10;
        addend2 += dict[crypt[1][i]];
    }
    
    for(int i = 0; i < crypt[2].Length; i++){
        sum *= 10;
        sum += dict[crypt[2][i]];
    }
    
    for(int i = 0; i < 3; i++)
        if(dict[crypt[i][0]] == 0 && crypt[i].Length != 1){
            Console.WriteLine("first letter check");
            return false;
        }
    
    if(addend1 + addend2 != sum) return false;
    else return true;
}
