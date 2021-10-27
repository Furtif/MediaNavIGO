namespace MediaNavIGO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContextMenuStripUSB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetUSBFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripStats = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGlobalFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNaviSync = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWorkLocal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInUSB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarUpdate = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelReadyTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenuStripLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetLocalFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToUsbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.fastObjectListViewLocal = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnLocalFolderType = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnLocalName = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnLocalInUSB = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnLocalUpdate = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnLocalUsbName = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnKey = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnValue = new BrightIdeasSoftware.OLVColumn();
            this.tabPageUSB = new System.Windows.Forms.TabPage();
            this.fastObjectListViewUSB = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnUSBFolderType = new BrightIdeasSoftware.OLVColumn();
            this.olvColumnUSBName = new BrightIdeasSoftware.OLVColumn();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.progressBarUpdate = new System.Windows.Forms.ProgressBar();
            this.buttonStartUpdate = new System.Windows.Forms.Button();
            this.checkBoxOnlyExists = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fastObjectListViewDevice = new BrightIdeasSoftware.FastObjectListView();
            this.buttonSelectLocalFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.buttonSelectUSBFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUSB = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialogBoth = new System.Windows.Forms.FolderBrowserDialog();
            this.ContextMenuStripUSB.SuspendLayout();
            this.StatusStripStats.SuspendLayout();
            this.ContextMenuStripLocal.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLocal)).BeginInit();
            this.tabPageUSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewUSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewDevice)).BeginInit();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SuspendLayout();
            // 
            // ContextMenuStripUSB
            // 
            this.ContextMenuStripUSB.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ContextMenuStripUSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetUSBFolderToolStripMenuItem});
            this.ContextMenuStripUSB.Name = "contextMenuStrip1";
            this.ContextMenuStripUSB.Size = new System.Drawing.Size(171, 28);
            // 
            // SetUSBFolderToolStripMenuItem
            // 
            this.SetUSBFolderToolStripMenuItem.Name = "SetUSBFolderToolStripMenuItem";
            this.SetUSBFolderToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.SetUSBFolderToolStripMenuItem.Text = "Set usb folder";
            this.SetUSBFolderToolStripMenuItem.Click += new System.EventHandler(this.SetUSBFolderToolStripMenuItem_Click);
            // 
            // StatusStripStats
            // 
            this.StatusStripStats.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.StatusStripStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelGlobalFiles,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabelNaviSync,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabelWorkLocal,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabelInUSB,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelUpdate,
            this.toolStripProgressBarUpdate,
            this.toolStripStatusLabelReadyTxt,
            this.toolStripStatusLabelReady});
            this.StatusStripStats.Location = new System.Drawing.Point(0, 515);
            this.StatusStripStats.Name = "StatusStripStats";
            this.StatusStripStats.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusStripStats.Size = new System.Drawing.Size(1325, 26);
            this.StatusStripStats.TabIndex = 1;
            this.StatusStripStats.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 20);
            this.toolStripStatusLabel1.Text = "Global:";
            // 
            // toolStripStatusLabelGlobalFiles
            // 
            this.toolStripStatusLabelGlobalFiles.Name = "toolStripStatusLabelGlobalFiles";
            this.toolStripStatusLabelGlobalFiles.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelGlobalFiles.Text = "0";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(72, 21);
            this.toolStripStatusLabel8.Text = "NaviSync:";
            // 
            // toolStripStatusLabelNaviSync
            // 
            this.toolStripStatusLabelNaviSync.Name = "toolStripStatusLabelNaviSync";
            this.toolStripStatusLabelNaviSync.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelNaviSync.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(46, 21);
            this.toolStripStatusLabel6.Text = "Work:";
            // 
            // toolStripStatusLabelWorkLocal
            // 
            this.toolStripStatusLabelWorkLocal.Name = "toolStripStatusLabelWorkLocal";
            this.toolStripStatusLabelWorkLocal.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelWorkLocal.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(51, 21);
            this.toolStripStatusLabel4.Text = "InUSB:";
            // 
            // toolStripStatusLabelInUSB
            // 
            this.toolStripStatusLabelInUSB.Name = "toolStripStatusLabelInUSB";
            this.toolStripStatusLabelInUSB.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelInUSB.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(61, 21);
            this.toolStripStatusLabel2.Text = "Update:";
            // 
            // toolStripStatusLabelUpdate
            // 
            this.toolStripStatusLabelUpdate.Name = "toolStripStatusLabelUpdate";
            this.toolStripStatusLabelUpdate.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelUpdate.Text = "0";
            // 
            // toolStripProgressBarUpdate
            // 
            this.toolStripProgressBarUpdate.Margin = new System.Windows.Forms.Padding(10, 4, 1, 4);
            this.toolStripProgressBarUpdate.Name = "toolStripProgressBarUpdate";
            this.toolStripProgressBarUpdate.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBarUpdate.Visible = false;
            // 
            // toolStripStatusLabelReadyTxt
            // 
            this.toolStripStatusLabelReadyTxt.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabelReadyTxt.Name = "toolStripStatusLabelReadyTxt";
            this.toolStripStatusLabelReadyTxt.Size = new System.Drawing.Size(53, 21);
            this.toolStripStatusLabelReadyTxt.Text = "Ready:";
            // 
            // toolStripStatusLabelReady
            // 
            this.toolStripStatusLabelReady.Name = "toolStripStatusLabelReady";
            this.toolStripStatusLabelReady.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelReady.Text = "0";
            // 
            // ContextMenuStripLocal
            // 
            this.ContextMenuStripLocal.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ContextMenuStripLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetLocalFolderToolStripMenuItem,
            this.sendToUsbToolStripMenuItem});
            this.ContextMenuStripLocal.Name = "contextMenuStripProxy";
            this.ContextMenuStripLocal.Size = new System.Drawing.Size(199, 52);
            // 
            // SetLocalFolderToolStripMenuItem
            // 
            this.SetLocalFolderToolStripMenuItem.Name = "SetLocalFolderToolStripMenuItem";
            this.SetLocalFolderToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.SetLocalFolderToolStripMenuItem.Text = "Select local folder";
            this.SetLocalFolderToolStripMenuItem.Click += new System.EventHandler(this.SetLocalFolderToolStripMenuItem_Click);
            // 
            // sendToUsbToolStripMenuItem
            // 
            this.sendToUsbToolStripMenuItem.Name = "sendToUsbToolStripMenuItem";
            this.sendToUsbToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.sendToUsbToolStripMenuItem.Text = "Update";
            this.sendToUsbToolStripMenuItem.Click += new System.EventHandler(this.SendToUsbToolStripMenuItem_Click);
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.fastObjectListViewLocal);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 29);
            this.tabPageLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLocal.Size = new System.Drawing.Size(1317, 482);
            this.tabPageLocal.TabIndex = 1;
            this.tabPageLocal.Text = "Work\'s folder";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // fastObjectListViewLocal
            // 
            this.fastObjectListViewLocal.AllColumns.Add(this.olvColumnLocalFolderType);
            this.fastObjectListViewLocal.AllColumns.Add(this.olvColumnLocalName);
            this.fastObjectListViewLocal.AllColumns.Add(this.olvColumnLocalInUSB);
            this.fastObjectListViewLocal.AllColumns.Add(this.olvColumnLocalUpdate);
            this.fastObjectListViewLocal.AllColumns.Add(this.olvColumnLocalUsbName);
            this.fastObjectListViewLocal.AllowColumnReorder = true;
            this.fastObjectListViewLocal.CellEditUseWholeCell = false;
            this.fastObjectListViewLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnLocalFolderType,
            this.olvColumnLocalName,
            this.olvColumnLocalInUSB,
            this.olvColumnLocalUpdate,
            this.olvColumnLocalUsbName});
            this.fastObjectListViewLocal.ContextMenuStrip = this.ContextMenuStripLocal;
            this.fastObjectListViewLocal.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListViewLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListViewLocal.FullRowSelect = true;
            this.fastObjectListViewLocal.Location = new System.Drawing.Point(3, 2);
            this.fastObjectListViewLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastObjectListViewLocal.Name = "fastObjectListViewLocal";
            this.fastObjectListViewLocal.ShowGroups = false;
            this.fastObjectListViewLocal.Size = new System.Drawing.Size(1311, 478);
            this.fastObjectListViewLocal.TabIndex = 1;
            this.fastObjectListViewLocal.UseCellFormatEvents = true;
            this.fastObjectListViewLocal.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewLocal.UseFiltering = true;
            this.fastObjectListViewLocal.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewLocal.VirtualMode = true;
            this.fastObjectListViewLocal.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.FastObjectListViewLocal_FormatCell);
            this.fastObjectListViewLocal.DoubleClick += new System.EventHandler(this.FastObjectListViewLocal_DoubleClick);
            // 
            // olvColumnLocalFolderType
            // 
            this.olvColumnLocalFolderType.AspectName = "FolderType";
            this.olvColumnLocalFolderType.Text = "FolderType";
            this.olvColumnLocalFolderType.Width = 100;
            // 
            // olvColumnLocalName
            // 
            this.olvColumnLocalName.AspectName = "Name";
            this.olvColumnLocalName.Text = "Name";
            this.olvColumnLocalName.Width = 500;
            // 
            // olvColumnLocalInUSB
            // 
            this.olvColumnLocalInUSB.AspectName = "InUSB";
            this.olvColumnLocalInUSB.Text = "InUSB";
            this.olvColumnLocalInUSB.Width = 90;
            // 
            // olvColumnLocalUpdate
            // 
            this.olvColumnLocalUpdate.AspectName = "Update";
            this.olvColumnLocalUpdate.Text = "Update";
            this.olvColumnLocalUpdate.Width = 90;
            // 
            // olvColumnLocalUsbName
            // 
            this.olvColumnLocalUsbName.AspectName = "RealName";
            this.olvColumnLocalUsbName.Text = "RealName";
            this.olvColumnLocalUsbName.Width = 500;
            // 
            // olvColumnKey
            // 
            this.olvColumnKey.AspectName = "Key";
            this.olvColumnKey.Text = "Key";
            this.olvColumnKey.Width = 150;
            // 
            // olvColumnValue
            // 
            this.olvColumnValue.AspectName = "Value";
            this.olvColumnValue.Text = "Value";
            this.olvColumnValue.Width = 480;
            // 
            // tabPageUSB
            // 
            this.tabPageUSB.BackColor = System.Drawing.Color.Transparent;
            this.tabPageUSB.Controls.Add(this.fastObjectListViewUSB);
            this.tabPageUSB.Location = new System.Drawing.Point(4, 29);
            this.tabPageUSB.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageUSB.Name = "tabPageUSB";
            this.tabPageUSB.Size = new System.Drawing.Size(1317, 482);
            this.tabPageUSB.TabIndex = 0;
            this.tabPageUSB.Text = "NaviSync folder";
            this.tabPageUSB.UseVisualStyleBackColor = true;
            // 
            // fastObjectListViewUSB
            // 
            this.fastObjectListViewUSB.AllColumns.Add(this.olvColumnUSBFolderType);
            this.fastObjectListViewUSB.AllColumns.Add(this.olvColumnUSBName);
            this.fastObjectListViewUSB.AllowColumnReorder = true;
            this.fastObjectListViewUSB.CellEditUseWholeCell = false;
            this.fastObjectListViewUSB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnUSBFolderType,
            this.olvColumnUSBName});
            this.fastObjectListViewUSB.ContextMenuStrip = this.ContextMenuStripUSB;
            this.fastObjectListViewUSB.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListViewUSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListViewUSB.FullRowSelect = true;
            this.fastObjectListViewUSB.Location = new System.Drawing.Point(0, 0);
            this.fastObjectListViewUSB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastObjectListViewUSB.Name = "fastObjectListViewUSB";
            this.fastObjectListViewUSB.ShowGroups = false;
            this.fastObjectListViewUSB.Size = new System.Drawing.Size(1317, 482);
            this.fastObjectListViewUSB.TabIndex = 0;
            this.fastObjectListViewUSB.UseCellFormatEvents = true;
            this.fastObjectListViewUSB.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewUSB.UseFiltering = true;
            this.fastObjectListViewUSB.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewUSB.VirtualMode = true;
            this.fastObjectListViewUSB.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.FastObjectListViewUSB_FormatCell);
            // 
            // olvColumnUSBFolderType
            // 
            this.olvColumnUSBFolderType.AspectName = "FolderType";
            this.olvColumnUSBFolderType.Text = "FolderType";
            this.olvColumnUSBFolderType.Width = 100;
            // 
            // olvColumnUSBName
            // 
            this.olvColumnUSBName.AspectName = "Name";
            this.olvColumnUSBName.Text = "Name";
            this.olvColumnUSBName.Width = 500;
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Image = global::MediaNavIGO.Resources.Resources.PayPalDonateNow;
            this.pictureBoxAbout.Location = new System.Drawing.Point(1206, 518);
            this.pictureBoxAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(94, 20);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAbout.TabIndex = 6;
            this.pictureBoxAbout.TabStop = false;
            this.pictureBoxAbout.Click += new System.EventHandler(this.PictureBoxAbout_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Controls.Add(this.tabPageUSB);
            this.tabControlMain.Controls.Add(this.tabPageLocal);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1325, 515);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.progressBarUpdate);
            this.tabPageConfig.Controls.Add(this.buttonStartUpdate);
            this.tabPageConfig.Controls.Add(this.checkBoxOnlyExists);
            this.tabPageConfig.Controls.Add(this.label3);
            this.tabPageConfig.Controls.Add(this.fastObjectListViewDevice);
            this.tabPageConfig.Controls.Add(this.buttonSelectLocalFolder);
            this.tabPageConfig.Controls.Add(this.label2);
            this.tabPageConfig.Controls.Add(this.textBoxLocal);
            this.tabPageConfig.Controls.Add(this.buttonSelectUSBFolder);
            this.tabPageConfig.Controls.Add(this.label1);
            this.tabPageConfig.Controls.Add(this.textBoxUSB);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Size = new System.Drawing.Size(1317, 482);
            this.tabPageConfig.TabIndex = 2;
            this.tabPageConfig.Text = "Main [config/commands]";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // progressBarUpdate
            // 
            this.progressBarUpdate.Location = new System.Drawing.Point(157, 450);
            this.progressBarUpdate.Name = "progressBarUpdate";
            this.progressBarUpdate.Size = new System.Drawing.Size(489, 27);
            this.progressBarUpdate.TabIndex = 10;
            // 
            // buttonStartUpdate
            // 
            this.buttonStartUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStartUpdate.Location = new System.Drawing.Point(8, 450);
            this.buttonStartUpdate.Name = "buttonStartUpdate";
            this.buttonStartUpdate.Size = new System.Drawing.Size(143, 27);
            this.buttonStartUpdate.TabIndex = 9;
            this.buttonStartUpdate.Text = "Start update";
            this.buttonStartUpdate.UseVisualStyleBackColor = true;
            this.buttonStartUpdate.Click += new System.EventHandler(this.ButtonStartUpdate_Click);
            // 
            // checkBoxOnlyExists
            // 
            this.checkBoxOnlyExists.AutoSize = true;
            this.checkBoxOnlyExists.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOnlyExists.Location = new System.Drawing.Point(8, 71);
            this.checkBoxOnlyExists.Name = "checkBoxOnlyExists";
            this.checkBoxOnlyExists.Size = new System.Drawing.Size(306, 24);
            this.checkBoxOnlyExists.TabIndex = 8;
            this.checkBoxOnlyExists.Text = "Update only present into NaviSync folder:";
            this.checkBoxOnlyExists.UseVisualStyleBackColor = true;
            this.checkBoxOnlyExists.CheckedChanged += new System.EventHandler(this.CheckBoxOnlyExists_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device Infos:";
            // 
            // fastObjectListViewDevice
            // 
            this.fastObjectListViewDevice.AllColumns.Add(this.olvColumnUSBFolderType);
            this.fastObjectListViewDevice.AllColumns.Add(this.olvColumnUSBName);
            this.fastObjectListViewDevice.AllowColumnReorder = true;
            this.fastObjectListViewDevice.CellEditUseWholeCell = false;
            this.fastObjectListViewDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnKey,
            this.olvColumnValue});
            this.fastObjectListViewDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListViewDevice.FullRowSelect = true;
            this.fastObjectListViewDevice.Location = new System.Drawing.Point(8, 120);
            this.fastObjectListViewDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastObjectListViewDevice.Name = "fastObjectListViewDevice";
            this.fastObjectListViewDevice.ShowGroups = false;
            this.fastObjectListViewDevice.Size = new System.Drawing.Size(638, 325);
            this.fastObjectListViewDevice.TabIndex = 6;
            this.fastObjectListViewDevice.UseCellFormatEvents = true;
            this.fastObjectListViewDevice.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewDevice.UseFiltering = true;
            this.fastObjectListViewDevice.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewDevice.VirtualMode = true;
            // 
            // buttonSelectLocalFolder
            // 
            this.buttonSelectLocalFolder.Location = new System.Drawing.Point(534, 38);
            this.buttonSelectLocalFolder.Name = "buttonSelectLocalFolder";
            this.buttonSelectLocalFolder.Size = new System.Drawing.Size(112, 27);
            this.buttonSelectLocalFolder.TabIndex = 5;
            this.buttonSelectLocalFolder.Text = "Find...";
            this.buttonSelectLocalFolder.UseVisualStyleBackColor = true;
            this.buttonSelectLocalFolder.Click += new System.EventHandler(this.ButtonSelectLocalFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local Work Folder:";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(157, 38);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(371, 27);
            this.textBoxLocal.TabIndex = 3;
            // 
            // buttonSelectUSBFolder
            // 
            this.buttonSelectUSBFolder.Location = new System.Drawing.Point(534, 5);
            this.buttonSelectUSBFolder.Name = "buttonSelectUSBFolder";
            this.buttonSelectUSBFolder.Size = new System.Drawing.Size(112, 27);
            this.buttonSelectUSBFolder.TabIndex = 2;
            this.buttonSelectUSBFolder.Text = "Find...";
            this.buttonSelectUSBFolder.UseVisualStyleBackColor = true;
            this.buttonSelectUSBFolder.Click += new System.EventHandler(this.ButtonSelectUSBFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NaviSync USB Folder:";
            // 
            // textBoxUSB
            // 
            this.textBoxUSB.Location = new System.Drawing.Point(157, 5);
            this.textBoxUSB.Name = "textBoxUSB";
            this.textBoxUSB.Size = new System.Drawing.Size(371, 27);
            this.textBoxUSB.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 541);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.StatusStripStats);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MediaNavIGO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContextMenuStripUSB.ResumeLayout(false);
            this.StatusStripStats.ResumeLayout(false);
            this.StatusStripStats.PerformLayout();
            this.ContextMenuStripLocal.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLocal)).EndInit();
            this.tabPageUSB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewUSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripUSB;
        private System.Windows.Forms.StatusStrip StatusStripStats;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGlobalFiles;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripLocal;
        private System.Windows.Forms.ToolStripMenuItem SetUSBFolderToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageLocal;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewLocal;
        private BrightIdeasSoftware.OLVColumn olvColumnLocalFolderType;
        private BrightIdeasSoftware.OLVColumn olvColumnKey; 
        private BrightIdeasSoftware.OLVColumn olvColumnValue;
        private BrightIdeasSoftware.OLVColumn olvColumnLocalName;
        private BrightIdeasSoftware.OLVColumn olvColumnLocalInUSB;
        private BrightIdeasSoftware.OLVColumn olvColumnLocalUpdate;
        private BrightIdeasSoftware.OLVColumn olvColumnLocalUsbName;
        private System.Windows.Forms.TabPage tabPageUSB;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewUSB;
        private BrightIdeasSoftware.OLVColumn olvColumnUSBFolderType;
        private BrightIdeasSoftware.OLVColumn olvColumnUSBName;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.ToolStripMenuItem SetLocalFolderToolStripMenuItem;
        private FolderBrowserDialog FolderBrowserDialogBoth;
        private TabPage tabPageConfig;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewDevice;
        private Button buttonSelectLocalFolder;
        private Label label2;
        private TextBox textBoxLocal;
        private Button buttonSelectUSBFolder;
        private Label label1;
        private TextBox textBoxUSB;
        private Label label3;
        private ToolStripMenuItem sendToUsbToolStripMenuItem;
        private CheckBox checkBoxOnlyExists;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel toolStripStatusLabelNaviSync;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabelWorkLocal;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabelInUSB;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabelUpdate;
        private ProgressBar progressBarUpdate;
        private Button buttonStartUpdate;
        private ToolStripProgressBar toolStripProgressBarUpdate;
        private ToolStripStatusLabel toolStripStatusLabelReadyTxt;
        private ToolStripStatusLabel toolStripStatusLabelReady;
    }
}
