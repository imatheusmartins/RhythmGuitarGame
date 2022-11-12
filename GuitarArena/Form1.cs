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
        private int intervalFirstPart2 = -715; //variavel de controle da sincronicidade
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

        private void NotesFirstPartInit1()
        {
            greenNote.Left = 190;
            redNote.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            orangeNote.Left = 560;

            blueNote1.Top = -290;
            blueNote2.Top = -550;
            blueNote3.Top = -770;
            orangeNote.Top = -670;
            yellowNote.Top = -830;
            redNote.Top = -970;
            greenNote.Top = -1290;
        }
        private void NotesFirstPartInit2()
        {
            greenNote.Left = 190;
            redNote.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            orangeNote.Left = 562;

            blueNote1.Top = -350;
            blueNote2.Top = -610;
            blueNote3.Top = -830;
            orangeNote.Top = -730;
            yellowNote.Top = -890;
            redNote.Top = -1030;
            greenNote.Top = -1350;
        }

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

                else if (orangeNote.Top > 550)
                    orangeNote.Top = intervalFirstPart1;

                else if (yellowNote.Top > 550)
                    yellowNote.Top = intervalFirstPart1;

                else if (redNote.Top > 550)
                    redNote.Top = intervalFirstPart1;

                else if (greenNote.Top > 550)
                    greenNote.Top = intervalFirstPart1;
            }
            else if(ticks == 67)
            {
                NotesFirstPartInit2();
            }
            if(ticks > 67)
            {
                if (blueNote1.Top > 550)
                    blueNote1.Top = intervalFirstPart2;

                else if (blueNote2.Top > 550)
                    blueNote2.Top = intervalFirstPart2;

                else if (blueNote3.Top > 550)
                    blueNote3.Top = intervalFirstPart2;

                else if (orangeNote.Top > 550)
                    orangeNote.Top = intervalFirstPart2;

                else if (yellowNote.Top > 550)
                    yellowNote.Top = intervalFirstPart2;

                else if (redNote.Top > 550)
                    redNote.Top = intervalFirstPart2;

                else if (greenNote.Top > 550)
                    greenNote.Top = intervalFirstPart2;
            }
            
            blueNote1.Top += noteSpeed;
            blueNote2.Top += noteSpeed;
            blueNote3.Top += noteSpeed;
            orangeNote.Top += noteSpeed;
            yellowNote.Top += noteSpeed;
            redNote.Top += noteSpeed;
            greenNote.Top += noteSpeed;

            
        }

        private void GuitarMain_Load(object sender, EventArgs e)
        {

        }
    }
}
