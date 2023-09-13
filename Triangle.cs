namespace Arv_part_2
{
    class Triangle : Shape
    {
         public Triangle (int x, int y): base(x,y){

        }
        
        public override int Area()
        {
             int area= width*height/2;
             return area;

        }
        public override int Cirumferance()
        {
            int c= (int)Math.Sqrt(width*width+height*height);
            int circ=width+height+c;
            return circ;
        }
    }
}