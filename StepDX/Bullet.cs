using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace StepDX
{
    class Bullet : PolygonTextured
    {
        private Vector2 p = new Vector2(0, 0);  // Position
        private Vector2 v = new Vector2(0, 0);  // Velocity
        private Vector2 a = new Vector2(0, 0);  // Acceleration

        public Vector2 P { set { p = value; } get { return p; } }
        public Vector2 V { set { v = value; } get { return v; } }
        public Vector2 A { set { a = value; } get { return a; } }

        private Vector2 pSave;  // Position
        private Vector2 vSave;  // Velocity
        private Vector2 aSave;  // Acceleration

        private float bulletTime = 0;
        private float bulletRate = 6;   // 6 per second

        protected List<Vector2> verticesM = new List<Vector2>();  // The vertices

        public override List<Vector2> Vertices { get { return verticesM; } }

        public override void Advance(float dt)
        {

            p.X = p.X - dt;

            if (p.X < -1.1f)
            {
                p.X = 5;
            }

            verticesM.Clear();
            foreach (Vector2 x in verticesB)
            {
                verticesM.Add(new Vector2(x.X + p.X, x.Y + p.Y));
            }
        }
    }
}
