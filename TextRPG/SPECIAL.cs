using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class SPECIAL
    {
        public int[] stats = new int[7]; 

        public void SetSpecial()
        {
            Console.WriteLine("새로운 캐릭터를 생성합니다");
            Console.WriteLine("우선 S.P.E.C.I.A.L 능력치를 설정합니다.");
            Console.WriteLine("Strength, 줄여서 STR는 근접 무기 피해량과 인벤토리 크기에 관여합니다");
            Console.WriteLine("특정 무기는 일정 STR를 넘겨야 착용이 가능합니다");
            stats[0] = Util.IntInput(1, 10);
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("Perception, 줄여서 PER는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 적을 더 멀리서 맞출 수 있습니다.");
            stats[1] = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Endurance, 줄여서 END는 최대 체력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 체력이 증가합니다.");
            stats[2] = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Charisma, 줄여서 CHA는 사람들과 대화 및 거래 능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 대화에서 이점을 챙길 수 있습니다.");
            stats[3] = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Intelligence, 줄여서 INT는 경험치와 레벨업때 획득할 능력치에 관여합니다");
            Console.WriteLine("능력치를 높일수록 레벨을 더 빨리 업할 수 있습니다.");
            stats[4] = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Agility, 줄여서 AGL는 플레이어의 이동능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 더 빠르게 움직일 수 있습니다.");
            stats[5] = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("Luck, 줄여서 LUK는 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 운이 더 좋아집니다.");
            stats[6] = Util.IntInput(1, 10);

            Console.Clear();
            Console.WriteLine("최종 능력치");
            PrintSpecial();
        }

        public void PrintSpecial()
        {
            Console.WriteLine($"STR : {stats[0]}, PER : {stats[1]}, END : {stats[2]}, CHA : {stats[3]}, INT : {stats[4]}, AGL : {stats[5]}, LUK : {stats[6]}");
        }
    }
}
