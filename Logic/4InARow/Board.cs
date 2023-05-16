using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.GameBuilder;

namespace Game4InARowLogic
{
    public class Board : IEnumerable, IEnumerable<Cell>
    {

        private readonly Cell[,] r_Board;

        public Board(GameBuilderProduct i_GameProduct)
        {
            Size = i_GameProduct.Row;
            r_Board = new Cell[i_GameProduct.Row, i_GameProduct.Col];
            for (int i = 0; i < i_GameProduct.Row; i++)
            {
                for (int j = 0; j < i_GameProduct.Col; j++)
                {
                    r_Board[i, j] = new Cell(i, j);
                }
            }
        }

        public int Size { get; }

        public Cell GetCell(int i_Row, int i_Col)
        {
            return r_Board[i_Row, i_Col];
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return new BoardIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ClearBoard()
        {
            foreach(Cell cell in this)
            {
                cell.CharCell = ' ';
            }
            
        }

        private class BoardIterator : IEnumerator<Cell>
        {
            private int m_CurrentCell;
            private Board m_Board;
            private int m_Count;

            public BoardIterator(Board i_Board)
            {
                m_Board = i_Board;
                m_Count = i_Board.Size;
                Dispose();
            }

            object IEnumerator.Current => Current;
            public Cell Current
            {
                get
                {
                    return m_Board.r_Board[m_CurrentCell / m_Count, m_CurrentCell % m_Count];
                }
            }

            public bool MoveNext()
            {
                ++m_CurrentCell;
                
                return m_CurrentCell < m_Count;
            }

            public void Reset()
            {
                m_CurrentCell = 0;
            }

            public void Dispose()
            {
                Reset();
            }

        }
    }
}
