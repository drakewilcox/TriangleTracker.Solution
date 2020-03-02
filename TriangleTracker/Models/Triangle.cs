using System;
namespace TriangleTracker
{
  public class TriangleTracker
  {		
    public string TriangleType(int sideA, int sideB, int sideC)
    {
      if ((sideA + sideB) < (sideC) || (sideA + sideC) < (sideB) || (sideB + sideC) < (sideA))
      {
        return "Not A Triangle";
      }
      else if ((sideA == sideB) && (sideB == sideC))
      {
        return "equilateral";
      }
      else if ((sideA == sideB) || (sideB == sideC) || (sideC == sideA))
      {
        return "isosceles";
      }
      else if ((sideA != sideB) && (sideB != sideC) && (sideC != sideA))
      {
        return "scalene";
      }
      else 
      {
      return "string";
      }
    }
  }
}