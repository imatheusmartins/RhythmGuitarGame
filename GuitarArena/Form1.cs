using System;
using System.Media;
using System.Windows.Forms;


namespace GuitarArena
{
    public partial class GuitarMain : Form
    {
        private int noteSpeed = 7;
        private int ticks = -3;
        private int intervalFirstPart = -315;
        private SoundPlayer _soundPlayer;
        
        public GuitarMain()
        {
            InitializeComponent();
            SongTimer.Start();
            _soundPlayer = new SoundPlayer("Seven_Nation.wav");
            NotesFirstPartInit();
            
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            if (ticks < 1)
                controlParts();
            /*if (ticks > 9)
                firstPart.Stop();

            /*if (ticks > 40)
                firstPart.Stop();
            */
            ticks++;
            textTeste.Text = ticks.ToString();
            if(ticks == 0)
            {
                _soundPlayer.Play();
            }
            
        }

        private void NotesFirstPartInit()
        {
            greenNote.Left = 190;
            redNote.Left = 280;
            yellowNote.Left = 368;
            blueNote1.Left = 465;
            blueNote2.Left = 465;
            orangeNote.Left = 562;

            blueNote1.Top = -90;
            blueNote2.Top = -250;
            blueNote3.Top = -370;
            orangeNote.Top = -300;
            yellowNote.Top = -430;
            redNote.Top = -525;
            greenNote.Top = -730;
        }

        private void controlParts()
        {
            firstPart.Start();
        }
        private void firstPartSong(object sender, EventArgs e)
        {

            if (ticks < 12)
            {
                if (blueNote1.Top > 550)
                    blueNote1.Top = intervalFirstPart;

                if (blueNote2.Top > 550)
                    blueNote2.Top = intervalFirstPart;

                if (blueNote3.Top > 550)
                    blueNote3.Top = intervalFirstPart;

                if (orangeNote.Top > 550)
                    orangeNote.Top = intervalFirstPart;

                if (yellowNote.Top > 550)
                    yellowNote.Top = intervalFirstPart;

                if (redNote.Top > 550)
                    redNote.Top = intervalFirstPart;

                if (greenNote.Top > 550)
                    greenNote.Top = intervalFirstPart;
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
