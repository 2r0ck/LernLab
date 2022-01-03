using LernCommon;

namespace BuilderPattern
{
    public class House
    {
        public House(bool hasRoof, bool hasWall,bool hasFloor)
        {
            HasRoof = hasRoof;
            HasWall = hasWall;
            HasFloor = hasFloor;
        }

        public bool HasRoof { get; }
        public bool HasWall { get; }
        public bool HasFloor { get; }

        public override string ToString()
        {
            return this.TypeToString();
        }
    }
}
