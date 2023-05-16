using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.GameBuilder
{
    public class GameBuilder : IBoardGameBuilder
    {
        private int m_Row;
        private int m_Col;
        private string m_Player1Name;
        private string m_Player2Name;
        private bool m_IsComputerPlaying;
        public GameBuilder()
        {
            m_Col = 0;
            m_Row = 0;
            m_Player1Name = "Player 1";
            m_Player2Name = "Player 2";
            m_IsComputerPlaying = false;
        }

        public override void BuildBoaredSize(int i_Row, int i_Col)
        {
            m_Row = i_Row;
            m_Col = i_Col;
        }

        public override void BuildPlayer1(string i_Name)
        {
            m_Player1Name = i_Name;
        }

        public override void BuildPlayer2(string i_Name)
        {
            m_Player2Name = i_Name;
        }

        public override void BuildComputer(bool i_IsComputerPlaying)
        {
            m_IsComputerPlaying = i_IsComputerPlaying;
        }

        public int GetRow()
        {
            return m_Row;
        }

        public int GetCol()
        {
            return m_Col;
        }
        public string GetPlayer1Name()
        {
            return m_Player1Name;
        }
        public string GetPlayer2Name()
        {
            return m_Player2Name;
        }
        public bool GetIsComputerPlaying()
        {
            return m_IsComputerPlaying;
        }
        public override GameBuilderProduct GetProduct()
        {
            return new GameBuilderProduct(this);
        }
    }
}
