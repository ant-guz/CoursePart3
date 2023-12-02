using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Builder : IBuilder
    {
        private House house;

        public House GetHouse()
        { 
            var result = house;
            house = new House();
            return result;
        }
        public Builder() { 
            this.house = new House();
        }
        public void BuildFancyStatues()
        {
            house.AppDetail("Fancy Statues");
        }

        public void BuildFoundation()
        {
            house.AppDetail("Foundation");
        }

        public void BuildGarage()
        {
            house.AppDetail("Garage");
        }

        public void BuildGarden()
        {
            house.AppDetail("Garden");
        }

        public void BuildRoof()
        {
            house.AppDetail("Roof");
        }

        public void BuildSwimmingPool()
        {
            house.AppDetail("Swimming Pool");
        }

        public void BuildWalls()
        {
            house.AppDetail("Walls");
        }

        public void BuildWindows()
        {
            house.AppDetail("Windows");
        }
    }
}
