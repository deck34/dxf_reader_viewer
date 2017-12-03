using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace dxf_reader_viewer
{
    public class Geometry
    {
        String type;
        Dictionary<int, float> parameters;

        public Geometry(String type, Dictionary<int, float> parameters)
        {
            this.type = type;
            this.parameters = parameters;
        }
        public void Draw(Graphics graph, Pen pen, float scale)
        {
            if(this.type == "LINE")
            {
                graph.DrawLine(pen, scale*parameters[10], scale*parameters[20], scale*parameters[11], scale*parameters[21]);
            }
            else if (this.type == "CIRCLE") {
                graph.DrawEllipse(pen, scale * (parameters[10] - parameters[40]), scale * (parameters[20] - parameters[40]), scale * 2 * parameters[40], scale * 2 * parameters[40]);
            }
        }
    }
}
