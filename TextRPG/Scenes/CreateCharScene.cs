using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    class CreateCharScene : Scene
    {
        public override void Choice()
        {
            Game.SetSpecial();
        }

        public override void Next()
        {
            Game.ChangeScene("Town");
        }

        public override void Render()
        {
            Console.WriteLine("새로운 캐릭터 생성을 시작합니다.");
            Console.WriteLine("S.P.E.C.I.A.L 능력치를 설정합니다.");
        }

        public override void Result() { }

        public override void Wait() { }
    }
}
