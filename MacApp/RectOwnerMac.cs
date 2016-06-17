extern alias SplatMac; 
using PCL;


namespace MacApp
{
  public class RectOwnerSubclass: RectOwner
  {
    public RectOwnerSubclass ()
    {
      this.Rect = new System.Drawing.RectangleF (5, 6, 7, 8);
    }
  }
}

