namespace boatRental
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.leastUsed = new System.Windows.Forms.Label();
            this.totalDamageLabel = new System.Windows.Forms.Label();
            this.mostConsumed = new System.Windows.Forms.Label();
            this.leastUsedButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.mostConsumedButton = new System.Windows.Forms.Button();
            this.totalRentTime = new System.Windows.Forms.Label();
            this.totalRentTimeButton = new System.Windows.Forms.Button();
            this.totalRevenue = new System.Windows.Forms.Label();
            this.totalRevenueButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rentTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRentButton = new System.Windows.Forms.Button();
            this.damageInput = new System.Windows.Forms.ComboBox();
            this.usedFuelInput = new System.Windows.Forms.TextBox();
            this.boatInput = new System.Windows.Forms.ComboBox();
            this.startInput = new System.Windows.Forms.TextBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boatTab = new System.Windows.Forms.TabPage();
            this.boats = new System.Windows.Forms.Label();
            this.totalBoats = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.rentTab.SuspendLayout();
            this.boatTab.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.overviewTab);
            this.tabControl1.Controls.Add(this.rentTab);
            this.tabControl1.Controls.Add(this.boatTab);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.leastUsed);
            this.overviewTab.Controls.Add(this.totalDamageLabel);
            this.overviewTab.Controls.Add(this.mostConsumed);
            this.overviewTab.Controls.Add(this.leastUsedButton);
            this.overviewTab.Controls.Add(this.damageButton);
            this.overviewTab.Controls.Add(this.mostConsumedButton);
            this.overviewTab.Controls.Add(this.totalRentTime);
            this.overviewTab.Controls.Add(this.totalRentTimeButton);
            this.overviewTab.Controls.Add(this.totalRevenue);
            this.overviewTab.Controls.Add(this.totalRevenueButton);
            this.overviewTab.Controls.Add(this.label7);
            this.overviewTab.Location = new System.Drawing.Point(4, 29);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(792, 406);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // leastUsed
            // 
            this.leastUsed.AutoSize = true;
            this.leastUsed.Location = new System.Drawing.Point(17, 370);
            this.leastUsed.Name = "leastUsed";
            this.leastUsed.Size = new System.Drawing.Size(120, 20);
            this.leastUsed.TabIndex = 10;
            this.leastUsed.Text = "Least used boat: ";
            // 
            // totalDamageLabel
            // 
            this.totalDamageLabel.AutoSize = true;
            this.totalDamageLabel.Location = new System.Drawing.Point(18, 295);
            this.totalDamageLabel.Name = "totalDamageLabel";
            this.totalDamageLabel.Size = new System.Drawing.Size(187, 20);
            this.totalDamageLabel.TabIndex = 9;
            this.totalDamageLabel.Text = "Total percentage damage: ";
            // 
            // mostConsumed
            // 
            this.mostConsumed.AutoSize = true;
            this.mostConsumed.Location = new System.Drawing.Point(18, 214);
            this.mostConsumed.Name = "mostConsumed";
            this.mostConsumed.Size = new System.Drawing.Size(152, 20);
            this.mostConsumed.TabIndex = 8;
            this.mostConsumed.Text = "Most consumed boat:";
            // 
            // leastUsedButton
            // 
            this.leastUsedButton.Location = new System.Drawing.Point(18, 329);
            this.leastUsedButton.Name = "leastUsedButton";
            this.leastUsedButton.Size = new System.Drawing.Size(94, 29);
            this.leastUsedButton.TabIndex = 7;
            this.leastUsedButton.Text = "least used boat";
            this.leastUsedButton.UseVisualStyleBackColor = true;
            this.leastUsedButton.Click += new System.EventHandler(this.leastUsedButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Location = new System.Drawing.Point(17, 253);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(204, 29);
            this.damageButton.TabIndex = 6;
            this.damageButton.Text = "percentage damage";
            this.damageButton.UseVisualStyleBackColor = true;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // mostConsumedButton
            // 
            this.mostConsumedButton.Location = new System.Drawing.Point(18, 182);
            this.mostConsumedButton.Name = "mostConsumedButton";
            this.mostConsumedButton.Size = new System.Drawing.Size(199, 29);
            this.mostConsumedButton.TabIndex = 5;
            this.mostConsumedButton.Text = "most consumed";
            this.mostConsumedButton.UseVisualStyleBackColor = true;
            this.mostConsumedButton.Click += new System.EventHandler(this.mostConsumedButton_Click);
            // 
            // totalRentTime
            // 
            this.totalRentTime.AutoSize = true;
            this.totalRentTime.Location = new System.Drawing.Point(17, 159);
            this.totalRentTime.Name = "totalRentTime";
            this.totalRentTime.Size = new System.Drawing.Size(113, 20);
            this.totalRentTime.TabIndex = 4;
            this.totalRentTime.Text = "Total rent time: ";
            // 
            // totalRentTimeButton
            // 
            this.totalRentTimeButton.Location = new System.Drawing.Point(18, 116);
            this.totalRentTimeButton.Name = "totalRentTimeButton";
            this.totalRentTimeButton.Size = new System.Drawing.Size(130, 29);
            this.totalRentTimeButton.TabIndex = 3;
            this.totalRentTimeButton.Text = "Total rent time";
            this.totalRentTimeButton.UseVisualStyleBackColor = true;
            this.totalRentTimeButton.Click += new System.EventHandler(this.totalRentTimeButton_Click);
            // 
            // totalRevenue
            // 
            this.totalRevenue.AutoSize = true;
            this.totalRevenue.Location = new System.Drawing.Point(18, 82);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.Size = new System.Drawing.Size(105, 20);
            this.totalRevenue.TabIndex = 2;
            this.totalRevenue.Text = "Total revenue: ";
            // 
            // totalRevenueButton
            // 
            this.totalRevenueButton.Location = new System.Drawing.Point(18, 50);
            this.totalRevenueButton.Name = "totalRevenueButton";
            this.totalRevenueButton.Size = new System.Drawing.Size(178, 29);
            this.totalRevenueButton.TabIndex = 1;
            this.totalRevenueButton.Text = "Total revenue";
            this.totalRevenueButton.UseVisualStyleBackColor = true;
            this.totalRevenueButton.Click += new System.EventHandler(this.totalRevenueButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Overview";
            // 
            // rentTab
            // 
            this.rentTab.Controls.Add(this.label6);
            this.rentTab.Controls.Add(this.label5);
            this.rentTab.Controls.Add(this.label4);
            this.rentTab.Controls.Add(this.label3);
            this.rentTab.Controls.Add(this.label2);
            this.rentTab.Controls.Add(this.addRentButton);
            this.rentTab.Controls.Add(this.damageInput);
            this.rentTab.Controls.Add(this.usedFuelInput);
            this.rentTab.Controls.Add(this.boatInput);
            this.rentTab.Controls.Add(this.startInput);
            this.rentTab.Controls.Add(this.endInput);
            this.rentTab.Controls.Add(this.label1);
            this.rentTab.Location = new System.Drawing.Point(4, 29);
            this.rentTab.Name = "rentTab";
            this.rentTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentTab.Size = new System.Drawing.Size(792, 406);
            this.rentTab.TabIndex = 1;
            this.rentTab.Text = "Rent";
            this.rentTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Took damage?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "used fuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Boat: ";
            // 
            // addRentButton
            // 
            this.addRentButton.Location = new System.Drawing.Point(31, 386);
            this.addRentButton.Name = "addRentButton";
            this.addRentButton.Size = new System.Drawing.Size(150, 29);
            this.addRentButton.TabIndex = 6;
            this.addRentButton.Text = "Add rent";
            this.addRentButton.UseVisualStyleBackColor = true;
            this.addRentButton.Click += new System.EventHandler(this.addRentButton_Click);
            // 
            // damageInput
            // 
            this.damageInput.FormattingEnabled = true;
            this.damageInput.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.damageInput.Location = new System.Drawing.Point(30, 332);
            this.damageInput.Name = "damageInput";
            this.damageInput.Size = new System.Drawing.Size(151, 28);
            this.damageInput.TabIndex = 5;
            // 
            // usedFuelInput
            // 
            this.usedFuelInput.Location = new System.Drawing.Point(30, 274);
            this.usedFuelInput.Name = "usedFuelInput";
            this.usedFuelInput.Size = new System.Drawing.Size(125, 27);
            this.usedFuelInput.TabIndex = 4;
            // 
            // boatInput
            // 
            this.boatInput.FormattingEnabled = true;
            this.boatInput.Location = new System.Drawing.Point(30, 85);
            this.boatInput.Name = "boatInput";
            this.boatInput.Size = new System.Drawing.Size(151, 28);
            this.boatInput.TabIndex = 3;
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(30, 148);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(125, 27);
            this.startInput.TabIndex = 2;
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(30, 220);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(125, 27);
            this.endInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent a boat";
            // 
            // boatTab
            // 
            this.boatTab.Controls.Add(this.boats);
            this.boatTab.Controls.Add(this.totalBoats);
            this.boatTab.Location = new System.Drawing.Point(4, 29);
            this.boatTab.Name = "boatTab";
            this.boatTab.Size = new System.Drawing.Size(792, 406);
            this.boatTab.TabIndex = 2;
            this.boatTab.Text = "Boats";
            this.boatTab.UseVisualStyleBackColor = true;
            // 
            // boats
            // 
            this.boats.AutoSize = true;
            this.boats.Location = new System.Drawing.Point(20, 54);
            this.boats.Name = "boats";
            this.boats.Size = new System.Drawing.Size(0, 20);
            this.boats.TabIndex = 1;
            // 
            // totalBoats
            // 
            this.totalBoats.AutoSize = true;
            this.totalBoats.Location = new System.Drawing.Point(23, 14);
            this.totalBoats.Name = "totalBoats";
            this.totalBoats.Size = new System.Drawing.Size(90, 20);
            this.totalBoats.TabIndex = 0;
            this.totalBoats.Text = "Total boats: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.overviewToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.boatToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 148);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.overviewToolStripMenuItem.Text = "overview";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.rentToolStripMenuItem.Text = "rent";
            this.rentToolStripMenuItem.Click += new System.EventHandler(this.rentToolStripMenuItem_Click);
            // 
            // boatToolStripMenuItem
            // 
            this.boatToolStripMenuItem.Name = "boatToolStripMenuItem";
            this.boatToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.boatToolStripMenuItem.Text = "boat";
            this.boatToolStripMenuItem.Click += new System.EventHandler(this.boatToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.overviewTab.ResumeLayout(false);
            this.overviewTab.PerformLayout();
            this.rentTab.ResumeLayout(false);
            this.rentTab.PerformLayout();
            this.boatTab.ResumeLayout(false);
            this.boatTab.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage overviewTab;
        private TabPage rentTab;
        private TabPage boatTab;
        private Button addRentButton;
        private ComboBox damageInput;
        private TextBox usedFuelInput;
        private ComboBox boatInput;
        private TextBox startInput;
        private TextBox endInput;
        private Label label1;
        private Label boats;
        private Label totalBoats;
        private Label totalRevenue;
        private Button totalRevenueButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button totalRentTimeButton;
        private Label leastUsed;
        private Label totalDamageLabel;
        private Label mostConsumed;
        private Button leastUsedButton;
        private Button damageButton;
        private Button mostConsumedButton;
        private Label totalRentTime;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem overviewToolStripMenuItem;
        private ToolStripMenuItem rentToolStripMenuItem;
        private ToolStripMenuItem boatToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}