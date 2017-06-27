bool containsDuplicates(int[] a) {
    return (a.Count() == a.Distinct().Count())? false: true;
}
