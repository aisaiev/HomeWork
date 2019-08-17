using HomeWork.Enum;
using HomeWork.Menu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    public class GameLogic
    {
        private int speed;

        private int score;

        private Drawer drawer;

        private Stopwatch stopwatch;

        private ConsoleMenu mainMenu;

        private ConsoleColor MyCarColor { get; set; } = ConsoleColor.Gray;

        public void Run()
        {
            Console.Title = "Console Racing";
            Console.CursorVisible = false;

            string mainMenuHeader = "  _____                      _        _____            _             " +
                Environment.NewLine + " / ____|                    | |      |  __ \\          (_)            " +
                Environment.NewLine + "| |     ___  _ __  ___  ___ | | ___  | |__) |__ _  ___ _ _ __   __ _ " +
                Environment.NewLine + "| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\ |  _  // _` |/ __| | '_ \\ / _` |" +
                Environment.NewLine + "| |___| (_) | | | \\__ \\ (_) | |  __/ | | \\ \\ (_| | (__| | | | | (_| |" +
                Environment.NewLine + " \\_____\\___/|_| |_|___/\\___/|_|\\___| |_|  \\_\\__,_|\\___|_|_| |_|\\__, |" +
                Environment.NewLine + "                                                                __/ |" +
                Environment.NewLine + "                                                               |___/ ";
            string optionsMenuHeader = "  ____        _   _                 " +
                Environment.NewLine + " / __ \\      | | (_)                " +
                Environment.NewLine + "| |  | |_ __ | |_ _  ___  _ __  ___ " +
                Environment.NewLine + "| |  | | '_ \\| __| |/ _ \\| '_ \\/ __|" +
                Environment.NewLine + "| |__| | | ) | |_| | ( ) | | | \\__ \\" +
                Environment.NewLine + " \\____/| .__/ \\__|_|\\___/|_| |_|___/" +
                Environment.NewLine + "       | |                          " +
                Environment.NewLine + "       |_|                         ";
            string exitMenuHeader = " ______      _ _   " +
                Environment.NewLine + "|  ____|    (_) |  " +
                Environment.NewLine + "| |__  __  ___| |_ " +
                Environment.NewLine + "|  __| \\ \\/ / | __|" +
                Environment.NewLine + "| |____ >  <| | |_ " +
                Environment.NewLine + "|______/_/\\_\\_|\\__|";

            this.mainMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- MENU ----------------------",
                ParentMenu = mainMenu,
                Header = mainMenuHeader
            };
            ConsoleMenu gameLevelMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- LEVEL ----------------------",
                ParentMenu = mainMenu,
                Header = mainMenuHeader
            };
            ConsoleMenu optionsMenu = new ConsoleMenu()
            {
                SubTitle = "---------------- OPTIONS -----------------",
                ParentMenu = mainMenu,
                Header = optionsMenuHeader
            };
            ConsoleMenu changeCarColorMenu = new ConsoleMenu()
            {
                SubTitle = "---------------- OPTIONS -----------------",
                ParentMenu = optionsMenu,
                Header = optionsMenuHeader
            };
            ConsoleMenu exitMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- EXIT ----------------------",
                Header = exitMenuHeader
            };

            changeCarColorMenu.AddMenuItem(0, "Blue", () => this.SetMyCarColor(changeCarColorMenu, 9));
            changeCarColorMenu.AddMenuItem(1, "Gray", () => this.SetMyCarColor(changeCarColorMenu, 7));
            changeCarColorMenu.AddMenuItem(2, "Green", () => this.SetMyCarColor(changeCarColorMenu, 10));
            changeCarColorMenu.AddMenuItem(3, "Red", () => this.SetMyCarColor(changeCarColorMenu, 12));
            changeCarColorMenu.AddMenuItem(4, "White", () => this.SetMyCarColor(changeCarColorMenu, 15));
            changeCarColorMenu.AddMenuItem(5, "Yellow", () => this.SetMyCarColor(changeCarColorMenu, 14));
            changeCarColorMenu.AddMenuItem(6, "Back to options", changeCarColorMenu.HideMenu);

            optionsMenu.AddMenuItem(0, "Change car color", changeCarColorMenu.ShowMenu);
            optionsMenu.AddMenuItem(1, "Back to main menu", optionsMenu.HideMenu);

            gameLevelMenu.AddMenuItem(0, "Can I play, Daddy?", () => this.StartGame(GameLevel.CanIPlayDaddy));
            gameLevelMenu.AddMenuItem(1, "Bring 'em on!", () => this.StartGame(GameLevel.BringEmOn));
            gameLevelMenu.AddMenuItem(2, "I am Death incarnate!", () => this.StartGame(GameLevel.IAmDeathIncarnate));
            gameLevelMenu.AddMenuItem(3, "Back to main menu", gameLevelMenu.HideMenu);

            exitMenu.AddMenuItem(0, "Yes", this.Exit);
            exitMenu.AddMenuItem(1, "No", exitMenu.HideMenu);

            mainMenu.AddMenuItem(0, "Start", gameLevelMenu.ShowMenu);
            mainMenu.AddMenuItem(1, "Options", optionsMenu.ShowMenu);
            mainMenu.AddMenuItem(2, "Exit", exitMenu.ShowMenu);

            mainMenu.ShowMenu();
        }

        private void StartGame(GameLevel gameLevel)
        {
            Console.Clear();
            Console.CursorVisible = false;
            this.score = 0;
            this.drawer = new Drawer();
            this.drawer.DrawCountDown();
            this.stopwatch = new Stopwatch();
            this.stopwatch.Start();
            Field field = new Field(
                new RoadBorder(ConsoleColor.DarkGreen, '#'),
                new MyCar(this.MyCarColor, 'x'),
                new List<Figure>
                {
                    new OtherCar(this.GenerateColor(), '*')
                });
            if (gameLevel == GameLevel.CanIPlayDaddy)
            {
                this.drawer.DrawGameLevel(field, "Can I play, Daddy?");
                this.speed = 150;
            }
            else if (gameLevel == GameLevel.BringEmOn)
            {
                this.drawer.DrawGameLevel(field, "Bring 'em on!");
                this.speed = 120;
            }
            else
            {
                this.drawer.DrawGameLevel(field, "I am Death incarnate!");
                this.speed = 30;
            }
            do
            {
                field.kbh.QueryKbH();
                TimeSpan timeSpan = stopwatch.Elapsed;
                Thread drawTimeInGameThread = new Thread(() =>
                {
                    this.drawer.DrawTimeInGame(field, timeSpan);
                });
                Thread drawScoreThread = new Thread(() =>
                {
                    this.drawer.DrawScore(field, this.score);
                });
                Thread drawFigureThread = new Thread(() =>
                {
                    this.drawer.DrawFigure(field.roadBorder);
                });
                drawTimeInGameThread.Start();
                drawScoreThread.Start();
                drawFigureThread.Start();
                Thread.Sleep(this.speed);
                field.roadBorder.Move(MoveDirection.Down);
                foreach (var otherCar in new List<Figure>(field.otherCars))
                {
                    otherCar.Move(MoveDirection.Down);
                    this.drawer.DrawFigure(otherCar, field);

                    Node highestOtherCarNode = otherCar.nodes.OrderBy(node => node.Y).FirstOrDefault();
                    if (highestOtherCarNode != null)
                    {
                        if (highestOtherCarNode.Y == 4)
                        {
                            field.otherCars.Add(new OtherCar(this.GenerateColor(), '*'));
                            field.otherCars[field.otherCars.Count - 1].InitializeState();
                            this.score += 10;
                            if (gameLevel == GameLevel.BringEmOn && this.score % 100 == 0)
                            {
                                this.speed -= 10;
                            }
                        }
                    }
                    if (otherCar.nodes.Count == 0)
                    {
                        field.otherCars.Remove(otherCar);
                    }
                }
            } while (!field.IsMyCarOnAnotherCar());
            this.drawer.DrawGameOver(field);
            Console.ReadLine();
            this.mainMenu.ShowMenu();
        }

        private ConsoleColor GenerateColor()
        {
            switch (new Random().Next(1, 16))
            {
                case (int)ConsoleColor.DarkBlue:
                    return ConsoleColor.DarkBlue;
                case (int)ConsoleColor.DarkGreen:
                    return ConsoleColor.DarkGreen;
                case (int)ConsoleColor.DarkCyan:
                    return ConsoleColor.DarkCyan;
                case (int)ConsoleColor.DarkRed:
                    return ConsoleColor.DarkRed;
                case (int)ConsoleColor.DarkMagenta:
                    return ConsoleColor.DarkMagenta;
                case (int)ConsoleColor.DarkYellow:
                    return ConsoleColor.DarkYellow;
                case (int)ConsoleColor.Gray:
                    return ConsoleColor.Gray;
                case (int)ConsoleColor.DarkGray:
                    return ConsoleColor.DarkGray;
                case (int)ConsoleColor.Blue:
                    return ConsoleColor.Blue;
                case (int)ConsoleColor.Green:
                    return ConsoleColor.Green;
                case (int)ConsoleColor.Cyan:
                    return ConsoleColor.Cyan;
                case (int)ConsoleColor.Red:
                    return ConsoleColor.Red;
                case (int)ConsoleColor.Magenta:
                    return ConsoleColor.Magenta;
                case (int)ConsoleColor.Yellow:
                    return ConsoleColor.Yellow;
                case (int)ConsoleColor.White:
                    return ConsoleColor.White;
            }
            return ConsoleColor.Gray;
        }

        private void SetMyCarColor(ConsoleMenu menu, int color)
        {
            this.MyCarColor = (ConsoleColor)color;
            menu.HideMenu();
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
