using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuildDirector
    {
        public House Make(bool coldHouse);
    }

    public class BuildDirector : IBuildDirector
    {
        public House Make(bool coldHouse)
        {
            return StandardBuild(coldHouse ? new Builder1() : new Builder2());
        }

        public House StandardBuild(IHouseBuilder houseBuilder)
        {
            // тут можно по  разному управлять строителями, создавать отдельно директоров и прочее 
            houseBuilder.MakeFloor();
            houseBuilder.MakeRoof();
            houseBuilder.MakeWall();
            return houseBuilder.GetHouse();
        }
    }
}
