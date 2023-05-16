using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.GameBuilder
{
   public class BoardGameDirector
    {
        private IBoardGameBuilder m_BoardGameBuilder;

        public BoardGameDirector(IBoardGameBuilder i_boardGameBuilder)
        {
            m_BoardGameBuilder = i_boardGameBuilder;
        }

        public GameBuilderProduct Constract(int i_Row, int i_Col, string i_Player1Name,
                                            string i_Player2Name, bool i_IsComputerPlaying)
        {
            m_BoardGameBuilder.BuildPlayer1(i_Player1Name);
            m_BoardGameBuilder.BuildPlayer2(i_Player2Name);
            m_BoardGameBuilder.BuildBoaredSize(i_Row, i_Col);
            m_BoardGameBuilder.BuildComputer(i_IsComputerPlaying);

            return m_BoardGameBuilder.GetProduct();
        }
    }
}
