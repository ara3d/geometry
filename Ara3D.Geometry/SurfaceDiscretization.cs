using Ara3D.Collections;
using Ara3D.Mathematics;

namespace Ara3D.Geometry
{
    /// <summary>
    /// This class is used for sampling parameterized surfaces and computing quad-mesh strip indices.
    /// column == u (x), row == v (y)
    /// </summary>
    public class SurfaceDiscretization
    {
        public IArray<float> Us { get; }
        public IArray<float> Vs { get; }
        public IArray2D<Vector2> Uvs { get; }
        public bool ClosedU { get; }
        public bool ClosedV { get; }
        public IArray2D<Int4> QuadIndices { get; }

        public SurfaceDiscretization(int nColumns, int nRows, bool closedU, bool closedV)
        {
            ClosedU = closedU;
            ClosedV = closedV;
            
            var nx = nColumns + (closedU ? 0 : 1);
            var ny = nRows + (closedV ? 0 : 1);

            Us = closedU ? nx.InterpolateExclusive() : nx.InterpolateInclusive();
            Vs = closedV ? ny.InterpolateExclusive() : ny.InterpolateInclusive();
            
            Uvs = Vs.CartesianProduct(Us, (u, v) => new Vector2(u, v));

            QuadIndices = nRows.Range().CartesianProduct(nColumns.Range(), (x, y) => QuadMeshFaceVertices(x, y, nx, ny));
        }

        public static Int4 QuadMeshFaceVertices(int col, int row, int nx, int ny)
        {
            var a = row * nx + col;
            var b = row * nx + (col + 1) % nx;
            var c = (row + 1) % ny * nx + (col + 1) % nx;
            var d = (row + 1) % ny * nx + col;
            return (a, b, c, d);
        }

    }
}