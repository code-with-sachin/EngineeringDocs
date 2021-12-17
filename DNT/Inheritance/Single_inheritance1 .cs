using System;

namespace InheritanceApplication {
   class Shape {
    protected int width;
    protected int height;
   
      public void setWidth(int w) {
         width = w;
      }
      public void setHeight(int h) {
         height = h;
      }
      
   }

   // Derived class
   class Rectangle: Shape {
      public int getArea() { 
         return (width * height); 
      }
   }
   class RectangleTester {
      static void Main(string[] args) {
         Rectangle R = new Rectangle();

         R.setWidth(5);
         R.setHeight(7);

         // Print the area of the object.
         Console.WriteLine("Total area",  R.getArea());
         Console.ReadKey();
      }
   }
}