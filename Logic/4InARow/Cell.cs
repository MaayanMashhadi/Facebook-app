using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4InARowLogic
{
   public class Cell
    {
        private char m_Cell;
        private int m_Row;
        private int m_Col;

        public Cell(int i_Row, int i_Col)
        {
            m_Cell = ' ';
            m_Row = i_Row;
            m_Col = i_Col;
        }

        public char CharCell
        {
            get
            {
                return m_Cell;
            }

            set
            {
                m_Cell = value;
            }
        }
    }
}
