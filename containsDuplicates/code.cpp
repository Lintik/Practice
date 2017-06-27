bool containsDuplicates(std::vector<int> a) {
    set<int> s(a.begin(), a.end());
    return a.size()!=s.size();    
}
