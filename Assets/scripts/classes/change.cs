using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.classes
{
    public class Change
    {
        public int c1 = 0;
        public int c2 = 0;
        public int c5 = 0;
        public int c10 = 0;
        public int c20 = 0;
        public int c50 = 0;
        public int b1 = 0;
        public int b2 = 0;
        public int b5 = 0;
        public int b10 = 0;
        public int b20 = 0;
        public int b50 = 0;
        public int b100 = 0;
        public int b200 = 0;
        public int b500 = 0;

        public float GetTotal()
        {
            return (b500 * 500f)
                + (b200 * 200f)
                + (b100 * 100f)
                + (b50 * 50f)
                + (b20 * 20f)
                + (b10 * 10f)
                + (b5 * 5f)
                + (b2 * 2f)
                + (b1 * 1f)
                + (c50 * 0.5f)
                + (c20 * 0.2f)
                + (c10 * 0.1f)
                + (c5 * 0.05f)
                + (c2 * 0.02f)
                + (c1 * 0.01f);
        }
    }
}
