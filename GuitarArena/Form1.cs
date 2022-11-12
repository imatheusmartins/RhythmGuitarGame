using System;
using System.Media;
using System.Windows.Forms;


namespace GuitarArena
{
    public partial class GuitarMain : Form
    {
        private int noteSpeed = 10;
        private int ticks = -3;
        private int intervalFirstPart1 = -680; //variavel de controle da sincronicidade
        private int intervalFirstPart2 = -710; //variavel de controle da sincronicidade
        private SoundPlayer _soundPlayer;
        
        public GuitarMain()
        {
            InitializeComponent();
            SongTimer.Start();
            _soundPlayer = new SoundPlayer("Seven_Nation.wav");
            NotesFirstPartInit1();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            if (ticks < 1)
                firstPart.Start();

           
            
            ticks++;
            textTeste.Text = ticks.ToString();
            if(ticks == 0)
            {
                _soundPlayer.Play();
            }
            
        }

        //METODOS PARA INICAR AS NOTAS:

        private void NotesFirstPartInit1()
        {
            greenNote1.Left = 190;
            redNote1.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            blueNote3.Left = 465;
            orangeNote1.Left = 560;

            blueNote1.Top = -290;
            blueNote2.Top = -550;
            blueNote3.Top = -770;
            orangeNote1.Top = -670;
            yellowNote.Top = -830;
            redNote1.Top = -970;
            greenNote1.Top = -1290;
        }

        private void NotesFirstPartInit2()
        {
            greenNote1.Left = 190;
            redNote1.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            orangeNote1.Left = 562;

            blueNote1.Top = -350;
            blueNote2.Top = -610;
            blueNote3.Top = -830;
            orangeNote1.Top = -730;
            yellowNote.Top = -890;
            redNote1.Top = -1030;
            greenNote1.Top = -1350;
        }

        private void PreNotesChorusPartInit()
        {
            greenNote2.Left = -350;
            greenNote3.Left = -650;
            greenNote4.Left = -950;
            greenNote5.Left = -1250;
            greenNote6.Left = -1550;
            greenNote7.Left = -1850;

            redNote2.Left = -2000;
            redNote3.Left = -2300;
            redNote4.Left = -2600;

            redNote5.Left = -2900;
            redNote6.Left = -3200;
            redNote7.Left = -3500;

            blueNote4.Left = -2000;
            blueNote5.Left = -2300;
            blueNote6.Left = -2600;
            blueNote7.Left = -2900;
            blueNote8.Left = -3200;
            blueNote9.Left = -3500;


            orangeNote2.Left = -350;
            orangeNote3.Left = -650;
            orangeNote4.Left = -950;
            orangeNote5.Left = -1250;
            orangeNote6.Left = -1550;
            orangeNote7.Left = -1850;




        }

        private void NotesChorusPartInit()
        {
            greenNote1.Left = 190;
            redNote1.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            blueNote3.Left = 465;
            orangeNote1.Left = 560;

            blueNote1.Top = -290;
            blueNote2.Top = -550;
            blueNote3.Top = -770;
            orangeNote1.Top = -670;
            yellowNote.Top = -830;
            redNote1.Top = -970;
            greenNote1.Top = -1290;
        }

        //METODOS PARA ANIMACAO:

        private void firstPartSong(object sender, EventArgs e)
        {

            //logica para parar as sequencias em intervalos especificos do tempo principal
            if (ticks < 43)
            {
                if (blueNote1.Top > 550)
                    blueNote1.Top = intervalFirstPart1;

                else if (blueNote2.Top > 550)
                    blueNote2.Top = intervalFirstPart1;

                else if (blueNote3.Top > 550)
                    blueNote3.Top = intervalFirstPart1;

                else if (orangeNote1.Top > 550)
                    orangeNote1.Top = intervalFirstPart1;

                else if (yellowNote.Top > 550)
                    yellowNote.Top = intervalFirstPart1;

                else if (redNote1.Top > 550)
                    redNote1.Top = intervalFirstPart1;

                else if (greenNote1.Top > 550)
                    greenNote1.Top = intervalFirstPart1;
            }

            else if (ticks == 45)
                PreNotesChorusPartInit();

            else if (ticks == 67)
                NotesFirstPartInit2();
                //Nesta parte da musica, as notas da guitarra sofrem um aumento gradual
                //de ritmo a medida que a musica passa, dessa forma, valores fixos de intervalo
                //acabarão perdendo a sincronia, sendo necessario, iniciar novamente a sequencia.
            if (ticks > 45 && ticks < 67)
            {
                if (greenNote2.Top > 560)
                {
                    greenNote2.Top = intervalFirstPart2;
                    orangeNote2.Top = intervalFirstPart2;
                }
                else if(greenNote3.Top > 560)
                {
                    greenNote3.Top = intervalFirstPart2;
                    orangeNote3.Top = intervalFirstPart2;
                }
                else if (greenNote4.Top > 560)
                {
                    greenNote4.Top = intervalFirstPart2;
                    orangeNote4.Top = intervalFirstPart2;
                }
                else if (greenNote5.Top > 560)
                {
                    greenNote5.Top = intervalFirstPart2;
                    orangeNote5.Top = intervalFirstPart2;
                }
                else if (greenNote6.Top > 560)
                {
                    greenNote6.Top = intervalFirstPart2;
                    orangeNote6.Top = intervalFirstPart2;
                }
                else if (greenNote7.Top > 560)
                {
                    greenNote7.Top = intervalFirstPart2;
                    orangeNote7.Top = intervalFirstPart2;
                }



            }
            else if(ticks > 67)
            {
                if (blueNote1.Top > 560)
                    blueNote1.Top = intervalFirstPart2;

                else if (blueNote2.Top > 560)
                    blueNote2.Top = intervalFirstPart2;

                else if (blueNote3.Top > 560)
                    blueNote3.Top = intervalFirstPart2;

                else if (orangeNote1.Top > 560)
                    orangeNote1.Top = intervalFirstPart2;

                else if (yellowNote.Top > 560)
                    yellowNote.Top = intervalFirstPart2;

                else if (redNote1.Top > 560)
                    redNote1.Top = intervalFirstPart2;

                else if (greenNote1.Top > 560)
                    greenNote1.Top = intervalFirstPart2;
            }

            greenNote1.Top += noteSpeed;
            greenNote2.Top += noteSpeed;
            greenNote3.Top += noteSpeed;
            greenNote4.Top += noteSpeed;
            greenNote5.Top += noteSpeed;
            greenNote6.Top += noteSpeed;

            redNote1.Top += noteSpeed;
            redNote2.Top += noteSpeed;
            redNote3.Top += noteSpeed;
            redNote4.Top += noteSpeed;
            redNote5.Top += noteSpeed;
            redNote6.Top += noteSpeed;

            yellowNote.Top += noteSpeed;

            blueNote1.Top += noteSpeed;
            blueNote2.Top += noteSpeed;
            blueNote3.Top += noteSpeed;
            blueNote4.Top += noteSpeed;
            blueNote5.Top += noteSpeed;
            blueNote6.Top += noteSpeed;

            orangeNote1.Top += noteSpeed;
            orangeNote2.Top += noteSpeed;
            orangeNote3.Top += noteSpeed;
            orangeNote4.Top += noteSpeed;
            orangeNote5.Top += noteSpeed;
            orangeNote6.Top += noteSpeed;

        }
    }
}
