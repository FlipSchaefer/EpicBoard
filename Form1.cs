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

namespace EpicBoard 
{
    public partial class BoardWindow : Form
    {

        OpenFileDialog dialog;
        NAudio.Wave.WaveFileReader waveReader = null;
        NAudio.Wave.DirectSoundOut output = new NAudio.Wave.DirectSoundOut();
        NAudio.Wave.WaveIn sourceStream;



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

            int deviceNumber = inputComboBox.SelectedIndex;

            if (waveReader == null)
            {
                dialog = new OpenFileDialog();
                dialog.InitialDirectory = soundFolderTextBox.Text;
                dialog.Filter = "Audio Files (.wav)|*.wav";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sound1.Text = dialog.FileName;
                    sourceStream = new NAudio.Wave.WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

                    NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

                    output.Init(waveIn);

                    //sourceStream.StartRecording();
                    output.Play();

                    waveReader = new NAudio.Wave.WaveFileReader(dialog.FileName);
                    output.Init(new NAudio.Wave.WaveChannel32(waveReader));
                    output.Play();
                }

            }
            else
            {
                //Wenn schon vorhanden
                //Play sound
                waveReader = new NAudio.Wave.WaveFileReader(dialog.FileName);
                output.Init(new NAudio.Wave.WaveChannel32(waveReader));
                output.Play();
            }



        }


        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loadDevices()
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            inputComboBox.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                //item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                inputComboBox.Items.Add(item);
            }

        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
