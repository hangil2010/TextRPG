using System;
using System.Collections.Generic;
using System.Linq;
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

        private static Player player;
        public static Player Player { get; }
        // 게임에 필요한 정보들

        // 게임에 필요한 기능들
        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());

            curScene = sceneDic["Title"];

            player = new Player();
            player.Power = 10;
            player.Speed = 5;
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
            Console.WriteLine($"**    힘 : {player.Power}\t 속도 : {player.Speed}     **");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }
    }
}
