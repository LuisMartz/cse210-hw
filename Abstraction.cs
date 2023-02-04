using System;

class Fraction{
  public int _top;
  public int _bottom;
  //--------------
  public class Fraction(){
    _top = 1;
    _bottom = 1;
  // 1/1
  }
  public Fraction(int Number){
    _top = Number
    _bottom = 1;
  }
  public Fraction(int top, int bottom){
    _top = top;
    _bottom = bottom;
  }
  string GetFraction(){
    string fraction = $"{_top}/{_bottom}";
    return fraction;
  }
  //Decimals
  double GetDecimal(){
    return (double)_top / (double)_bottom;
  }
}
