using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        public void MakeRoof();
        public void MakeWall();
        public void MakeFloor();
        public House GetHouse();
    }

    public class Builder1 : IHouseBuilder
    {
        private bool hasRoof;
        private bool hasWall;
        private bool hasFloor;

        public House GetHouse() => new House(hasRoof, hasWall, hasFloor);

        public void MakeFloor()
        {
            hasFloor = true;
        }

        public void MakeRoof()
        {
            hasRoof = true;
        }

        public void MakeWall()
        {
            hasWall = true;
        }
    }

    public class Builder2 : IHouseBuilder
    {
        private bool hasRoof;
        private bool hasWall;
        private bool hasFloor;

        public House GetHouse() => new House(hasRoof, hasWall, hasFloor);

        public void MakeFloor()
        {
            hasFloor = false;
        }

        public void MakeRoof()
        {
            hasRoof = false;
        }

        public void MakeWall()
        {
            hasWall = true;
        }
    }

}
