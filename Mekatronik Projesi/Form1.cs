using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace Mekatronik_Projesi
{
    public partial class Form1 : Form
    {
        byte[] baytlar;
        float[] veriler;
        Stopwatch sayaç;
        XDate zaman1;
        ZedGraphControl[] zgc_grafikler = new ZedGraphControl[3];
        PointPairList nokta1 = new PointPairList();
        PointPairList nokta2 = new PointPairList();
        PointPairList nokta3 = new PointPairList();
        PointPairList[] noktalar = new PointPairList[3];
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            zgc_grafikler[0] = zgc_grafik_x;
            zgc_grafikler[1] = zgc_grafik_y;
            zgc_grafikler[2] = zgc_grafik_z;

            noktalar[0] = nokta1;
            noktalar[1] = nokta2;
            noktalar[2] = nokta3;

            baytlar = new byte[13];
            veriler = new float[3];
            toolStripComboBox_SeriPortlar.Items.AddRange(SerialPort.GetPortNames());
            sayaç = new Stopwatch();

            for (int i = 0; i < 3; i++)
            {
                zgc_grafikler[i].GraphPane.Title.Text = (char)(i + 88) + " Ekseni";
                zgc_grafikler[i].GraphPane.XAxis.Title.Text = "Zaman (s)";
                zgc_grafikler[i].GraphPane.XAxis.Type = AxisType.Date;
                zgc_grafikler[i].GraphPane.XAxis.Scale.Format = "mm:ss.fff";
                zgc_grafikler[i].GraphPane.XAxis.MinorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.XAxis.MajorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.XAxis.Scale.MajorStepAuto = true;
                zgc_grafikler[i].GraphPane.XAxis.Scale.MinorStepAuto = true;
                zgc_grafikler[i].GraphPane.YAxis.IsVisible = false;
                zgc_grafikler[i].GraphPane.Y2Axis.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.Title.Text = "Açı (derece)";
                zgc_grafikler[i].GraphPane.Y2Axis.MinorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MajorStepAuto = true;
                zgc_grafikler[i].GraphPane.Legend.IsVisible = false;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MinorStepAuto = true;
                zgc_grafikler[i].GraphPane.AddCurve((char)(i + 88) + " Açısı", noktalar[i], Color.Blue, SymbolType.None);
                zgc_grafikler[i].GraphPane.YAxis.Scale.MajorStep = 10;
                zgc_grafikler[i].GraphPane.YAxis.Scale.MinorStep = 5;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MajorStep = 10;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MinorStep = 5;
                zgc_grafikler[i].GraphPane.YAxis.Scale.Max = 90.0;
                zgc_grafikler[i].GraphPane.YAxis.Scale.Min = -90.0;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.Max = 90.0;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.Min = -90.0;
            }
        }
        private void seriPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            TimeSpan zaman = sayaç.Elapsed;
            zaman1 = new XDate(1899, 12, 30, zaman.Hours, zaman.Minutes, zaman.Seconds, zaman.Milliseconds);
            for (int i = 0; i < 13; i++)
                baytlar[i] = (byte)seriPort.ReadByte();
            for (int i = 0; i < 3; i++)
                veriler[i] = BitConverter.ToSingle(baytlar, 4 * i);
        }
        private void backgroundWorker_Güncelle_DoWork(object sender, DoWorkEventArgs e)
        {
            toolStripStatusLabel_Durum.Text = "İvme ölçer yaklaşık kullanım oranı: % " + baytlar[12];           
            for (int i = 0; i < 3; i++)
            {
                noktalar[i].Add(zaman1, veriler[i]);
                zgc_grafikler[i].GraphPane.XAxis.Scale.Max = zaman1 + 0.0000002;
                zgc_grafikler[i].GraphPane.XAxis.Scale.Min = zaman1 - 0.00000001 * 200;
                try
                {
                    zgc_grafikler[i].GraphPane.AxisChange();
                }
                catch (Exception)
                {
                }
                zgc_grafikler[i].Refresh();
            }
        }
        private void backgroundWorker_Güncelle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(seriPort.IsOpen && toolStripButton_GerçekZaman.Checked)
                backgroundWorker_Güncelle.RunWorkerAsync();
        }
        private void comboBox_SeriPortlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seriPort.PortName = toolStripComboBox_SeriPortlar.SelectedItem.ToString();
            propertyGrid1.Refresh();
        }

        private void toolStripButton_SeriPort_Click(object sender, EventArgs e)
        {
            if (seriPort.IsOpen)
            {
                sayaç.Stop();
                seriPort.Close();
                toolStripButton_SeriPort.Text = "Seri Port Aç";
            }
            else
            {
                seriPort.Open();
                sayaç.Start();
                seriPort.DiscardInBuffer();
                toolStripButton_SeriPort.Text = "Seri Port Kapat";
                backgroundWorker_Güncelle.RunWorkerAsync();
            }
        }
        private void toolStripComboBox_SeriPortlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seriPort.PortName = toolStripComboBox_SeriPortlar.SelectedItem.ToString();
            toolStripButton_SeriPort.Enabled = true;
            toolStripLabel_BaudRate.Enabled = true;
            toolStripTextBox_BaudRate.Enabled = true;
            toolStripButton_Arabellek.Enabled = true;
        }
        private void toolStripButton_Arabellek_Click(object sender, EventArgs e)
        {
            seriPort.DiscardInBuffer();
        }

        private string zgc_grafik_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            return sender.Name + " > " + ((XDate)nokta1[iPt].X).ToString("mm:ss.fff") + " ; " + nokta1[iPt].Y;
        }

        private void toolStripButton_GerçekZaman_Click(object sender, EventArgs e)
        {
            if(toolStripButton_GerçekZaman.Checked)
            {
                zgc_grafik_x.IsEnableHZoom = false;
                zgc_grafik_x.IsEnableHPan = false;
                zgc_grafik_x.IsShowHScrollBar = false;
                backgroundWorker_Güncelle.RunWorkerAsync();
            }
            else
            {
                zgc_grafik_x.IsEnableHZoom = true;
                zgc_grafik_x.IsEnableHPan = true;
                zgc_grafik_x.IsShowHScrollBar = true;
                zgc_grafik_x.SetScrollRangeFromData();
            }
        }
    }
}
