using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.FileFormats;//wav파일 작업을 위한 naudio 선언
using SFML.Audio;// ogg로 번역을 위한 sfml선언
using System.IO;
using NAudio.Lame;

namespace convertogg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (latetxt.Text != "" && filenametxt.Text != "" && bittxt.Text != "")
            {
                string filename = filenametxt.Text;
                int channel = (channelcheck.Checked) ? 1 : 2;
                try
                {
                    using (var reader = new WaveFileReader(filename + ".wav"))//입력한 파일명.wav파일을 불러온다
                    {
                        var newFormat = new WaveFormat(Convert.ToInt32(latetxt.Text), Convert.ToInt32(bittxt.Text), channel);//샘플레이트,비트,채널 설정

                        using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))//미리 설정해뒀던 값에 맞게 포멧
                        {
                            WaveFileWriter.CreateWaveFile("2.wav", conversionStream);//포멧한 .wav파일 생성
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("파일 이름이 정확하지 않습니다.");
                }

                /*try
                {
                    var wav_snd = new SFML.Audio.SoundBuffer("2.wav");
                    wav_snd.SaveToFile("2.mp3");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

                try
                {
                    var wav_snd = new SFML.Audio.SoundBuffer("2.mp3");
                    wav_snd.SaveToFile(filename + ".ogg");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("빈칸을 채워주시기 바랍니다.");
            }
        }
    }
}
