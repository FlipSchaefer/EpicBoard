using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using AudioSwitcher.AudioApi.CoreAudio;

namespace EpicBoard 
{
    public partial class BoardWindow : Form
    {

        OpenFileDialog dialog;
        NAudio.Wave.WaveFileReader waveReader = null;
        NAudio.Wave.DirectSoundOut output = new NAudio.Wave.DirectSoundOut();
        NAudio.Wave.WaveIn sourceStream;
        NAudio.Wave.WaveOut sourceOutStream;


        public BoardWindow()
        {
            InitializeComponent();
            loadDevices();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {

            /*

            ManagementObjectSearcher mo = new ManagementObjectSearcher("select * from Win32_SoundDevice");

            ManagementObjectCollection objCollection = mo.Get();

            foreach (ManagementObject soundDevice in objCollection)
            {
                Console.Out.WriteLine("------------------");
                Console.Out.WriteLine(soundDevice.GetPropertyValue("Name"));

                foreach (PropertyData property in soundDevice.Properties)
                {
                    Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value));
                }
            }   

            */



            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                soundFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void sound1_Click(object sender, EventArgs e)
        {

            int deviceNumberIn = inputComboBox.SelectedIndex;
            int deviceNumberOut = outputComboBox.SelectedIndex;

            if (waveReader == null)
            {
                dialog = new OpenFileDialog();
                dialog.InitialDirectory = soundFolderTextBox.Text;
                dialog.Filter = "Audio Files (.wav)|*.wav";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sound1.Text = dialog.FileName;
                    //sourceStream = new NAudio.Wave.WaveIn();
                    sourceOutStream = new NAudio.Wave.WaveOut();
                    sourceOutStream.DeviceNumber = deviceNumberOut;

                       //sourceStream.DeviceNumber = deviceNumber;
                       //sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

                       //NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

                       //output.Init(waveIn);

                       //sourceStream.StartRecording();
                       //output.Play();

                  

                    waveReader = new NAudio.Wave.WaveFileReader(dialog.FileName);
                    sourceOutStream.Init(new NAudio.Wave.WaveChannel32(waveReader));
                    //output.Init(new NAudio.Wave.WaveChannel32(waveReader));
                    sourceOutStream.Play();
                    //output.Play();
                }

            }
            else
            {
                //Wenn schon vorhanden
                //Play sound
                waveReader = new NAudio.Wave.WaveFileReader(dialog.FileName);
                output.Init(new NAudio.Wave.WaveChannel32(waveReader));
                sourceOutStream.Init(new NAudio.Wave.WaveChannel32(waveReader));
                sourceOutStream.Play();
                //output.Play();
            }



        }


        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loadDevices()
        {
            //Input devices
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            //Input search
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            inputComboBox.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                inputComboBox.Items.Add(item);
            }

            //Output Devices
            List<NAudio.Wave.WaveOutCapabilities> sourcesOut = new List<NAudio.Wave.WaveOutCapabilities>();

            //Output search
            for (int i = 0; i < NAudio.Wave.WaveOut.DeviceCount; i++)
            {
                sourcesOut.Add(NAudio.Wave.WaveOut.GetCapabilities(i));
            }

            outputComboBox.Items.Clear();

            foreach (var source in sourcesOut)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                outputComboBox.Items.Add(item);
            }

        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

            int deviceNumberIn = inputComboBox.SelectedIndex;
            int deviceNumberOut = outputComboBox.SelectedIndex;

            Console.Out.WriteLine("Device:" + deviceNumberIn);
            Console.Out.WriteLine("Name: " + inputComboBox.SelectedItem);

            Console.Out.WriteLine("Device:" + deviceNumberOut);
            Console.Out.WriteLine("Name: " + outputComboBox.SelectedItem);
        }
    }
}
