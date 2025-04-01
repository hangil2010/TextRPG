using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class TownScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 상인에게 간다");
            Console.WriteLine("2. 수상한 남성을 주시한다");
            Console.WriteLine("3. 필드로 나간다");
        }

        public override void Render()
        {
            Console.WriteLine("사람들이 북적거리는 마을이다...");
            Console.WriteLine("여러 상인들이 물건들을 팔고 있다...");
            Console.WriteLine("멀리서는 수상해 보이는 남성이 눈치를 보고 있다");
            Console.WriteLine();
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("상인에게 접근합니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("수상한 남성을 주시하고 있었습니다.");
                    Console.WriteLine("수상한 남성의 부하가 뒤에서 나타나 기습하였습니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("필드로 나갑니다");
                    break;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무 키나 눌러주세요...");
            Console.ReadKey();
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}
