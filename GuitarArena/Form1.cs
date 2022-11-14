using System;
using System.Media;
using System.Windows.Forms;


namespace GuitarArena
{
    public partial class GuitarMain : Form
    {
        private int noteSpeed = 10;
        private int ticks = -3;
        private int intervalFirstPart1 = -685; //variavel de controle da sincronicidade
        private int intervalFirstPart2 = -710; //variavel de controle da sincronicidade
        private SoundPlayer _soundPlayer;
        
        public GuitarMain()
        {
            InitializeComponent();
            SongTimer.Start();
            _soundPlayer = new SoundPlayer("Seven_Nation.wav");
            notesReset();

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            if (ticks == -3) { 
                firstPart.Start();
                NotesFirstPartInit1();
            }
            
            if (ticks == 44)
            {
                preChorusPartTimer.Start();
                PreChorusInit();
            }
           
            
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
            yellowNote.Top = -840;
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
            blueNote3.Left = 465;
            orangeNote1.Left = 562;

            blueNote1.Top = -350;
            blueNote2.Top = -610;
            blueNote3.Top = -830;
            orangeNote1.Top = -730;
            yellowNote.Top = -890;
            redNote1.Top = -1030;
            greenNote1.Top = -1350;
        } //depois do refrao

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

        //timers:

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

            else if (ticks == 67)
                NotesFirstPartInit2(); //parte apos refrão
                                       
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
            redNote1.Top += noteSpeed;
            yellowNote.Top += noteSpeed;
            blueNote1.Top += noteSpeed;
            blueNote2.Top += noteSpeed;
            blueNote3.Top += noteSpeed;
            orangeNote1.Top += noteSpeed;
        }

        private void preChorusTimerSong(object sender, EventArgs e)
        {
            if (ticks > 43)
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
        }

        private void chorusTimerSong(object sender, EventArgs e)
        {

        }

        private void notesReset()
        {
            greenNote1.Left = -500;
            greenNote2.Left = -500;
            greenNote3.Left = -500;
            greenNote4.Left = -500;
            greenNote5.Left = -500;
            greenNote6.Left = -500;
            greenNote7.Left = -500;
            greenNote8.Left = -500;
            greenNote9.Left = -500;

            redNote1.Left = -500;
            redNote2.Left = -500;
            redNote3.Left = -500;
            redNote4.Left = -500;
            redNote5.Left = -500;
            redNote6.Left = -500;
            redNote7.Left = -500;
            redNote8.Left = -500;
            redNote9.Left = -500;

            yellowNote.Left = -500;

            blueNote1.Left = -500;
            blueNote2.Left = -500;
            blueNote3.Left = -500;
            blueNote4.Left = -500;
            blueNote5.Left = -500;
            blueNote6.Left = -500;
            blueNote7.Left = -500;
            blueNote8.Left = -500;
            blueNote9.Left = -500;
            blueNote10.Left = -500;
            blueNote11.Left = -500;

            orangeNote1.Left = -500;
            orangeNote2.Left = -500;
            orangeNote3.Left = -500;
            orangeNote4.Left = -500;
            orangeNote5.Left = -500;
            orangeNote6.Left = -500;
            orangeNote7.Left = -500;
            orangeNote8.Left = -500;
            orangeNote9.Left = -500;
        }

        
    }
}
