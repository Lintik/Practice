char firstNotRepeatingCharacter(string s){
  try{
    return s.ToCharArray().GroupBy(n => n)
                     .Where(g => g.Count() == 1)
                     .Select(g => g.Key).First();
  }
  catch{
    return '_';
  }
}
