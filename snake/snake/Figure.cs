using System;
namespace snake
{
    public class Figure
    {
        public Figure()
        {
            protected List<Point> pList;

            public void Drow()
            {
                foreach (Point p in pList)
                {
                    p.Draw();
                }
            }
        }
    }
}
