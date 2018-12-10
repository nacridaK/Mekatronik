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
            this.tabControl_sekmeler = new System.Windows.Forms.TabControl();
            this.tabPage_Grafik = new System.Windows.Forms.TabPage();
            this.splitContainer_xyz = new System.Windows.Forms.SplitContainer();
            this.splitContainer_x = new System.Windows.Forms.SplitContainer();
            this.zgc_grafik_x1 = new ZedGraph.ZedGraphControl();
            this.zgc_grafik_x2 = new ZedGraph.ZedGraphControl();
            this.splitContainer_yz = new System.Windows.Forms.SplitContainer();
            this.splitContainer_y = new System.Windows.Forms.SplitContainer();
            this.zgc_grafik_y1 = new ZedGraph.ZedGraphControl();
            this.zgc_grafik_y2 = new ZedGraph.ZedGraphControl();
            this.splitContainer_z = new System.Windows.Forms.SplitContainer();
            this.zgc_grafik_z1 = new ZedGraph.ZedGraphControl();
            this.zgc_grafik_z2 = new ZedGraph.ZedGraphControl();
            this.statusStrip_DurumÇubuğu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_AraçÇubuğu = new System.Windows.Forms.ToolStrip();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton_XEkseni = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem_AutoScaleX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Xmax = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_Xmin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem_ResetX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ComparisonX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton_YEkseni = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem_AutoScaleY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Ymax = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_Ymin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem_ResetY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ComparisonY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton_ZEkseni = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem_AutoScaleZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Zmax = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_Zmin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem_ResetZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ComparisonZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Restore = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RealTime = new System.Windows.Forms.ToolStripButton();
            this.tabPage_Ayarlar = new System.Windows.Forms.TabPage();
            this.groupBox_about = new System.Windows.Forms.GroupBox();
            this.label_about = new System.Windows.Forms.Label();
            this.pictureBox_ytu = new System.Windows.Forms.PictureBox();
            this.groupBox_Graphic = new System.Windows.Forms.GroupBox();
            this.comboBox_Symbol = new System.Windows.Forms.ComboBox();
            this.label_symbol = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            this.groupBox_seriport = new System.Windows.Forms.GroupBox();
            this.propertyGrid_seriport = new System.Windows.Forms.PropertyGrid();
            this.colorDialog_veri = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_sekmeler.SuspendLayout();
            this.tabPage_Grafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_xyz)).BeginInit();
            this.splitContainer_xyz.Panel1.SuspendLayout();
            this.splitContainer_xyz.Panel2.SuspendLayout();
            this.splitContainer_xyz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_x)).BeginInit();
            this.splitContainer_x.Panel1.SuspendLayout();
            this.splitContainer_x.Panel2.SuspendLayout();
            this.splitContainer_x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_yz)).BeginInit();
            this.splitContainer_yz.Panel1.SuspendLayout();
            this.splitContainer_yz.Panel2.SuspendLayout();
            this.splitContainer_yz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_y)).BeginInit();
            this.splitContainer_y.Panel1.SuspendLayout();
            this.splitContainer_y.Panel2.SuspendLayout();
            this.splitContainer_y.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_z)).BeginInit();
            this.splitContainer_z.Panel1.SuspendLayout();
            this.splitContainer_z.Panel2.SuspendLayout();
            this.splitContainer_z.SuspendLayout();
            this.statusStrip_DurumÇubuğu.SuspendLayout();
            this.toolStrip_AraçÇubuğu.SuspendLayout();
            this.tabPage_Ayarlar.SuspendLayout();
            this.groupBox_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ytu)).BeginInit();
            this.groupBox_Graphic.SuspendLayout();
            this.groupBox_seriport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seriPort
            // 
            this.seriPort.DtrEnable = true;
            this.seriPort.ReceivedBytesThreshold = 25;
            this.seriPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriPort_DataReceived);
            // 
            // backgroundWorker_Güncelle
            // 
            this.backgroundWorker_Güncelle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Güncelle_DoWork);
            this.backgroundWorker_Güncelle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Güncelle_RunWorkerCompleted);
            // 
            // tabControl_sekmeler
            // 
            this.tabControl_sekmeler.Controls.Add(this.tabPage_Grafik);
            this.tabControl_sekmeler.Controls.Add(this.tabPage_Ayarlar);
            this.tabControl_sekmeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_sekmeler.Location = new System.Drawing.Point(0, 0);
            this.tabControl_sekmeler.Name = "tabControl_sekmeler";
            this.tabControl_sekmeler.SelectedIndex = 0;
            this.tabControl_sekmeler.Size = new System.Drawing.Size(1031, 543);
            this.tabControl_sekmeler.TabIndex = 0;
            // 
            // tabPage_Grafik
            // 
            this.tabPage_Grafik.Controls.Add(this.splitContainer_xyz);
            this.tabPage_Grafik.Controls.Add(this.statusStrip_DurumÇubuğu);
            this.tabPage_Grafik.Controls.Add(this.toolStrip_AraçÇubuğu);
            this.tabPage_Grafik.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Grafik.Name = "tabPage_Grafik";
            this.tabPage_Grafik.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Grafik.Size = new System.Drawing.Size(1023, 517);
            this.tabPage_Grafik.TabIndex = 1;
            this.tabPage_Grafik.Text = "Graphic Tab";
            this.tabPage_Grafik.UseVisualStyleBackColor = true;
            // 
            // splitContainer_xyz
            // 
            this.splitContainer_xyz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_xyz.Location = new System.Drawing.Point(3, 28);
            this.splitContainer_xyz.Name = "splitContainer_xyz";
            // 
            // splitContainer_xyz.Panel1
            // 
            this.splitContainer_xyz.Panel1.Controls.Add(this.splitContainer_x);
            this.splitContainer_xyz.Panel1MinSize = 0;
            // 
            // splitContainer_xyz.Panel2
            // 
            this.splitContainer_xyz.Panel2.Controls.Add(this.splitContainer_yz);
            this.splitContainer_xyz.Panel2MinSize = 0;
            this.splitContainer_xyz.Size = new System.Drawing.Size(1017, 464);
            this.splitContainer_xyz.SplitterDistance = 336;
            this.splitContainer_xyz.TabIndex = 10;
            // 
            // splitContainer_x
            // 
            this.splitContainer_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_x.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_x.Name = "splitContainer_x";
            this.splitContainer_x.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_x.Panel1
            // 
            this.splitContainer_x.Panel1.Controls.Add(this.zgc_grafik_x1);
            this.splitContainer_x.Panel1MinSize = 0;
            // 
            // splitContainer_x.Panel2
            // 
            this.splitContainer_x.Panel2.Controls.Add(this.zgc_grafik_x2);
            this.splitContainer_x.Panel2Collapsed = true;
            this.splitContainer_x.Panel2MinSize = 0;
            this.splitContainer_x.Size = new System.Drawing.Size(336, 464);
            this.splitContainer_x.SplitterDistance = 239;
            this.splitContainer_x.TabIndex = 0;
            // 
            // zgc_grafik_x1
            // 
            this.zgc_grafik_x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_x1.IsEnableHPan = false;
            this.zgc_grafik_x1.IsEnableHZoom = false;
            this.zgc_grafik_x1.IsEnableVPan = false;
            this.zgc_grafik_x1.IsEnableVZoom = false;
            this.zgc_grafik_x1.IsShowContextMenu = false;
            this.zgc_grafik_x1.IsShowPointValues = true;
            this.zgc_grafik_x1.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_x1.Name = "zgc_grafik_x1";
            this.zgc_grafik_x1.ScrollGrace = 0D;
            this.zgc_grafik_x1.ScrollMaxX = 0D;
            this.zgc_grafik_x1.ScrollMaxY = 0D;
            this.zgc_grafik_x1.ScrollMaxY2 = 0D;
            this.zgc_grafik_x1.ScrollMinX = 0D;
            this.zgc_grafik_x1.ScrollMinY = 0D;
            this.zgc_grafik_x1.ScrollMinY2 = 0D;
            this.zgc_grafik_x1.Size = new System.Drawing.Size(336, 464);
            this.zgc_grafik_x1.TabIndex = 0;
            this.zgc_grafik_x1.UseExtendedPrintDialog = true;
            this.zgc_grafik_x1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_x1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // zgc_grafik_x2
            // 
            this.zgc_grafik_x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_x2.IsEnableHPan = false;
            this.zgc_grafik_x2.IsEnableHZoom = false;
            this.zgc_grafik_x2.IsEnableVPan = false;
            this.zgc_grafik_x2.IsEnableVZoom = false;
            this.zgc_grafik_x2.IsShowContextMenu = false;
            this.zgc_grafik_x2.IsShowPointValues = true;
            this.zgc_grafik_x2.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_x2.Name = "zgc_grafik_x2";
            this.zgc_grafik_x2.ScrollGrace = 0D;
            this.zgc_grafik_x2.ScrollMaxX = 0D;
            this.zgc_grafik_x2.ScrollMaxY = 0D;
            this.zgc_grafik_x2.ScrollMaxY2 = 0D;
            this.zgc_grafik_x2.ScrollMinX = 0D;
            this.zgc_grafik_x2.ScrollMinY = 0D;
            this.zgc_grafik_x2.ScrollMinY2 = 0D;
            this.zgc_grafik_x2.Size = new System.Drawing.Size(150, 46);
            this.zgc_grafik_x2.TabIndex = 3;
            this.zgc_grafik_x2.UseExtendedPrintDialog = true;
            this.zgc_grafik_x2.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_x2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // splitContainer_yz
            // 
            this.splitContainer_yz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_yz.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_yz.Name = "splitContainer_yz";
            // 
            // splitContainer_yz.Panel1
            // 
            this.splitContainer_yz.Panel1.Controls.Add(this.splitContainer_y);
            this.splitContainer_yz.Panel1MinSize = 0;
            // 
            // splitContainer_yz.Panel2
            // 
            this.splitContainer_yz.Panel2.Controls.Add(this.splitContainer_z);
            this.splitContainer_yz.Panel2MinSize = 0;
            this.splitContainer_yz.Size = new System.Drawing.Size(677, 464);
            this.splitContainer_yz.SplitterDistance = 335;
            this.splitContainer_yz.TabIndex = 0;
            // 
            // splitContainer_y
            // 
            this.splitContainer_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_y.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_y.Name = "splitContainer_y";
            this.splitContainer_y.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_y.Panel1
            // 
            this.splitContainer_y.Panel1.Controls.Add(this.zgc_grafik_y1);
            this.splitContainer_y.Panel1MinSize = 0;
            // 
            // splitContainer_y.Panel2
            // 
            this.splitContainer_y.Panel2.Controls.Add(this.zgc_grafik_y2);
            this.splitContainer_y.Panel2Collapsed = true;
            this.splitContainer_y.Panel2MinSize = 0;
            this.splitContainer_y.Size = new System.Drawing.Size(335, 464);
            this.splitContainer_y.SplitterDistance = 239;
            this.splitContainer_y.TabIndex = 0;
            // 
            // zgc_grafik_y1
            // 
            this.zgc_grafik_y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_y1.IsEnableHPan = false;
            this.zgc_grafik_y1.IsEnableHZoom = false;
            this.zgc_grafik_y1.IsEnableVPan = false;
            this.zgc_grafik_y1.IsEnableVZoom = false;
            this.zgc_grafik_y1.IsShowContextMenu = false;
            this.zgc_grafik_y1.IsShowPointValues = true;
            this.zgc_grafik_y1.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_y1.Name = "zgc_grafik_y1";
            this.zgc_grafik_y1.ScrollGrace = 0D;
            this.zgc_grafik_y1.ScrollMaxX = 0D;
            this.zgc_grafik_y1.ScrollMaxY = 0D;
            this.zgc_grafik_y1.ScrollMaxY2 = 0D;
            this.zgc_grafik_y1.ScrollMinX = 0D;
            this.zgc_grafik_y1.ScrollMinY = 0D;
            this.zgc_grafik_y1.ScrollMinY2 = 0D;
            this.zgc_grafik_y1.Size = new System.Drawing.Size(335, 464);
            this.zgc_grafik_y1.TabIndex = 1;
            this.zgc_grafik_y1.UseExtendedPrintDialog = true;
            this.zgc_grafik_y1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_y1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // zgc_grafik_y2
            // 
            this.zgc_grafik_y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_y2.IsEnableHPan = false;
            this.zgc_grafik_y2.IsEnableHZoom = false;
            this.zgc_grafik_y2.IsEnableVPan = false;
            this.zgc_grafik_y2.IsEnableVZoom = false;
            this.zgc_grafik_y2.IsShowContextMenu = false;
            this.zgc_grafik_y2.IsShowPointValues = true;
            this.zgc_grafik_y2.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_y2.Name = "zgc_grafik_y2";
            this.zgc_grafik_y2.ScrollGrace = 0D;
            this.zgc_grafik_y2.ScrollMaxX = 0D;
            this.zgc_grafik_y2.ScrollMaxY = 0D;
            this.zgc_grafik_y2.ScrollMaxY2 = 0D;
            this.zgc_grafik_y2.ScrollMinX = 0D;
            this.zgc_grafik_y2.ScrollMinY = 0D;
            this.zgc_grafik_y2.ScrollMinY2 = 0D;
            this.zgc_grafik_y2.Size = new System.Drawing.Size(150, 46);
            this.zgc_grafik_y2.TabIndex = 4;
            this.zgc_grafik_y2.UseExtendedPrintDialog = true;
            this.zgc_grafik_y2.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_y2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // splitContainer_z
            // 
            this.splitContainer_z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_z.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_z.Name = "splitContainer_z";
            this.splitContainer_z.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_z.Panel1
            // 
            this.splitContainer_z.Panel1.Controls.Add(this.zgc_grafik_z1);
            this.splitContainer_z.Panel1MinSize = 0;
            // 
            // splitContainer_z.Panel2
            // 
            this.splitContainer_z.Panel2.Controls.Add(this.zgc_grafik_z2);
            this.splitContainer_z.Panel2Collapsed = true;
            this.splitContainer_z.Panel2MinSize = 0;
            this.splitContainer_z.Size = new System.Drawing.Size(338, 464);
            this.splitContainer_z.SplitterDistance = 238;
            this.splitContainer_z.TabIndex = 0;
            // 
            // zgc_grafik_z1
            // 
            this.zgc_grafik_z1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_z1.IsEnableHPan = false;
            this.zgc_grafik_z1.IsEnableHZoom = false;
            this.zgc_grafik_z1.IsEnableVPan = false;
            this.zgc_grafik_z1.IsEnableVZoom = false;
            this.zgc_grafik_z1.IsShowContextMenu = false;
            this.zgc_grafik_z1.IsShowPointValues = true;
            this.zgc_grafik_z1.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_z1.Name = "zgc_grafik_z1";
            this.zgc_grafik_z1.ScrollGrace = 0D;
            this.zgc_grafik_z1.ScrollMaxX = 0D;
            this.zgc_grafik_z1.ScrollMaxY = 0D;
            this.zgc_grafik_z1.ScrollMaxY2 = 0D;
            this.zgc_grafik_z1.ScrollMinX = 0D;
            this.zgc_grafik_z1.ScrollMinY = 0D;
            this.zgc_grafik_z1.ScrollMinY2 = 0D;
            this.zgc_grafik_z1.Size = new System.Drawing.Size(338, 464);
            this.zgc_grafik_z1.TabIndex = 2;
            this.zgc_grafik_z1.UseExtendedPrintDialog = true;
            this.zgc_grafik_z1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_z1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_z1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // zgc_grafik_z2
            // 
            this.zgc_grafik_z2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc_grafik_z2.IsEnableHPan = false;
            this.zgc_grafik_z2.IsEnableHZoom = false;
            this.zgc_grafik_z2.IsEnableVPan = false;
            this.zgc_grafik_z2.IsEnableVZoom = false;
            this.zgc_grafik_z2.IsShowContextMenu = false;
            this.zgc_grafik_z2.IsShowPointValues = true;
            this.zgc_grafik_z2.Location = new System.Drawing.Point(0, 0);
            this.zgc_grafik_z2.Name = "zgc_grafik_z2";
            this.zgc_grafik_z2.ScrollGrace = 0D;
            this.zgc_grafik_z2.ScrollMaxX = 0D;
            this.zgc_grafik_z2.ScrollMaxY = 0D;
            this.zgc_grafik_z2.ScrollMaxY2 = 0D;
            this.zgc_grafik_z2.ScrollMinX = 0D;
            this.zgc_grafik_z2.ScrollMinY = 0D;
            this.zgc_grafik_z2.ScrollMinY2 = 0D;
            this.zgc_grafik_z2.Size = new System.Drawing.Size(150, 46);
            this.zgc_grafik_z2.TabIndex = 5;
            this.zgc_grafik_z2.UseExtendedPrintDialog = true;
            this.zgc_grafik_z2.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zgc_grafikler_PointValueEvent);
            this.zgc_grafik_z2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgc_grafikler_KeyPress);
            this.zgc_grafik_z2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zgc_grafikler_MouseWheel);
            // 
            // statusStrip_DurumÇubuğu
            // 
            this.statusStrip_DurumÇubuğu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Durum});
            this.statusStrip_DurumÇubuğu.Location = new System.Drawing.Point(3, 492);
            this.statusStrip_DurumÇubuğu.Name = "statusStrip_DurumÇubuğu";
            this.statusStrip_DurumÇubuğu.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip_DurumÇubuğu.SizingGrip = false;
            this.statusStrip_DurumÇubuğu.TabIndex = 9;
            this.statusStrip_DurumÇubuğu.Text = "Durum Çubuğu";
            // 
            // toolStripStatusLabel_Durum
            // 
            this.toolStripStatusLabel_Durum.Name = "toolStripStatusLabel_Durum";
            this.toolStripStatusLabel_Durum.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel_Durum.Text = "Ready.";
            // 
            // toolStrip_AraçÇubuğu
            // 
            this.toolStrip_AraçÇubuğu.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip_AraçÇubuğu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_AraçÇubuğu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton_Arabellek,
            this.toolStripSeparator5,
            this.toolStripSplitButton_XEkseni,
            this.toolStripSeparator6,
            this.toolStripSplitButton_YEkseni,
            this.toolStripSeparator7,
            this.toolStripSplitButton_ZEkseni,
            this.toolStripSeparator8,
            this.toolStripButton_Restore,
            this.toolStripButton_RealTime});
            this.toolStrip_AraçÇubuğu.Location = new System.Drawing.Point(3, 3);
            this.toolStrip_AraçÇubuğu.Name = "toolStrip_AraçÇubuğu";
            this.toolStrip_AraçÇubuğu.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip_AraçÇubuğu.TabIndex = 8;
            this.toolStrip_AraçÇubuğu.Text = "Araç Çubuğu";
            // 
            // toolStripLabel_SeriPort
            // 
            this.toolStripLabel_SeriPort.Name = "toolStripLabel_SeriPort";
            this.toolStripLabel_SeriPort.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel_SeriPort.Text = "Serial Port :";
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
            this.toolStripButton_SeriPort.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton_SeriPort.Text = "Open Serial Port";
            this.toolStripButton_SeriPort.Click += new System.EventHandler(this.toolStripButton_SeriPort_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_GerçekZaman
            // 
            this.toolStripButton_GerçekZaman.CheckOnClick = true;
            this.toolStripButton_GerçekZaman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_GerçekZaman.Enabled = false;
            this.toolStripButton_GerçekZaman.Name = "toolStripButton_GerçekZaman";
            this.toolStripButton_GerçekZaman.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton_GerçekZaman.Text = "Focus to Realtime";
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
            this.toolStripButton_Arabellek.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton_Arabellek.Text = "Discard In Buffer";
            this.toolStripButton_Arabellek.Click += new System.EventHandler(this.toolStripButton_Arabellek_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton_XEkseni
            // 
            this.toolStripSplitButton_XEkseni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_XEkseni.DoubleClickEnabled = true;
            this.toolStripSplitButton_XEkseni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AutoScaleX,
            this.toolStripTextBox_Xmax,
            this.toolStripTextBox_Xmin,
            this.toolStripMenuItem_ResetX,
            this.toolStripMenuItem_ComparisonX});
            this.toolStripSplitButton_XEkseni.Enabled = false;
            this.toolStripSplitButton_XEkseni.Name = "toolStripSplitButton_XEkseni";
            this.toolStripSplitButton_XEkseni.Size = new System.Drawing.Size(99, 22);
            this.toolStripSplitButton_XEkseni.Text = "X Axis Settings";
            this.toolStripSplitButton_XEkseni.ButtonClick += new System.EventHandler(this.toolStripSplitButton_XEkseni_ButtonClick);
            this.toolStripSplitButton_XEkseni.ButtonDoubleClick += new System.EventHandler(this.toolStripSplitButton_XEkseni_ButtonDoubleClick);
            this.toolStripSplitButton_XEkseni.DropDownClosed += new System.EventHandler(this.toolStripSplitButton_XEkseni_DropDownClosed);
            // 
            // toolStripMenuItem_AutoScaleX
            // 
            this.toolStripMenuItem_AutoScaleX.Checked = true;
            this.toolStripMenuItem_AutoScaleX.CheckOnClick = true;
            this.toolStripMenuItem_AutoScaleX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_AutoScaleX.Name = "toolStripMenuItem_AutoScaleX";
            this.toolStripMenuItem_AutoScaleX.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_AutoScaleX.Text = "Auto Scale";
            this.toolStripMenuItem_AutoScaleX.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_AutoScaleX_CheckedChanged);
            // 
            // toolStripTextBox_Xmax
            // 
            this.toolStripTextBox_Xmax.MaxLength = 4;
            this.toolStripTextBox_Xmax.Name = "toolStripTextBox_Xmax";
            this.toolStripTextBox_Xmax.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Xmax.Text = "180";
            this.toolStripTextBox_Xmax.ToolTipText = "Xmax";
            // 
            // toolStripTextBox_Xmin
            // 
            this.toolStripTextBox_Xmin.MaxLength = 4;
            this.toolStripTextBox_Xmin.Name = "toolStripTextBox_Xmin";
            this.toolStripTextBox_Xmin.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Xmin.Text = "-180";
            this.toolStripTextBox_Xmin.ToolTipText = "Xmin";
            // 
            // toolStripMenuItem_ResetX
            // 
            this.toolStripMenuItem_ResetX.Name = "toolStripMenuItem_ResetX";
            this.toolStripMenuItem_ResetX.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ResetX.Text = "Reset Graph";
            this.toolStripMenuItem_ResetX.Click += new System.EventHandler(this.toolStripMenuItem_ResetX_Click);
            // 
            // toolStripMenuItem_ComparisonX
            // 
            this.toolStripMenuItem_ComparisonX.CheckOnClick = true;
            this.toolStripMenuItem_ComparisonX.Name = "toolStripMenuItem_ComparisonX";
            this.toolStripMenuItem_ComparisonX.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ComparisonX.Text = "Comparison Mode";
            this.toolStripMenuItem_ComparisonX.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_ComparisonX_CheckedChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton_YEkseni
            // 
            this.toolStripSplitButton_YEkseni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_YEkseni.DoubleClickEnabled = true;
            this.toolStripSplitButton_YEkseni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AutoScaleY,
            this.toolStripTextBox_Ymax,
            this.toolStripTextBox_Ymin,
            this.toolStripMenuItem_ResetY,
            this.toolStripMenuItem_ComparisonY});
            this.toolStripSplitButton_YEkseni.Enabled = false;
            this.toolStripSplitButton_YEkseni.Name = "toolStripSplitButton_YEkseni";
            this.toolStripSplitButton_YEkseni.Size = new System.Drawing.Size(99, 22);
            this.toolStripSplitButton_YEkseni.Text = "Y Axis Settings";
            this.toolStripSplitButton_YEkseni.ButtonClick += new System.EventHandler(this.toolStripSplitButton_YEkseni_ButtonClick);
            this.toolStripSplitButton_YEkseni.ButtonDoubleClick += new System.EventHandler(this.toolStripSplitButton_YEkseni_ButtonDoubleClick);
            this.toolStripSplitButton_YEkseni.DropDownClosed += new System.EventHandler(this.toolStripSplitButton_YEkseni_DropDownClosed);
            // 
            // toolStripMenuItem_AutoScaleY
            // 
            this.toolStripMenuItem_AutoScaleY.Checked = true;
            this.toolStripMenuItem_AutoScaleY.CheckOnClick = true;
            this.toolStripMenuItem_AutoScaleY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_AutoScaleY.Name = "toolStripMenuItem_AutoScaleY";
            this.toolStripMenuItem_AutoScaleY.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_AutoScaleY.Text = "Auto Scale";
            this.toolStripMenuItem_AutoScaleY.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_AutoScaleY_CheckedChanged);
            // 
            // toolStripTextBox_Ymax
            // 
            this.toolStripTextBox_Ymax.MaxLength = 4;
            this.toolStripTextBox_Ymax.Name = "toolStripTextBox_Ymax";
            this.toolStripTextBox_Ymax.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Ymax.Text = "180";
            this.toolStripTextBox_Ymax.ToolTipText = "Ymax";
            // 
            // toolStripTextBox_Ymin
            // 
            this.toolStripTextBox_Ymin.MaxLength = 4;
            this.toolStripTextBox_Ymin.Name = "toolStripTextBox_Ymin";
            this.toolStripTextBox_Ymin.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Ymin.Text = "-180";
            this.toolStripTextBox_Ymin.ToolTipText = "Ymin";
            // 
            // toolStripMenuItem_ResetY
            // 
            this.toolStripMenuItem_ResetY.Name = "toolStripMenuItem_ResetY";
            this.toolStripMenuItem_ResetY.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ResetY.Text = "Reset Graph";
            this.toolStripMenuItem_ResetY.Click += new System.EventHandler(this.toolStripMenuItem_ResetY_Click);
            // 
            // toolStripMenuItem_ComparisonY
            // 
            this.toolStripMenuItem_ComparisonY.CheckOnClick = true;
            this.toolStripMenuItem_ComparisonY.Name = "toolStripMenuItem_ComparisonY";
            this.toolStripMenuItem_ComparisonY.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ComparisonY.Text = "Comparison Mode";
            this.toolStripMenuItem_ComparisonY.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_ComparisonY_CheckedChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton_ZEkseni
            // 
            this.toolStripSplitButton_ZEkseni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_ZEkseni.DoubleClickEnabled = true;
            this.toolStripSplitButton_ZEkseni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AutoScaleZ,
            this.toolStripTextBox_Zmax,
            this.toolStripTextBox_Zmin,
            this.toolStripMenuItem_ResetZ,
            this.toolStripMenuItem_ComparisonZ});
            this.toolStripSplitButton_ZEkseni.Enabled = false;
            this.toolStripSplitButton_ZEkseni.Name = "toolStripSplitButton_ZEkseni";
            this.toolStripSplitButton_ZEkseni.Size = new System.Drawing.Size(99, 22);
            this.toolStripSplitButton_ZEkseni.Text = "Z Axis Settings";
            this.toolStripSplitButton_ZEkseni.ButtonClick += new System.EventHandler(this.toolStripSplitButton_ZEkseni_ButtonClick);
            this.toolStripSplitButton_ZEkseni.ButtonDoubleClick += new System.EventHandler(this.toolStripSplitButton_ZEkseni_ButtonDoubleClick);
            this.toolStripSplitButton_ZEkseni.DropDownClosed += new System.EventHandler(this.toolStripSplitButton_ZEkseni_DropDownClosed);
            // 
            // toolStripMenuItem_AutoScaleZ
            // 
            this.toolStripMenuItem_AutoScaleZ.Checked = true;
            this.toolStripMenuItem_AutoScaleZ.CheckOnClick = true;
            this.toolStripMenuItem_AutoScaleZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_AutoScaleZ.Name = "toolStripMenuItem_AutoScaleZ";
            this.toolStripMenuItem_AutoScaleZ.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_AutoScaleZ.Text = "Auto Scale";
            this.toolStripMenuItem_AutoScaleZ.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_AutoScaleZ_CheckedChanged);
            // 
            // toolStripTextBox_Zmax
            // 
            this.toolStripTextBox_Zmax.MaxLength = 4;
            this.toolStripTextBox_Zmax.Name = "toolStripTextBox_Zmax";
            this.toolStripTextBox_Zmax.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Zmax.Text = "180";
            this.toolStripTextBox_Zmax.ToolTipText = "Zmax";
            // 
            // toolStripTextBox_Zmin
            // 
            this.toolStripTextBox_Zmin.MaxLength = 4;
            this.toolStripTextBox_Zmin.Name = "toolStripTextBox_Zmin";
            this.toolStripTextBox_Zmin.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Zmin.Text = "-180";
            this.toolStripTextBox_Zmin.ToolTipText = "Zmin";
            // 
            // toolStripMenuItem_ResetZ
            // 
            this.toolStripMenuItem_ResetZ.Name = "toolStripMenuItem_ResetZ";
            this.toolStripMenuItem_ResetZ.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ResetZ.Text = "Reset Graph";
            this.toolStripMenuItem_ResetZ.Click += new System.EventHandler(this.toolStripMenuItem_ResetZ_Click);
            // 
            // toolStripMenuItem_ComparisonZ
            // 
            this.toolStripMenuItem_ComparisonZ.CheckOnClick = true;
            this.toolStripMenuItem_ComparisonZ.Name = "toolStripMenuItem_ComparisonZ";
            this.toolStripMenuItem_ComparisonZ.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem_ComparisonZ.Text = "Comparison Mode";
            this.toolStripMenuItem_ComparisonZ.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_ComparisonZ_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Restore
            // 
            this.toolStripButton_Restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Restore.Enabled = false;
            this.toolStripButton_Restore.Name = "toolStripButton_Restore";
            this.toolStripButton_Restore.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton_Restore.Text = "Restore View";
            this.toolStripButton_Restore.Click += new System.EventHandler(this.toolStripButton_Restore_Click);
            // 
            // toolStripButton_RealTime
            // 
            this.toolStripButton_RealTime.Checked = true;
            this.toolStripButton_RealTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton_RealTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_RealTime.Enabled = false;
            this.toolStripButton_RealTime.Name = "toolStripButton_RealTime";
            this.toolStripButton_RealTime.Size = new System.Drawing.Size(23, 22);
            // 
            // tabPage_Ayarlar
            // 
            this.tabPage_Ayarlar.Controls.Add(this.groupBox_about);
            this.tabPage_Ayarlar.Controls.Add(this.groupBox_Graphic);
            this.tabPage_Ayarlar.Controls.Add(this.groupBox_seriport);
            this.tabPage_Ayarlar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Ayarlar.Name = "tabPage_Ayarlar";
            this.tabPage_Ayarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Ayarlar.Size = new System.Drawing.Size(1023, 517);
            this.tabPage_Ayarlar.TabIndex = 2;
            this.tabPage_Ayarlar.Text = "Settings Tab";
            this.tabPage_Ayarlar.UseVisualStyleBackColor = true;
            // 
            // groupBox_about
            // 
            this.groupBox_about.Controls.Add(this.pictureBox1);
            this.groupBox_about.Controls.Add(this.label_about);
            this.groupBox_about.Controls.Add(this.pictureBox_ytu);
            this.groupBox_about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_about.Location = new System.Drawing.Point(546, 3);
            this.groupBox_about.Name = "groupBox_about";
            this.groupBox_about.Size = new System.Drawing.Size(474, 511);
            this.groupBox_about.TabIndex = 13;
            this.groupBox_about.TabStop = false;
            this.groupBox_about.Text = "About";
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Location = new System.Drawing.Point(6, 221);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(357, 247);
            this.label_about.TabIndex = 1;
            this.label_about.Text = resources.GetString("label_about.Text");
            // 
            // pictureBox_ytu
            // 
            this.pictureBox_ytu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ytu.Image")));
            this.pictureBox_ytu.Location = new System.Drawing.Point(145, 11);
            this.pictureBox_ytu.Name = "pictureBox_ytu";
            this.pictureBox_ytu.Size = new System.Drawing.Size(212, 194);
            this.pictureBox_ytu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ytu.TabIndex = 0;
            this.pictureBox_ytu.TabStop = false;
            // 
            // groupBox_Graphic
            // 
            this.groupBox_Graphic.Controls.Add(this.comboBox_Symbol);
            this.groupBox_Graphic.Controls.Add(this.label_symbol);
            this.groupBox_Graphic.Controls.Add(this.button_color);
            this.groupBox_Graphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_Graphic.Location = new System.Drawing.Point(290, 3);
            this.groupBox_Graphic.Name = "groupBox_Graphic";
            this.groupBox_Graphic.Size = new System.Drawing.Size(256, 511);
            this.groupBox_Graphic.TabIndex = 12;
            this.groupBox_Graphic.TabStop = false;
            this.groupBox_Graphic.Text = "Graphic Settings";
            // 
            // comboBox_Symbol
            // 
            this.comboBox_Symbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Symbol.FormattingEnabled = true;
            this.comboBox_Symbol.Items.AddRange(new object[] {
            "Square",
            "Diamond",
            "Triangle",
            "Circle",
            "XCross",
            "Plus",
            "Star",
            "TriangleDown",
            "HDash",
            "VDash",
            "None"});
            this.comboBox_Symbol.Location = new System.Drawing.Point(127, 34);
            this.comboBox_Symbol.Name = "comboBox_Symbol";
            this.comboBox_Symbol.Size = new System.Drawing.Size(115, 21);
            this.comboBox_Symbol.TabIndex = 2;
            this.comboBox_Symbol.SelectedIndexChanged += new System.EventHandler(this.comboBox_Symbol_SelectedIndexChanged);
            // 
            // label_symbol
            // 
            this.label_symbol.AutoSize = true;
            this.label_symbol.Location = new System.Drawing.Point(126, 18);
            this.label_symbol.Name = "label_symbol";
            this.label_symbol.Size = new System.Drawing.Size(116, 13);
            this.label_symbol.TabIndex = 1;
            this.label_symbol.Text = "Change Data Symbol : ";
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(6, 24);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(105, 32);
            this.button_color.TabIndex = 0;
            this.button_color.Text = "Change Data Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // groupBox_seriport
            // 
            this.groupBox_seriport.Controls.Add(this.propertyGrid_seriport);
            this.groupBox_seriport.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_seriport.Location = new System.Drawing.Point(3, 3);
            this.groupBox_seriport.Name = "groupBox_seriport";
            this.groupBox_seriport.Size = new System.Drawing.Size(287, 511);
            this.groupBox_seriport.TabIndex = 11;
            this.groupBox_seriport.TabStop = false;
            this.groupBox_seriport.Text = "Serial Port Properties";
            // 
            // propertyGrid_seriport
            // 
            this.propertyGrid_seriport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_seriport.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid_seriport.Name = "propertyGrid_seriport";
            this.propertyGrid_seriport.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid_seriport.SelectedObject = this.seriPort;
            this.propertyGrid_seriport.Size = new System.Drawing.Size(281, 492);
            this.propertyGrid_seriport.TabIndex = 10;
            this.propertyGrid_seriport.ToolbarVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 543);
            this.Controls.Add(this.tabControl_sekmeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1047, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechatronics Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl_sekmeler.ResumeLayout(false);
            this.tabPage_Grafik.ResumeLayout(false);
            this.tabPage_Grafik.PerformLayout();
            this.splitContainer_xyz.Panel1.ResumeLayout(false);
            this.splitContainer_xyz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_xyz)).EndInit();
            this.splitContainer_xyz.ResumeLayout(false);
            this.splitContainer_x.Panel1.ResumeLayout(false);
            this.splitContainer_x.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_x)).EndInit();
            this.splitContainer_x.ResumeLayout(false);
            this.splitContainer_yz.Panel1.ResumeLayout(false);
            this.splitContainer_yz.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_yz)).EndInit();
            this.splitContainer_yz.ResumeLayout(false);
            this.splitContainer_y.Panel1.ResumeLayout(false);
            this.splitContainer_y.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_y)).EndInit();
            this.splitContainer_y.ResumeLayout(false);
            this.splitContainer_z.Panel1.ResumeLayout(false);
            this.splitContainer_z.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_z)).EndInit();
            this.splitContainer_z.ResumeLayout(false);
            this.statusStrip_DurumÇubuğu.ResumeLayout(false);
            this.statusStrip_DurumÇubuğu.PerformLayout();
            this.toolStrip_AraçÇubuğu.ResumeLayout(false);
            this.toolStrip_AraçÇubuğu.PerformLayout();
            this.tabPage_Ayarlar.ResumeLayout(false);
            this.groupBox_about.ResumeLayout(false);
            this.groupBox_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ytu)).EndInit();
            this.groupBox_Graphic.ResumeLayout(false);
            this.groupBox_Graphic.PerformLayout();
            this.groupBox_seriport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort seriPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Güncelle;
        private System.Windows.Forms.TabControl tabControl_sekmeler;
        private System.Windows.Forms.TabPage tabPage_Grafik;
        private System.Windows.Forms.ToolStrip toolStrip_AraçÇubuğu;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SeriPortlar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_SeriPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_BaudRate;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_BaudRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_SeriPort;
        private System.Windows.Forms.TabPage tabPage_Ayarlar;
        private System.Windows.Forms.PropertyGrid propertyGrid_seriport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Arabellek;
        private System.Windows.Forms.StatusStrip statusStrip_DurumÇubuğu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Durum;
        private System.Windows.Forms.SplitContainer splitContainer_xyz;
        private System.Windows.Forms.SplitContainer splitContainer_yz;
        private System.Windows.Forms.ToolStripButton toolStripButton_GerçekZaman;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_XEkseni;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AutoScaleX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Xmax;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Xmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_YEkseni;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AutoScaleY;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Ymax;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Ymin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_ZEkseni;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AutoScaleZ;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Zmax;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Zmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_RealTime;
        private System.Windows.Forms.ToolStripButton toolStripButton_Restore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetY;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetZ;
        private System.Windows.Forms.SplitContainer splitContainer_x;
        private System.Windows.Forms.SplitContainer splitContainer_y;
        private System.Windows.Forms.SplitContainer splitContainer_z;
        private ZedGraph.ZedGraphControl zgc_grafik_x1;
        private ZedGraph.ZedGraphControl zgc_grafik_y1;
        private ZedGraph.ZedGraphControl zgc_grafik_z1;
        private ZedGraph.ZedGraphControl zgc_grafik_x2;
        private ZedGraph.ZedGraphControl zgc_grafik_y2;
        private ZedGraph.ZedGraphControl zgc_grafik_z2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ComparisonX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ComparisonY;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ComparisonZ;
        private System.Windows.Forms.GroupBox groupBox_seriport;
        private System.Windows.Forms.GroupBox groupBox_Graphic;
        private System.Windows.Forms.ColorDialog colorDialog_veri;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ComboBox comboBox_Symbol;
        private System.Windows.Forms.Label label_symbol;
        private System.Windows.Forms.GroupBox groupBox_about;
        private System.Windows.Forms.PictureBox pictureBox_ytu;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

