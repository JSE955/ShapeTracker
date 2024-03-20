namespace ShapeTracker.Models
{
  public class Rectangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    public Rectangle(int length1, int length2) 
    {
      Side1 = length1;
      Side2 = length2;
    }

    public int CalculateArea()
    {
      return Side1 * Side2;
    }
  }
}