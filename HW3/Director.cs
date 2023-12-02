using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder { set { _builder = value; } }

        public void BuildHouseWithGarage() {
            this._builder.BuildFoundation();
            this._builder.BuildWalls();
            this._builder.BuildRoof();
            this._builder.BuildWindows();
            this._builder.BuildGarage();
        }
        public void BuildHouseWithGarden() {
            this._builder.BuildFoundation();
            this._builder.BuildWalls();
            this._builder.BuildRoof();
            this._builder.BuildWindows();
            this._builder.BuildGarden();
        }
    
    }
}
