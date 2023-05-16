using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.GameBuilder
{
    public abstract class IBoardGameBuilder
    {
        public abstract void BuildPlayer1(string i_Name);
        public abstract void BuildPlayer2(string i_Name);
        public abstract void BuildBoaredSize(int i_Row, int i_Col);
        public abstract void BuildComputer(bool i_IsComputerPlaying);
        public abstract GameBuilderProduct GetProduct();
    }
}
