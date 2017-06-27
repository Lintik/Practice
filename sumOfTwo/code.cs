bool sumOfTwo(int[] a, int[] b, int v) {
    if( a.Length == 0 || b.Length == 0 ){
        return false;
    }
    
    if(a.Length > b.Length){
        HashSet<int> aH = new HashSet<int>(a);
        for(int i = 0; i < b.Length; i++)
            if(aH.Contains(v - b[i])) return true;
    }
    else{
        HashSet<int> bH = new HashSet<int>(b);
        for(int i = 0; i < a.Length; i++)
            if(bH.Contains(v - a[i])) return true;
    }
    return false;
}
