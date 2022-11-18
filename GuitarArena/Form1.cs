using System;
using System.Media;
using System.Windows.Forms;


namespace GuitarArena //atualizar a resolução do timer principal
{
    public partial class GuitarMain : Form
    {
        private int noteSpeed = 10;
        private double ticks = 0.000;
        private int intervalFirstPart1 = -660;
        private SoundPlayer _soundPlayer;
        private int PlayerPoints;
        bool aPress, sPress, jPress, kPress, lPress, isGameOver;

        public GuitarMain()
        {
            InitializeComponent();
            resetGame();
        }

        //TIMER PRINCIPAL
        private void mainGameTimer(object sender, EventArgs e)
        {
            if (ticks == 1.000 || ticks == 71.500)
            {
                NotesFirstPartInit();
                firstPart.Start();
            }

            else if (ticks == 49.500 || ticks == 121.000)
            {
                firstPart.Stop();
                NotesFirstPartInit();
            }

            else if (ticks == 47.875 || ticks == 67.500)
            {
                PreChorusInit();
                preChorusPartTimer.Start();
            }

            else if (ticks == 57 || ticks == 76)
                preChorusPartTimer.Stop();

            else if (ticks == 51.625)
            {
                ChorusInit();
                chorusPartTimer.Start();
            }

            //-------------------------------------------------------

            ticks += 0.125; //por algum motivo, n é possivel colocar a implementação usando um numero
                            //menor que 0.125. Parece que o compilador n tem tempo suficiente de terminar as operacoes booleanas..
            textTeste.Text = ticks.ToString("0.000");
            if (ticks == 3.125)
            {
                _soundPlayer.Play();
            }

            //LOGICA PARA SCORE DO JOGADOR

            scorePlayer();

            if (PlayerPoints <= 0)
                GameOver();
            
            
            
            fireCheck();

        }

        //METODOS PARA INICIAR AS NOTAS: -----

        private void NotesFirstPartInit()
        {
            greenNote1.Left = 190;
            redNote1.Left = 280;
            yellowNote1.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            blueNote3.Left = 465;
            orangeNote1.Left = 560;

            blueNote1.Top = -290;
            blueNote2.Top = -550;
            blueNote3.Top = -770;
            orangeNote1.Top = -670;
            yellowNote1.Top = -840;
            redNote1.Top = -970;
            greenNote1.Top = -1290;
        }

        private void PreChorusInit()
        {
            greenNote2.Left = 190;
            greenNote3.Left = 190;
            greenNote4.Left = 190;
            greenNote5.Left = 190;
            greenNote6.Left = 190;
            greenNote7.Left = 190;
            greenNote8.Left = 190;
            greenNote9.Left = 190;

            redNote2.Left = 280;
            redNote3.Left = 280;
            redNote4.Left = 280;
            redNote5.Left = 280;
            redNote6.Left = 280;
            redNote7.Left = 280;
            redNote8.Left = 280;
            redNote9.Left = 280;

            blueNote4.Left = 465;
            blueNote5.Left = 465;
            blueNote6.Left = 465;
            blueNote7.Left = 465;
            blueNote8.Left = 465;
            blueNote9.Left = 465;
            blueNote10.Left = 465;
            blueNote11.Left = 465;

            orangeNote2.Left = 560;
            orangeNote3.Left = 560;
            orangeNote4.Left = 560;
            orangeNote5.Left = 560;
            orangeNote6.Left = 560;
            orangeNote7.Left = 560;
            orangeNote8.Left = 560;
            orangeNote9.Left = 560;

            //Top--------------------
            greenNote2.Top = -210;
            greenNote3.Top = -300;
            greenNote4.Top = -390;
            greenNote5.Top = -480;
            greenNote6.Top = -570;
            greenNote7.Top = -660;
            greenNote8.Top = -750;
            greenNote9.Top = -840;

            redNote2.Top = -860;
            redNote3.Top = -950;
            redNote4.Top = -1040;
            redNote5.Top = -1130;
            redNote6.Top = -1220;
            redNote7.Top = -1310;
            redNote8.Top = -1400;
            redNote9.Top = -1490;

            blueNote4.Top = -860;
            blueNote5.Top = -950;
            blueNote6.Top = -1040;
            blueNote7.Top = -1130;
            blueNote8.Top = -1220;
            blueNote9.Top = -1310;
            blueNote10.Top = -1400;
            blueNote11.Top = -1490;

            orangeNote2.Top = -210;
            orangeNote3.Top = -300;
            orangeNote4.Top = -390;
            orangeNote5.Top = -480;
            orangeNote6.Top = -570;
            orangeNote7.Top = -660;
            orangeNote8.Top = -750;
            orangeNote9.Top = -840;
        }

        private void ChorusInit()
        {
            //LEFT ---------------------------------------
            #region left;

            greenNote10.Left = 190;
            greenNote11.Left = 190;
            greenNote12.Left = 190;
            greenNote13.Left = 190;
            greenNote14.Left = 190;

            redNote10.Left = 280;
            redNote11.Left = 280;
            redNote12.Left = 280;
            redNote13.Left = 280;

            yellowNote2.Left = 368;
            yellowNote3.Left = 368;
            yellowNote4.Left = 368;
            yellowNote5.Left = 368;
            yellowNote6.Left = 368;

            blueNote12.Left = 465;
            blueNote13.Left = 465;
            blueNote14.Left = 465;
            blueNote15.Left = 465;
            blueNote16.Left = 465;

            orangeNote10.Left = 560;
            orangeNote11.Left = 560;
            orangeNote12.Left = 560;
            orangeNote13.Left = 560;
            orangeNote14.Left = 560;
            orangeNote15.Left = 560;
            orangeNote16.Left = 560;
            orangeNote17.Left = 560;
            orangeNote18.Left = 560;
            orangeNote19.Left = 560;

            #endregion;

            //TOP ----------------------------------------
            orangeNote10.Top = -290;    //1
            blueNote12.Top = -290;

            orangeNote11.Top = -550;    //2
            blueNote13.Top = -550;

            redNote10.Top = -670;       //3
            greenNote10.Top = -670;

            yellowNote2.Top = -770;     //4

            yellowNote3.Top = -840;     //5
            orangeNote12.Top = -840;

            greenNote11.Top = -970;     //6

            redNote11.Top = -1290;      //7

            orangeNote13.Top = -1390;   //8

            orangeNote14.Top = -1490;   //9

            //-------------------------------

            orangeNote15.Top = -1540;   //1
            blueNote14.Top = -1540;

            orangeNote16.Top = -1800;   //2
            blueNote15.Top = -1800;

            orangeNote17.Top = -1920;   //3
            yellowNote4.Top = -1920;

            greenNote12.Top = -2020;    //4

            redNote12.Top = -2090;      //5

            orangeNote18.Top = -2220;   //6
            yellowNote5.Top = -2220;

            greenNote13.Top = -2327;    //7

            orangeNote19.Top = -2434;   //8

            blueNote16.Top = -2540;     //9
            yellowNote6.Top = -2540;

            greenNote14.Top = -2640;    //10
            redNote13.Top = -2640;
        }

        //TIMERS ----------------------------

        private void firstPartTimerSong(object sender, EventArgs e)
        {

            if ((ticks < 46.000) || (ticks > 70.000 && ticks < 116.750))
            {
                if (blueNote1.Top > 570)
                    blueNote1.Top = intervalFirstPart1;

                else if (blueNote2.Top > 570)
                    blueNote2.Top = intervalFirstPart1;

                else if (blueNote3.Top > 570)
                    blueNote3.Top = intervalFirstPart1;

                else if (orangeNote1.Top > 570)
                    orangeNote1.Top = intervalFirstPart1;

                else if (yellowNote1.Top > 570)
                    yellowNote1.Top = intervalFirstPart1;

                else if (redNote1.Top > 570)
                    redNote1.Top = intervalFirstPart1;

                else if (greenNote1.Top > 570)
                    greenNote1.Top = intervalFirstPart1;

            }

            greenNote1.Top += noteSpeed;
            redNote1.Top += noteSpeed;
            yellowNote1.Top += noteSpeed;
            blueNote1.Top += noteSpeed;
            blueNote2.Top += noteSpeed;
            blueNote3.Top += noteSpeed;
            orangeNote1.Top += noteSpeed;
        }

        private void preChorusTimerSong(object sender, EventArgs e)
        {
            greenNote2.Top += noteSpeed;
            greenNote3.Top += noteSpeed;
            greenNote4.Top += noteSpeed;
            greenNote5.Top += noteSpeed;
            greenNote6.Top += noteSpeed;
            greenNote7.Top += noteSpeed;

            redNote2.Top += noteSpeed;
            redNote3.Top += noteSpeed;
            redNote4.Top += noteSpeed;
            redNote5.Top += noteSpeed;
            redNote6.Top += noteSpeed;
            redNote7.Top += noteSpeed;

            blueNote4.Top += noteSpeed;
            blueNote5.Top += noteSpeed;
            blueNote6.Top += noteSpeed;
            blueNote7.Top += noteSpeed;
            blueNote8.Top += noteSpeed;
            blueNote9.Top += noteSpeed;

            orangeNote2.Top += noteSpeed;
            orangeNote3.Top += noteSpeed;
            orangeNote4.Top += noteSpeed;
            orangeNote5.Top += noteSpeed;
            orangeNote6.Top += noteSpeed;
            orangeNote7.Top += noteSpeed;
        }

        private void chorusTimerSong(object sender, EventArgs e)
        {
            if (ticks < 62.000)
            {
                if (orangeNote10.Top > 570)
                {
                    orangeNote10.Top = -1930;
                    blueNote12.Top = -1930;
                }

                else if (orangeNote11.Top > 570)
                {
                    orangeNote11.Top = -1930;
                    blueNote13.Top = -1930;
                }

                else if (redNote10.Top > 570)
                {
                    redNote10.Top = -1930;
                    greenNote10.Top = -1930;
                }

                else if (yellowNote2.Top > 570)
                    yellowNote2.Top = -1930;

                else if (yellowNote3.Top > 570)
                {
                    yellowNote3.Top = -1930;
                    orangeNote12.Top = -1930;
                }

                else if (greenNote11.Top > 570)
                    greenNote11.Top = -1930;

                else if (redNote11.Top > 570)
                    redNote11.Top = -1930;

                else if (orangeNote13.Top > 570)
                    orangeNote13.Top = -1930;

                else if (orangeNote14.Top > 570)
                    orangeNote14.Top = -1930;

                //---

                else if (orangeNote15.Top > 570)
                {
                    orangeNote15.Top = -1930;
                    blueNote14.Top = -1930;
                }

                else if (orangeNote16.Top > 570)
                {
                    orangeNote16.Top = -1930;
                    blueNote15.Top = -1930;
                }

                else if (orangeNote17.Top > 570)
                {
                    orangeNote17.Top = -1930;
                    yellowNote4.Top = -1930;
                }

                else if (greenNote12.Top > 570)
                    greenNote12.Top = -1930;

                else if (redNote12.Top > 570)
                    redNote12.Top = -1930;

                else if (orangeNote18.Top > 570)
                {
                    orangeNote18.Top = -1930;
                    yellowNote5.Top = -1930;
                }

                else if (greenNote13.Top > 570)
                    greenNote13.Top = -1930;

                else if (orangeNote19.Top > 570)
                    orangeNote19.Top = -1930;

                else if (blueNote16.Top > 570)
                {
                    blueNote16.Top = -1930;
                    yellowNote6.Top = -1930;
                }

                else if (greenNote14.Top > 570)
                {
                    greenNote14.Top = -1930;
                    redNote13.Top = -1930;
                }
            }

            greenNote10.Top += noteSpeed;
            greenNote11.Top += noteSpeed;
            greenNote12.Top += noteSpeed;
            greenNote13.Top += noteSpeed;
            greenNote14.Top += noteSpeed;

            redNote10.Top += noteSpeed;
            redNote11.Top += noteSpeed;
            redNote12.Top += noteSpeed;
            redNote13.Top += noteSpeed;

            yellowNote2.Top += noteSpeed;
            yellowNote3.Top += noteSpeed;
            yellowNote4.Top += noteSpeed;
            yellowNote5.Top += noteSpeed;
            yellowNote6.Top += noteSpeed;

            blueNote12.Top += noteSpeed;
            blueNote13.Top += noteSpeed;
            blueNote14.Top += noteSpeed;
            blueNote15.Top += noteSpeed;
            blueNote16.Top += noteSpeed;

            orangeNote10.Top += noteSpeed;
            orangeNote11.Top += noteSpeed;
            orangeNote12.Top += noteSpeed;
            orangeNote13.Top += noteSpeed;
            orangeNote14.Top += noteSpeed;
            orangeNote15.Top += noteSpeed;
            orangeNote16.Top += noteSpeed;
            orangeNote17.Top += noteSpeed;
            orangeNote18.Top += noteSpeed;
            orangeNote19.Top += noteSpeed;
        }

        //LOGICA PARA PONTUAÇÃO
        private void scorePlayer()
        {
            //Verde
            if (aPress && (greenNote1.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote2.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote3.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote4.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote5.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote6.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote7.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote8.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote9.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote10.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote11.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote12.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote13.Bounds.IntersectsWith(greenCheck.Bounds) ||
                           greenNote14.Bounds.IntersectsWith(greenCheck.Bounds)))
                PlayerPoints++;

            if (aPress && (!greenNote1.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote2.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote3.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote4.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote5.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote6.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote7.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote8.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote9.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote10.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote11.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote12.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote13.Bounds.IntersectsWith(greenCheck.Bounds) &&
                           !greenNote14.Bounds.IntersectsWith(greenCheck.Bounds)))
                PlayerPoints--;

            if (!aPress && (greenNote1.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote2.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote3.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote4.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote5.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote6.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote7.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote8.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote9.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote10.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote11.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote12.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote13.Bounds.IntersectsWith(greenCheck.Bounds) ||
                            greenNote14.Bounds.IntersectsWith(greenCheck.Bounds)))
                PlayerPoints--;

            //Vermelho

            if (sPress && (redNote1.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote2.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote3.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote4.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote5.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote6.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote7.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote8.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote9.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote10.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote11.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote12.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote13.Bounds.IntersectsWith(redCheck.Bounds)))
                PlayerPoints++;

            if (sPress && (!redNote1.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote2.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote3.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote4.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote5.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote6.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote7.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote8.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote9.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote10.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote11.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote12.Bounds.IntersectsWith(redCheck.Bounds) &&
                           !redNote13.Bounds.IntersectsWith(redCheck.Bounds)))
                PlayerPoints--;

            if (!sPress && (redNote1.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote2.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote3.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote4.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote5.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote6.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote7.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote8.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote9.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote10.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote11.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote12.Bounds.IntersectsWith(redCheck.Bounds) ||
                           redNote13.Bounds.IntersectsWith(redCheck.Bounds)))
                PlayerPoints--;

            //Amarelo

            if (jPress && (yellowNote1.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote2.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote3.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote4.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote5.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote6.Bounds.IntersectsWith(yellowCheck.Bounds)))
                PlayerPoints++;

            if (jPress && (!yellowNote1.Bounds.IntersectsWith(yellowCheck.Bounds) &&
                           !yellowNote2.Bounds.IntersectsWith(yellowCheck.Bounds) &&
                           !yellowNote3.Bounds.IntersectsWith(yellowCheck.Bounds) &&
                           !yellowNote4.Bounds.IntersectsWith(yellowCheck.Bounds) &&
                           !yellowNote5.Bounds.IntersectsWith(yellowCheck.Bounds) &&
                           !yellowNote6.Bounds.IntersectsWith(yellowCheck.Bounds)))
                PlayerPoints--;

            if (!jPress && (yellowNote1.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote2.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote3.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote4.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote5.Bounds.IntersectsWith(yellowCheck.Bounds) ||
                           yellowNote6.Bounds.IntersectsWith(yellowCheck.Bounds)))
                PlayerPoints--;

            //Azul

            if (kPress && (blueNote1.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote2.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote3.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote4.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote5.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote6.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote7.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote8.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote9.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote10.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote11.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote12.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote13.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote14.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote15.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote16.Bounds.IntersectsWith(blueCheck.Bounds)))
                PlayerPoints++;

            if (kPress && (!blueNote1.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote2.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote3.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote4.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote5.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote6.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote7.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote8.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote9.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote10.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote11.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote12.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote13.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote14.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote15.Bounds.IntersectsWith(blueCheck.Bounds) &&
                           !blueNote16.Bounds.IntersectsWith(blueCheck.Bounds)))
                PlayerPoints--;

            if (!kPress && (blueNote1.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote2.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote3.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote4.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote5.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote6.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote7.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote8.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote9.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote10.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote11.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote12.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote13.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote14.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote15.Bounds.IntersectsWith(blueCheck.Bounds) ||
                           blueNote16.Bounds.IntersectsWith(blueCheck.Bounds)))
                PlayerPoints--;
            //Laranja

            if (lPress && (orangeNote1.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote2.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote3.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote4.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote5.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote6.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote7.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote8.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote9.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote10.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote11.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote12.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote13.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote14.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote15.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote16.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote17.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote18.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote19.Bounds.IntersectsWith(orangeCheck.Bounds)))
                PlayerPoints++;

            if (lPress && (!orangeNote1.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote2.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote3.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote4.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote5.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote6.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote7.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote8.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote9.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote10.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote11.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote12.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote13.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote14.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote15.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote16.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote17.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote18.Bounds.IntersectsWith(orangeCheck.Bounds) &&
                           !orangeNote19.Bounds.IntersectsWith(orangeCheck.Bounds)))
                PlayerPoints--;

            if (!lPress && (orangeNote1.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote2.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote3.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote4.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote5.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote6.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote7.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote8.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote9.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote10.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote11.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote12.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote13.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote14.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote15.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote16.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote17.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote18.Bounds.IntersectsWith(orangeCheck.Bounds) ||
                           orangeNote19.Bounds.IntersectsWith(orangeCheck.Bounds)))
                PlayerPoints--;
            //fim da logica dos pontos.


            scoreTxt.Text = PlayerPoints.ToString();
        }

        private void fireCheck()
        {
            if (aPress)
            {
                fireCheck1.Top = 501;
                fireCheck1.Left = 191;
            }

            if (!aPress)
                fireCheck1.Top = -501;

            if (sPress)
            {
                fireCheck2.Top = 501;
                fireCheck2.Left = 277;
            }

            if (!sPress)
                fireCheck2.Top = -501;

            if (jPress)
            {
                fireCheck3.Top = 501;
                fireCheck3.Left = 370;
            }

            if (!jPress)
                fireCheck3.Top = -501;

            if (kPress)
            {
                fireCheck4.Top = 501;
                fireCheck4.Left = 460;
            }

            if (!kPress)
                fireCheck4.Top = -501;

            if (lPress)
            {
                fireCheck5.Top = 501;
                fireCheck5.Left = 552;
            }

            if (!lPress)
                fireCheck5.Top = -501;


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                aPress = true;

            if (e.KeyCode == Keys.S)
                sPress = true;

            if (e.KeyCode == Keys.J)
                jPress = true;

            if (e.KeyCode == Keys.K)
                kPress = true;

            if (e.KeyCode == Keys.L)
                lPress = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                aPress = false;

            if (e.KeyCode == Keys.S)
                sPress = false;

            if (e.KeyCode == Keys.J)
                jPress = false;

            if (e.KeyCode == Keys.K)
                kPress = false;

            if (e.KeyCode == Keys.L)
                lPress = false;

            if (e.KeyCode == Keys.Enter && isGameOver == true)
                resetGame();
        }

        //RESET
        private void notesReset()
        {
            greenNote1.Top = -500;
            greenNote2.Top = -500;
            greenNote3.Top = -500;
            greenNote4.Top = -500;
            greenNote5.Top = -500;
            greenNote6.Top = -500;
            greenNote7.Top = -500;
            greenNote8.Top = -500;
            greenNote9.Top = -500;
            greenNote10.Top = -500;
            greenNote11.Top = -500;
            greenNote12.Top = -500;
            greenNote13.Top = -500;
            greenNote14.Top = -500;

            redNote1.Top = -500;
            redNote2.Top = -500;
            redNote3.Top = -500;
            redNote4.Top = -500;
            redNote5.Top = -500;
            redNote6.Top = -500;
            redNote7.Top = -500;
            redNote8.Top = -500;
            redNote9.Top = -500;
            redNote10.Top = -500;
            redNote11.Top = -500;
            redNote12.Top = -500;
            redNote13.Top = -500;

            yellowNote1.Top = -500;
            yellowNote2.Top = -500;
            yellowNote3.Top = -500;
            yellowNote4.Top = -500;
            yellowNote5.Top = -500;
            yellowNote6.Top = -500;

            blueNote1.Top = -500;
            blueNote2.Top = -500;
            blueNote3.Top = -500;
            blueNote4.Top = -500;
            blueNote5.Top = -500;
            blueNote6.Top = -500;
            blueNote7.Top = -500;
            blueNote8.Top = -500;
            blueNote9.Top = -500;
            blueNote10.Top = -500;
            blueNote11.Top = -500;
            blueNote12.Top = -500;
            blueNote13.Top = -500;
            blueNote14.Top = -500;
            blueNote15.Top = -500;
            blueNote16.Top = -500;

            orangeNote1.Top = -500;
            orangeNote2.Top = -500;
            orangeNote3.Top = -500;
            orangeNote4.Top = -500;
            orangeNote5.Top = -500;
            orangeNote6.Top = -500;
            orangeNote7.Top = -500;
            orangeNote8.Top = -500;
            orangeNote9.Top = -500;
            orangeNote10.Top = -500;
            orangeNote11.Top = -500;
            orangeNote12.Top = -500;
            orangeNote13.Top = -500;
            orangeNote14.Top = -500;
            orangeNote15.Top = -500;
            orangeNote16.Top = -500;
            orangeNote17.Top = -500;
            orangeNote18.Top = -500;
            orangeNote19.Top = -500;

            fireCheck1.Top = -500;
            fireCheck2.Top = -500;
            fireCheck3.Top = -500;
            fireCheck4.Top = -500;
            fireCheck5.Top = -500;

        }

        private void resetGame()
        {
            notesReset();
            PlayerPoints = 50;
            ticks = 0.000;
            SongTimer.Start();
            _soundPlayer = new SoundPlayer("Seven_Nation.wav");

            
        }

        private void GameOver()
        {

            isGameOver = true;
            SongTimer.Stop();
            firstPart.Stop();
            preChorusPartTimer.Stop();
            chorusPartTimer.Stop();
            _soundPlayer.Stop();
        }
    }
}

