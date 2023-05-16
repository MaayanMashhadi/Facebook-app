using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.GameBuilder
{
   public class GameBuilderProduct
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public bool IsComputerPlaying { get; set; }

        public GameBuilderProduct(GameBuilder i_GameBuilder)
        {
            Row = i_GameBuilder.GetRow();
            Col = i_GameBuilder.GetCol();
            Player1Name = i_GameBuilder.GetPlayer1Name();
            Player2Name = i_GameBuilder.GetPlayer2Name();
            IsComputerPlaying = i_GameBuilder.GetIsComputerPlaying();
        }
    }
}
