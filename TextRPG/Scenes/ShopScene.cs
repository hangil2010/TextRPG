using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public class ShopScene : Scene
    {
        public override void Render()
        {
            Game.PrintInfo();
            Console.WriteLine("\"어서오세요\"");
            Console.WriteLine("\"전부 좋은 물건입니다~\"");
            Console.WriteLine("상점에는 다양한 물건들이 놓여져 있다");
            Console.WriteLine("어떤 물건을 구매하겠습니까?");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 누가봐도 수상한 구슬을 산다");
            Console.WriteLine("2. 상인에게 떠도는 소문이 있는지 묻는다");
            Console.WriteLine("3. 상인을 위협하고 돈을 갈취해본다");
            Console.WriteLine("4. 마을로 돌아갑니다");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 상인을 위협할려고 시도하였습니다");
                    Console.WriteLine("하지만 상인은 과거 용병단의 수장이였습니다");
                    Console.WriteLine("눈 깜짝할 새 기절하였고, 사망하였습니다.");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("마을로 돌아갑니다");
                    break;

                default:
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요");
                    break;
            }
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D4:
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D3:
                    Game.GameOver("이 바닥에서 오래 살았다는 건 강하다는 것");
                    break;
            }
        }

        

        

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무 키나 눌러주세요...");
            Console.ReadKey();
        }
    }
}
