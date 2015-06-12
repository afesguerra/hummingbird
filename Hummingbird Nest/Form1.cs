using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hummingbird_Nest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            if (File.Exists(OFDListen.FileName))
            {
                if (SFDListen.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fiFile = new FileInfo(OFDListen.FileName);
                    BinaryReader brFile = new BinaryReader(fiFile.OpenRead());

                    byte[] header = brFile.ReadBytes(54);

                    int inicio = header[10] + (header[11] << 8) + (header[12] << 16) + (header[13] << 24);
                    int tamano = header[6] + (header[7] << 8) + (header[8] << 16) + (header[9] << 24);

                    BinaryWriter bwDump = new BinaryWriter(new FileStream(SFDListen.FileName, FileMode.Create));

                    brFile.ReadBytes(inicio - 54);

                    byte temp = 0;
                    for (int i = 0; i < tamano; i++)
                    {
                        temp = 0;
                        byte[] tupla = brFile.ReadBytes(8);
                        for (int j = 0; j < tupla.Length; j++)
			            {
                            temp += (byte)((tupla[j] % 2) << j);
			            }
                        bwDump.Write(temp);
                    }
                    bwDump.Flush();
                    bwDump.Close();
                    brFile.Close();
                    MessageBox.Show("File was successfully created", "Goal achieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
        	{
                MessageBox.Show("Source file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }

        }

        private void btListenFile_Click(object sender, EventArgs e)
        {
            if (OFDListen.ShowDialog() == DialogResult.OK)
            {
                tbListenFile.Text = OFDListen.FileName;
            }
        }

        private void btHumInfo_Click(object sender, EventArgs e)
        {
            if (OFDHumInfo.ShowDialog() == DialogResult.OK)
            {
                tbHumInfo.Text = OFDHumInfo.FileName;
            }
        }

        private void btHumPic_Click(object sender, EventArgs e)
        {
            if (OFDHumPic.ShowDialog() == DialogResult.OK)
            {
                tbHumPic.Text = OFDHumPic.FileName;
            }
        }

        private void btHum_Click(object sender, EventArgs e)
        {
            if (File.Exists(OFDHumInfo.FileName) && File.Exists(OFDHumPic.FileName))
            {
                if (SFDHum.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fiInfo = new FileInfo(OFDHumInfo.FileName);
                    FileInfo fiPic = new FileInfo(OFDHumPic.FileName);
                    BinaryReader brInfo = new BinaryReader(fiInfo.OpenRead());
                    BinaryReader brPic = new BinaryReader(fiPic.OpenRead());

                    byte[] header = brPic.ReadBytes(54);

                    int inicio = header[10] + (header[11] << 8) + (header[12] << 16) + (header[13] << 24);
                    int tamanoPic = header[34] + (header[35] << 8) + (header[36] << 16) + (header[37] << 24);
                    int tamanoInfo = (int)fiInfo.Length;

                    if (tamanoInfo*8<=tamanoPic)
                    {
                        header[6] = (byte)(tamanoInfo % 256);
                        header[7] = (byte)((tamanoInfo >> 8) % 256);
                        header[8] = (byte)((tamanoInfo >> 16) % 256);
                        header[9] = (byte)((tamanoInfo >> 24) % 256);

                        BinaryWriter bwDump = new BinaryWriter(new FileStream(SFDHum.FileName, FileMode.Create));
                        
                        bwDump.Write(header);
                        bwDump.Write(brPic.ReadBytes(inicio - 54));
                        bwDump.Flush();

                        byte byteInfo = 0;
                        byte bytePic = 0;
                        int bit = 0;

                        for (int i = 0; i < tamanoInfo; i++)
                        {
                            byteInfo=brInfo.ReadByte();
                            for (int j = 0; j < 8; j++)
                            {
                                bytePic = brPic.ReadByte();
                                bit = (byteInfo >> j) % 2;

                                if (bytePic % 2 == bit)
                                {
                                    bwDump.Write(bytePic);
                                }
                                else
                                {
                                    if (bit == 1)
                                    {
                                        bwDump.Write(++bytePic);
                                    }
                                    else
                                    {
                                        bwDump.Write(--bytePic);
                                    }
                                }
                            }
                        }
                        bwDump.Write(brPic.ReadBytes((int)(fiPic.Length - (tamanoInfo * 8))));
                        bwDump.Flush();
                        bwDump.Close();
                        brPic.Close();
                        brInfo.Close();
                        MessageBox.Show("File was successfully created", "Goal achieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bitmap is too small to fit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A target file must be defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Source files do not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}