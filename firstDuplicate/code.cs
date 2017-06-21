int firstDuplicate(int[] a) {
    HashSet<int> b = new HashSet<int>();
    for(int i = 0; i < a.Length;i++){
        if(b.Contains(a[i]))
            return a[i];
        else
            b.Add(a[i]);
    }
    return -1;
}
