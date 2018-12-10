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
        int[] ölçek = { 100, 100, 100, 100, 100, 100 };
        bool detaylıölçekle;
        Stopwatch sayaç;
        XDate zaman1;
        ZedGraphControl[] zgc_grafikler = new ZedGraphControl[6];
        PointPairList nokta1 = new PointPairList();
        PointPairList nokta2 = new PointPairList();
        PointPairList nokta3 = new PointPairList();
        PointPairList nokta4 = new PointPairList();
        PointPairList nokta5 = new PointPairList();
        PointPairList nokta6 = new PointPairList();
        PointPairList[] noktalar = new PointPairList[6];
        LineItem[] grafikler = new LineItem[6];
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            zgc_grafikler[0] = zgc_grafik_x1;
            zgc_grafikler[1] = zgc_grafik_y1;
            zgc_grafikler[2] = zgc_grafik_z1;
            zgc_grafikler[3] = zgc_grafik_x2;
            zgc_grafikler[4] = zgc_grafik_y2;
            zgc_grafikler[5] = zgc_grafik_z2;

            noktalar[0] = nokta1;
            noktalar[1] = nokta2;
            noktalar[2] = nokta3;
            noktalar[3] = nokta4;
            noktalar[4] = nokta5;
            noktalar[5] = nokta6;

            baytlar = new byte[25];
            veriler = new float[6];
            toolStripComboBox_SeriPortlar.Items.AddRange(SerialPort.GetPortNames());
            sayaç = new Stopwatch();

            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                    zgc_grafikler[i].GraphPane.Title.Text = "Filtered " + (char)(i + 88) + " Axis";
                else
                    zgc_grafikler[i].GraphPane.Title.Text = "Acc. Data " + (char)(i + 85) + " Axis";
                zgc_grafikler[i].GraphPane.XAxis.Title.Text = "Time [s]";
                zgc_grafikler[i].GraphPane.XAxis.Type = AxisType.Date;
                zgc_grafikler[i].GraphPane.XAxis.Scale.Format = "mm:ss.fff";
                zgc_grafikler[i].GraphPane.XAxis.MinorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.XAxis.MajorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.XAxis.Scale.MajorStepAuto = true;
                zgc_grafikler[i].GraphPane.XAxis.Scale.MinorStepAuto = true;
                zgc_grafikler[i].GraphPane.YAxis.IsVisible = false;
                zgc_grafikler[i].GraphPane.Y2Axis.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.Title.Text = "Angle [°]";
                zgc_grafikler[i].GraphPane.Y2Axis.MinorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MajorStepAuto = true;
                zgc_grafikler[i].GraphPane.Legend.IsVisible = false;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MinorStepAuto = true;
                grafikler[i] = zgc_grafikler[i].GraphPane.AddCurve((char)(i + 88) + " Angle", noktalar[i], Color.Blue, SymbolType.None);
                zgc_grafikler[i].GraphPane.YAxis.Scale.MajorStep = 10;
                zgc_grafikler[i].GraphPane.YAxis.Scale.MinorStep = 5;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MajorStep = 10;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.MinorStep = 5;
                zgc_grafikler[i].GraphPane.YAxis.Scale.Max = 180;
                zgc_grafikler[i].GraphPane.YAxis.Scale.Min = -180;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.Max = 180;
                zgc_grafikler[i].GraphPane.Y2Axis.Scale.Min = -180;
            }
            comboBox_Symbol.SelectedIndex = 10;
        }
        private void seriPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            TimeSpan zaman = sayaç.Elapsed;
            zaman1 = new XDate(1899, 12, 30, zaman.Hours, zaman.Minutes, zaman.Seconds, zaman.Milliseconds);
            for (int i = 0; i < 25; i++)
                baytlar[i] = (byte)seriPort.ReadByte();
            for (int i = 0; i < 6; i++)
                veriler[i] = BitConverter.ToSingle(baytlar, 4 * i);
        }
        private void backgroundWorker_Güncelle_DoWork(object sender, DoWorkEventArgs e)
        {
            toolStripStatusLabel_Durum.Text = "Approximate usage of accelerometer data (the gain P): % " + baytlar[24];
            if (seriPort.IsOpen && seriPort.BytesToRead <= baytlar.Length)
            {
                toolStripButton_RealTime.Checked = true;
                toolStripButton_RealTime.Text = seriPort.BytesToRead.ToString();
            }
            else
                toolStripButton_RealTime.Checked = false;
            for (int i = 0; i < 6; i++)
            {
                noktalar[i].Add(zaman1, veriler[i]);
                if (toolStripButton_GerçekZaman.Checked)
                {
                    zgc_grafikler[i].GraphPane.XAxis.Scale.Max = zaman1 + 0.0000002;
                    zgc_grafikler[i].GraphPane.XAxis.Scale.Min = zaman1 - 0.0000001 * ölçek[i];
                }
                zgc_grafikler[i].Refresh();
                try
                {
                    zgc_grafikler[i].GraphPane.AxisChange();
                }
                catch (Exception){}
            }
        }
        private void backgroundWorker_Güncelle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(seriPort.IsOpen)
                backgroundWorker_Güncelle.RunWorkerAsync();
        }
        private void toolStripButton_SeriPort_Click(object sender, EventArgs e)
        {
            if (seriPort.IsOpen)
            {
                sayaç.Stop();
                seriPort.Close();
                toolStripButton_SeriPort.Text = "Open Serial Port";
                toolStripComboBox_SeriPortlar.Enabled = true;
                toolStripTextBox_BaudRate.Enabled = true;
                toolStripButton_Arabellek.Enabled = false;
            }
            else
            {
                toolStripComboBox_SeriPortlar.Enabled = false;
                toolStripTextBox_BaudRate.Enabled = false;
                toolStripButton_Arabellek.Enabled = true;
                seriPort.Open();
                sayaç.Start();
                seriPort.DiscardInBuffer();
                toolStripButton_SeriPort.Text = "Close Serial Port";
                backgroundWorker_Güncelle.RunWorkerAsync();
            }
        }
        private void toolStripComboBox_SeriPortlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seriPort.PortName = toolStripComboBox_SeriPortlar.SelectedItem.ToString();
            propertyGrid_seriport.Refresh();
            toolStripButton_SeriPort.Enabled = true;
            toolStripLabel_BaudRate.Enabled = true;
            toolStripTextBox_BaudRate.Enabled = true;
            toolStripButton_GerçekZaman.Enabled = true;
            toolStripButton_GerçekZaman.Checked = true;
            toolStripButton_Arabellek.Enabled = true;
            toolStripSplitButton_XEkseni.Enabled = true;
            toolStripSplitButton_YEkseni.Enabled = true;
            toolStripSplitButton_ZEkseni.Enabled = true;
            toolStripButton_Restore.Enabled = true;
        }
        private void toolStripButton_Arabellek_Click(object sender, EventArgs e)
        {
            seriPort.DiscardInBuffer();
        }

        private string zgc_grafikler_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            return sender.Name + " > " + ((XDate)noktalar[sender.TabIndex][iPt].X).ToString("mm:ss.fff") + " ; " + noktalar[sender.TabIndex][iPt].Y;
        }
        private void toolStripButton_GerçekZaman_Click(object sender, EventArgs e)
        {
            if(toolStripButton_GerçekZaman.Checked)
            {
                foreach (ZedGraphControl zgc_grafik in zgc_grafikler)
                {
                    zgc_grafik.IsEnableHZoom = false;
                    zgc_grafik.IsEnableHPan = false;
                    zgc_grafik.IsShowHScrollBar = false;
                }
            }
            else
            {
                foreach (ZedGraphControl zgc_grafik in zgc_grafikler)
                {
                    zgc_grafik.IsEnableHZoom = true;
                    zgc_grafik.IsEnableHPan = true;
                    zgc_grafik.IsShowHScrollBar = true;
                    zgc_grafik.SetScrollRangeFromData();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            seriPort.Close();
        }
        private void zgc_grafikler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                detaylıölçekle = !detaylıölçekle;
        }
        private void zgc_grafikler_MouseWheel(object sender, MouseEventArgs e)
        {
            if (detaylıölçekle)
            {
                if (ölçek[(sender as ZedGraphControl).TabIndex] - e.Delta / 120 > 0)
                    ölçek[(sender as ZedGraphControl).TabIndex] -= e.Delta / 120;
                else
                    ölçek[(sender as ZedGraphControl).TabIndex] = 0;
            }
            else
            {
                if (ölçek[(sender as ZedGraphControl).TabIndex] - e.Delta / 12 > 0)
                    ölçek[(sender as ZedGraphControl).TabIndex] -= e.Delta / 12;
                else
                    ölçek[(sender as ZedGraphControl).TabIndex] = 0;
            }
        }
        private void toolStripSplitButton_XEkseni_ButtonClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = Size.Width;
        }
        private void toolStripSplitButton_XEkseni_ButtonDoubleClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = 0;
            splitContainer_yz.SplitterDistance = Size.Width / 2;
        }
        private void toolStripSplitButton_XEkseni_DropDownClosed(object sender, EventArgs e)
        {
            if (!toolStripMenuItem_AutoScaleX.Checked)
            {
                double Xmax, Xmin;
                if (double.TryParse(toolStripTextBox_Xmax.Text, out Xmax))
                {
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Max = Xmax;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Max = Xmax;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Max = Xmax;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Max = Xmax;
                }
                else
                {
                    toolStripTextBox_Xmax.Text = "180";
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Xmin.Text, out Xmin))
                {
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Min = Xmin;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Min = Xmin;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Min = Xmin;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Min = Xmin;
                }
                else
                {
                    toolStripTextBox_Xmin.Text = "-180";
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
        private void toolStripMenuItem_AutoScaleX_CheckedChanged(object sender, EventArgs e)
        {
            zgc_grafik_x1.GraphPane.YAxis.Scale.MaxAuto = toolStripMenuItem_AutoScaleX.Checked;
            zgc_grafik_x1.GraphPane.Y2Axis.Scale.MaxAuto = toolStripMenuItem_AutoScaleX.Checked;
            zgc_grafik_x1.GraphPane.YAxis.Scale.MinAuto = toolStripMenuItem_AutoScaleX.Checked;
            zgc_grafik_x1.GraphPane.Y2Axis.Scale.MinAuto = toolStripMenuItem_AutoScaleX.Checked;
            if (!toolStripMenuItem_AutoScaleX.Checked)
            {
                double Xmax, Xmin;
                if (double.TryParse(toolStripTextBox_Xmax.Text, out Xmax))
                {
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Max = Xmax;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Max = Xmax;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Max = Xmax;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Max = Xmax;
                }
                else
                {
                    toolStripTextBox_Xmax.Text = "180";
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Xmin.Text, out Xmin))
                {
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Min = Xmin;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Min = Xmin;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Min = Xmin;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Min = Xmin;
                }
                else
                {
                    toolStripTextBox_Xmin.Text = "-180";
                    zgc_grafik_x1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_x1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_x2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_x2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
       
        private void toolStripSplitButton_YEkseni_ButtonClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = 0;
            splitContainer_yz.SplitterDistance = Size.Width;
        }
        private void toolStripSplitButton_YEkseni_ButtonDoubleClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = Size.Width / 2;
            splitContainer_yz.SplitterDistance = 0;
        }
        private void toolStripSplitButton_YEkseni_DropDownClosed(object sender, EventArgs e)
        {
            if (!toolStripMenuItem_AutoScaleY.Checked)
            {
                double Ymax, Ymin;
                if (double.TryParse(toolStripTextBox_Ymax.Text, out Ymax))
                {
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Max = Ymax;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Max = Ymax;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Max = Ymax;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Max = Ymax;
                }
                else
                {
                    toolStripTextBox_Ymax.Text = "180";
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Ymin.Text, out Ymin))
                {
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Min = Ymin;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Min = Ymin;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Min = Ymin;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Min = Ymin;
                }
                else
                {
                    toolStripTextBox_Ymin.Text = "-180";
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
        private void toolStripMenuItem_AutoScaleY_CheckedChanged(object sender, EventArgs e)
        {
            zgc_grafik_y1.GraphPane.YAxis.Scale.MaxAuto = toolStripMenuItem_AutoScaleY.Checked;
            zgc_grafik_y1.GraphPane.Y2Axis.Scale.MaxAuto = toolStripMenuItem_AutoScaleY.Checked;
            zgc_grafik_y1.GraphPane.YAxis.Scale.MinAuto = toolStripMenuItem_AutoScaleY.Checked;
            zgc_grafik_y1.GraphPane.Y2Axis.Scale.MinAuto = toolStripMenuItem_AutoScaleY.Checked;
            if (!toolStripMenuItem_AutoScaleY.Checked)
            {
                double Ymax, Ymin;
                if (double.TryParse(toolStripTextBox_Ymax.Text, out Ymax))
                {
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Max = Ymax;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Max = Ymax;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Max = Ymax;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Max = Ymax;
                }
                else
                {
                    toolStripTextBox_Ymax.Text = "180";
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Ymin.Text, out Ymin))
                {
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Min = Ymin;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Min = Ymin;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Min = Ymin;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Min = Ymin;
                }
                else
                {
                    toolStripTextBox_Ymin.Text = "-180";
                    zgc_grafik_y1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_y1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_y2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_y2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
        private void toolStripSplitButton_ZEkseni_ButtonClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = 0;
            splitContainer_yz.SplitterDistance = 0;
        }
        private void toolStripSplitButton_ZEkseni_ButtonDoubleClick(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = Size.Width / 2;
            splitContainer_yz.SplitterDistance = Size.Width;
        }
        private void toolStripSplitButton_ZEkseni_DropDownClosed(object sender, EventArgs e)
        {
            if (!toolStripMenuItem_AutoScaleZ.Checked)
            {
                double Zmax, Zmin;
                if (double.TryParse(toolStripTextBox_Zmax.Text, out Zmax))
                {
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Max = Zmax;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Max = Zmax;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Max = Zmax;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Max = Zmax;
                }
                else
                {
                    toolStripTextBox_Zmax.Text = "180";
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Zmin.Text, out Zmin))
                {
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Min = Zmin;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Min = Zmin;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Min = Zmin;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Min = Zmin;
                }
                else
                {
                    toolStripTextBox_Zmin.Text = "-180";
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
        private void toolStripMenuItem_AutoScaleZ_CheckedChanged(object sender, EventArgs e)
        {
            zgc_grafik_z1.GraphPane.YAxis.Scale.MaxAuto = toolStripMenuItem_AutoScaleZ.Checked;
            zgc_grafik_z1.GraphPane.Y2Axis.Scale.MaxAuto = toolStripMenuItem_AutoScaleZ.Checked;
            zgc_grafik_z1.GraphPane.YAxis.Scale.MinAuto = toolStripMenuItem_AutoScaleZ.Checked;
            zgc_grafik_z1.GraphPane.Y2Axis.Scale.MinAuto = toolStripMenuItem_AutoScaleZ.Checked;
            if (!toolStripMenuItem_AutoScaleZ.Checked)
            {
                double Zmax, Zmin;
                if (double.TryParse(toolStripTextBox_Zmax.Text, out Zmax))
                {
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Max = Zmax;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Max = Zmax;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Max = Zmax;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Max = Zmax;
                }
                else
                {
                    toolStripTextBox_Zmax.Text = "180";
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Max = 180;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Max = 180;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Max = 180;
                }
                if (double.TryParse(toolStripTextBox_Zmin.Text, out Zmin))
                {
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Min = Zmin;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Min = Zmin;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Min = Zmin;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Min = Zmin;
                }
                else
                {
                    toolStripTextBox_Zmin.Text = "-180";
                    zgc_grafik_z1.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_z1.GraphPane.Y2Axis.Scale.Min = -180;
                    zgc_grafik_z2.GraphPane.YAxis.Scale.Min = -180;
                    zgc_grafik_z2.GraphPane.Y2Axis.Scale.Min = -180;
                }
            }
        }
        private void toolStripButton_Restore_Click(object sender, EventArgs e)
        {
            splitContainer_xyz.SplitterDistance = Size.Width / 3;
            splitContainer_yz.SplitterDistance = Size.Width / 3;
        }
        private void toolStripMenuItem_ResetX_Click(object sender, EventArgs e)
        {
            nokta1.Clear();
        }
        private void toolStripMenuItem_ResetY_Click(object sender, EventArgs e)
        {
            nokta2.Clear();
        }
        private void toolStripMenuItem_ResetZ_Click(object sender, EventArgs e)
        {
            nokta3.Clear();
        }
        private void zgc_grafikler_ScrollProgressEvent(ZedGraphControl sender, ScrollBar scrollBar, ZoomState oldState, ZoomState newState)
        {
            sender.SetScrollRangeFromData();
        }
        private void toolStripMenuItem_ComparisonX_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem_ComparisonX.Checked)
                splitContainer_x.Panel2Collapsed = false;
            else
                splitContainer_x.Panel2Collapsed = true;
        }
        private void toolStripMenuItem_ComparisonY_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem_ComparisonY.Checked)
                splitContainer_y.Panel2Collapsed = false;
            else
                splitContainer_y.Panel2Collapsed = true;
        }
        private void toolStripMenuItem_ComparisonZ_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem_ComparisonZ.Checked)
                splitContainer_z.Panel2Collapsed = false;
            else
                splitContainer_z.Panel2Collapsed = true;
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            if(colorDialog_veri.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < 6; i++)
                    grafikler[i].Color = colorDialog_veri.Color;
        }

        private void comboBox_Symbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Symbol.SelectedIndex != 10)
                for (int i = 0; i < 6; i++)
                    grafikler[i].Symbol.Type = (SymbolType)comboBox_Symbol.SelectedIndex;
            else
                for (int i = 0; i < 6; i++)
                    grafikler[i].Symbol.Type = SymbolType.None;
        }
    }
}