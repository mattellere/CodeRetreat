using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOL_1
{
    public class Grid
    {
        public List<Row> rows;

        public int Width { get; set; }
        public int Heigth { get; set; }

        public Grid()
        {
            rows = new List<Row>();
        }

        public void Init(int x, int y)
        {
            Width = x;
            Heigth = y;
        }

        public void SetCell(int x, int y, bool newState)
        {

        }

        public Cell GetCell(int x, int y)
        {
            return rows[x].cells[y];
        }
    }

    public class Row
    {
        public Row()
        {
            cells = new List<Cell>();
        }
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
