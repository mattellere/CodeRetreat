using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOL_1
{
    public class Grid
    {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Cell GetCell(Row x, int y)
        {

        }
    }

    public class Row
    {
        public List<Cell> cells; 
    }

    public class Cell
    {
        public bool CurrState { get; set; }
        public bool OldState { get; set; }

        public bool Evolve()
        {
            bool newState = true;
            return newState;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
