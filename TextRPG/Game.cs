using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Game
    {
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;
        // 게임에 필요한 정보들

        // 게임에 필요한 기능들
        public static void Start()
        {
            sceneDic.Add("Title", new TitleScene());
            curScene = sceneDic["Title"];
        }
        public static void End()
        {
            // 게임 종료시 피룡한 기능들
        }
        public static void Run()
        {
            while(gameOver == false)
            {
                curScene.Render();
                curScene.Choice();
                curScene.Input();
                curScene.Result();
            }
        }
    }
}
