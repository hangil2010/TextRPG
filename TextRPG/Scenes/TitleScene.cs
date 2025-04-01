using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("**         Fallout Classic          **");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("1. 새 게임 시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임 종료");
        }

        public override void Wait() { }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Create");
                    break;
            }
        }
    }
}
