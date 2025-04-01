using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Scenes;

namespace TextRPG
{
    public class Game
    {
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player = new Player();
        public static Player Player { get; set; }
        // 게임에 필요한 정보들

        // 게임에 필요한 기능들
        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Create", new CreateCharScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());
            curScene = sceneDic["Title"];
        }
        public static void Run()
        {
            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }

        public static void End()
        {
            // 게임 종료시 피룡한 기능들
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("**            게임 오버..           **");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("**************************************");
            PrintSpecial();
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }

        public static void SetSpecial()
        {
            Console.WriteLine("힘은 근접 무기 피해량과 인벤토리 크기에 관여합니다");
            Console.WriteLine("특정 무기는 일정 힘를 넘겨야 착용이 가능합니다");
            player.Str = Util.IntInput(1, 10);
            Console.Clear();

            PrintSpecial();
            Console.WriteLine("감각은 총기 명중률과 시야 넓이에 관여합니다");
            Console.WriteLine("능력치를 높일수록 적을 더 멀리서 맞출 수 있습니다.");
            player.Per = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("근성은 최대 체력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 체력이 증가합니다.");
            player.End = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("매력은 사람들과 대화 및 거래 능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 대화에서 이점을 챙길 수 있습니다.");
            player.Cha = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("지능은 경험치와 레벨업때 획득할 능력치에 관여합니다");
            Console.WriteLine("능력치를 높일수록 레벨을 더 빨리 업할 수 있습니다.");
            player._Int = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("민첩은 플레이어의 이동능력에 관여합니다");
            Console.WriteLine("능력치를 높일수록 더 빠르게 움직일 수 있습니다.");
            player.Agl = Util.IntInput(1, 10);

            Console.Clear();
            PrintSpecial();
            Console.WriteLine("행운은 인게임 전반적인 운에 관여합니다");
            Console.WriteLine("능력치를 높일수록 운이 더 좋아집니다.");
            player.Luk = Util.IntInput(1, 10);

            Console.Clear();
            Console.WriteLine("최종 능력치");
            PrintSpecial();
        }

        public static void PrintSpecial()
        {
            Console.WriteLine($"힘 : {player.Str}, 감각 : {player.Per}, 근성 : {player.End}, 매력 : {player.Cha}, 지능 : {player._Int}, 민첩 : {player.Agl}, 행운 : {player.Luk}");
        }
    }
}
