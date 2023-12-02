using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public interface IBuilder
    {
        void BuildRoof();

        void BuildWalls();

        void BuildWindows();

        void BuildFoundation();

        void BuildGarage();

        void BuildGarden();

        void BuildSwimmingPool();

        void BuildFancyStatues();

    }
}
