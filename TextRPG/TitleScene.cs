using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class TitleScene : Scene
    {

        

        public override void Render()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("**            레전드 RPG            **");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임 종료");
        }

        public override void Wait() { }

        public override void Next()
        {
            // TODO : 다음 신-으로 전환 구현 필요
        }
    }
}
