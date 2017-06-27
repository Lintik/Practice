bool sumOfTwo(std::vector<int> a, std::vector<int> b, int v) {
    std::sort(b.begin(), b.end());
    for(auto itA = a.begin(); itA != a.end(); itA++){
        int x = v - *itA;
        if(std::binary_search(b.begin(), b.end(), x)){
            return true;
        }
    }
    return false;
}
