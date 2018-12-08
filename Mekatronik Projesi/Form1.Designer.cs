namespace Mekatronik_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seriPort = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker_Güncelle = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Grafik = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zgc_grafik_x = new ZedGraph.ZedGraphControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.zgc_grafik_y = new ZedGraph.ZedGraphControl();
            this.zgc_grafik_z = new ZedGraph.ZedGraphControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_SeriPort = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_SeriPortlar = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_BaudRate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_BaudRate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_SeriPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_GerçekZaman = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Arabellek = new System.Windows.Forms.ToolStripButton();
            this.tabPage_SeriPort = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage_Grafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage_SeriPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // seriPort
            // 
            this.seriPort.DtrEnable = true;
            this.seriPort.ReceivedBytesThreshold = 13;
            this.seriPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriPort_DataReceived);
            // 
            // backgroundWorker_Güncelle
            // 
            this.backgroundWorker_Güncelle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Güncelle_DoWork);
            this.backgroundWorker_Güncelle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Güncelle_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Grafik);
            this.tabControl1.Controls.Add(this.tabPage_SeriPort);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Grafik
            // 
            this.tabPage_Grafik.Controls.Add(this.splitContainer1);
            this.tabPage_Grafik.Controls.Add(this.statusStrip1);
            this.tabPage_Grafik.Controls.Add(this.toolStrip1);
            this.tabPage_Grafik.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Grafik.Name = "tabPage_Grafik";
            this.tabPage_Grafik.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Grafik.Size = new System.Drawing.Size(968, 517);
            this.tabPage_Grafik.TabIndex = 1;
            this.tabPage_Grafik.Text = "Grafik Sekmesi";
            this.tabPage_Grafik.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zgc_grafik_x);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(962, 464);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 10;
            // 
            // zgc_grafik_x
            // 
            this.zgc_grafik_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_x.IsEnableHPan = false;
            this.zgc_grafik_x.IsEnableHZoom = false;
            this.zgc_grafik_x.IsEnableVPan = false;
            this.zgc_grafik_x.IsEnableVZoom = false;
            this.zgc_grafik_x.IsShowContextMenu = false;
            this.zgc_grafik_x.IsShowPointValues = true;
            this.zgc_grafik_x.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_x.Name = "zgc_grafik_x";
            this.zgc_grafik_x.ScrollGrace = 0D;
            this.zgc_grafik_x.ScrollMaxX = 0D;
            this.zgc_grafik_x.ScrollMaxY = 0D;
            this.zgc_grafik_x.ScrollMaxY2 = 0D;
            this.zgc_grafik_x.ScrollMinX = 0D;
            this.zgc_grafik_x.ScrollMinY = 0D;
            this.zgc_grafik_x.ScrollMinY2 = 0D;
            this.zgc_grafik_x.Size = new System.Drawing.Size(318, 464);
            this.zgc_grafik_x.TabIndex = 8;
            this.zgc_grafik_x.UseExtendedPrintDialog = true;
            this.zgc_grafik_x.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafik_PointValueEvent);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.zgc_grafik_y);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zgc_grafik_z);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(640, 464);
            this.splitContainer2.SplitterDistance = 318;
            this.splitContainer2.TabIndex = 0;
            // 
            // zgc_grafik_y
            // 
            this.zgc_grafik_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_y.IsEnableHPan = false;
            this.zgc_grafik_y.IsEnableHZoom = false;
            this.zgc_grafik_y.IsEnableVPan = false;
            this.zgc_grafik_y.IsEnableVZoom = false;
            this.zgc_grafik_y.IsShowContextMenu = false;
            this.zgc_grafik_y.IsShowPointValues = true;
            this.zgc_grafik_y.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_y.Name = "zgc_grafik_y";
            this.zgc_grafik_y.ScrollGrace = 0D;
            this.zgc_grafik_y.ScrollMaxX = 0D;
            this.zgc_grafik_y.ScrollMaxY = 0D;
            this.zgc_grafik_y.ScrollMaxY2 = 0D;
            this.zgc_grafik_y.ScrollMinX = 0D;
            this.zgc_grafik_y.ScrollMinY = 0D;
            this.zgc_grafik_y.ScrollMinY2 = 0D;
            this.zgc_grafik_y.Size = new System.Drawing.Size(318, 464);
            this.zgc_grafik_y.TabIndex = 9;
            this.zgc_grafik_y.UseExtendedPrintDialog = true;
            // 
            // zgc_grafik_z
            // 
            this.zgc_grafik_z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_z.IsEnableHPan = false;
            this.zgc_grafik_z.IsEnableHZoom = false;
            this.zgc_grafik_z.IsEnableVPan = false;
            this.zgc_grafik_z.IsEnableVZoom = false;
            this.zgc_grafik_z.IsShowContextMenu = false;
            this.zgc_grafik_z.IsShowPointValues = true;
            this.zgc_grafik_z.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_z.Name = "zgc_grafik_z";
            this.zgc_grafik_z.ScrollGrace = 0D;
            this.zgc_grafik_z.ScrollMaxX = 0D;
            this.zgc_grafik_z.ScrollMaxY = 0D;
            this.zgc_grafik_z.ScrollMaxY2 = 0D;
            this.zgc_grafik_z.ScrollMinX = 0D;
            this.zgc_grafik_z.ScrollMinY = 0D;
            this.zgc_grafik_z.ScrollMinY2 = 0D;
            this.zgc_grafik_z.Size = new System.Drawing.Size(318, 464);
            this.zgc_grafik_z.TabIndex = 9;
            this.zgc_grafik_z.UseExtendedPrintDialog = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Durum});
            this.statusStrip1.Location = new System.Drawing.Point(3, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Durum
            // 
            this.toolStripStatusLabel_Durum.Name = "toolStripStatusLabel_Durum";
            this.toolStripStatusLabel_Durum.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel_Durum.Text = "Hazır.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_SeriPort,
            this.toolStripComboBox_SeriPortlar,
            this.toolStripSeparator1,
            this.toolStripLabel_BaudRate,
            this.toolStripTextBox_BaudRate,
            this.toolStripSeparator2,
            this.toolStripButton_SeriPort,
            this.toolStripSeparator3,
            this.toolStripButton_GerçekZaman,
            this.toolStripSeparator4,
            this.toolStripButton_Arabellek});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_SeriPort
            // 
            this.toolStripLabel_SeriPort.Name = "toolStripLabel_SeriPort";
            this.toolStripLabel_SeriPort.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel_SeriPort.Text = "Seri Port :";
            // 
            // toolStripComboBox_SeriPortlar
            // 
            this.toolStripComboBox_SeriPortlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_SeriPortlar.DropDownWidth = 30;
            this.toolStripComboBox_SeriPortlar.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_SeriPortlar.Name = "toolStripComboBox_SeriPortlar";
            this.toolStripComboBox_SeriPortlar.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox_SeriPortlar.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SeriPortlar_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_BaudRate
            // 
            this.toolStripLabel_BaudRate.Enabled = false;
            this.toolStripLabel_BaudRate.Name = "toolStripLabel_BaudRate";
            this.toolStripLabel_BaudRate.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel_BaudRate.Text = "Baud Rate :";
            // 
            // toolStripTextBox_BaudRate
            // 
            this.toolStripTextBox_BaudRate.Enabled = false;
            this.toolStripTextBox_BaudRate.Name = "toolStripTextBox_BaudRate";
            this.toolStripTextBox_BaudRate.Size = new System.Drawing.Size(60, 25);
            this.toolStripTextBox_BaudRate.Text = "9600";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_SeriPort
            // 
            this.toolStripButton_SeriPort.CheckOnClick = true;
            this.toolStripButton_SeriPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SeriPort.Enabled = false;
            this.toolStripButton_SeriPort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SeriPort.Image")));
            this.toolStripButton_SeriPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SeriPort.Name = "toolStripButton_SeriPort";
            this.toolStripButton_SeriPort.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_SeriPort.Text = "Seri Port Aç";
            this.toolStripButton_SeriPort.Click += new System.EventHandler(this.toolStripButton_SeriPort_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_GerçekZaman
            // 
            this.toolStripButton_GerçekZaman.Checked = true;
            this.toolStripButton_GerçekZaman.CheckOnClick = true;
            this.toolStripButton_GerçekZaman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton_GerçekZaman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_GerçekZaman.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_GerçekZaman.Image")));
            this.toolStripButton_GerçekZaman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_GerçekZaman.Name = "toolStripButton_GerçekZaman";
            this.toolStripButton_GerçekZaman.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton_GerçekZaman.Text = "Gerçek Zaman";
            this.toolStripButton_GerçekZaman.Click += new System.EventHandler(this.toolStripButton_GerçekZaman_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Arabellek
            // 
            this.toolStripButton_Arabellek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Arabellek.Enabled = false;
            this.toolStripButton_Arabellek.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Arabellek.Image")));
            this.toolStripButton_Arabellek.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Arabellek.Name = "toolStripButton_Arabellek";
            this.toolStripButton_Arabellek.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton_Arabellek.Text = "Arabelleği Sıfırla";
            this.toolStripButton_Arabellek.Click += new System.EventHandler(this.toolStripButton_Arabellek_Click);
            // 
            // tabPage_SeriPort
            // 
            this.tabPage_SeriPort.Controls.Add(this.propertyGrid1);
            this.tabPage_SeriPort.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SeriPort.Name = "tabPage_SeriPort";
            this.tabPage_SeriPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SeriPort.Size = new System.Drawing.Size(967, 517);
            this.tabPage_SeriPort.TabIndex = 2;
            this.tabPage_SeriPort.Text = "Seri Port Ayarları";
            this.tabPage_SeriPort.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.seriPort;
            this.propertyGrid1.Size = new System.Drawing.Size(358, 511);
            this.propertyGrid1.TabIndex = 10;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mekatronik Projesi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Grafik.ResumeLayout(false);
            this.tabPage_Grafik.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage_SeriPort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort seriPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Güncelle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Grafik;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SeriPortlar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_SeriPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_BaudRate;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_BaudRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_SeriPort;
        private System.Windows.Forms.TabPage tabPage_SeriPort;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Arabellek;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Durum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl zgc_grafik_x;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripButton toolStripButton_GerçekZaman;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ZedGraph.ZedGraphControl zgc_grafik_y;
        private ZedGraph.ZedGraphControl zgc_grafik_z;
    }
}

