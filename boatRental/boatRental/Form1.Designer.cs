
namespace csharp_1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.overview_tab = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.Label();
            this.leastUsedBoat = new System.Windows.Forms.Button();
            this.percentageDamage = new System.Windows.Forms.Button();
            this.mostConsumed = new System.Windows.Forms.Button();
            this.totalRentTime = new System.Windows.Forms.Button();
            this.totalRevenue = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rent_tab = new System.Windows.Forms.TabPage();
            this.saveRent = new System.Windows.Forms.Button();
            this.usedFuelInput = new System.Windows.Forms.TextBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.startInput = new System.Windows.Forms.TextBox();
            this.damageInput = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boatInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boat_tab = new System.Windows.Forms.TabPage();
            this.totalBoatLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boatsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.overview_tab.SuspendLayout();
            this.rent_tab.SuspendLayout();
            this.boat_tab.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.overview_tab);
            this.tabControl1.Controls.Add(this.rent_tab);
            this.tabControl1.Controls.Add(this.boat_tab);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // overview_tab
            // 
            this.overview_tab.Controls.Add(this.result);
            this.overview_tab.Controls.Add(this.leastUsedBoat);
            this.overview_tab.Controls.Add(this.percentageDamage);
            this.overview_tab.Controls.Add(this.mostConsumed);
            this.overview_tab.Controls.Add(this.totalRentTime);
            this.overview_tab.Controls.Add(this.totalRevenue);
            this.overview_tab.Controls.Add(this.label9);
            this.overview_tab.Location = new System.Drawing.Point(4, 25);
            this.overview_tab.Name = "overview_tab";
            this.overview_tab.Padding = new System.Windows.Forms.Padding(3);
            this.overview_tab.Size = new System.Drawing.Size(798, 421);
            this.overview_tab.TabIndex = 0;
            this.overview_tab.Text = "Overview";
            this.overview_tab.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(16, 47);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 6;
            // 
            // leastUsedBoat
            // 
            this.leastUsedBoat.Location = new System.Drawing.Point(16, 236);
            this.leastUsedBoat.Name = "leastUsedBoat";
            this.leastUsedBoat.Size = new System.Drawing.Size(129, 23);
            this.leastUsedBoat.TabIndex = 5;
            this.leastUsedBoat.Text = "least used boat";
            this.leastUsedBoat.UseVisualStyleBackColor = true;
            this.leastUsedBoat.Click += new System.EventHandler(this.leastUsedBoat_Click);
            // 
            // percentageDamage
            // 
            this.percentageDamage.Location = new System.Drawing.Point(16, 194);
            this.percentageDamage.Name = "percentageDamage";
            this.percentageDamage.Size = new System.Drawing.Size(158, 23);
            this.percentageDamage.TabIndex = 4;
            this.percentageDamage.Text = "percentage damage";
            this.percentageDamage.UseVisualStyleBackColor = true;
            this.percentageDamage.Click += new System.EventHandler(this.percentageDamage_Click);
            // 
            // mostConsumed
            // 
            this.mostConsumed.Location = new System.Drawing.Point(16, 155);
            this.mostConsumed.Name = "mostConsumed";
            this.mostConsumed.Size = new System.Drawing.Size(129, 23);
            this.mostConsumed.TabIndex = 3;
            this.mostConsumed.Text = "most consumed";
            this.mostConsumed.UseVisualStyleBackColor = true;
            this.mostConsumed.Click += new System.EventHandler(this.mostConsumed_Click);
            // 
            // totalRentTime
            // 
            this.totalRentTime.Location = new System.Drawing.Point(16, 114);
            this.totalRentTime.Name = "totalRentTime";
            this.totalRentTime.Size = new System.Drawing.Size(113, 23);
            this.totalRentTime.TabIndex = 2;
            this.totalRentTime.Text = "total rent time";
            this.totalRentTime.UseVisualStyleBackColor = true;
            this.totalRentTime.Click += new System.EventHandler(this.totalRentTime_Click);
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(16, 75);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.Size = new System.Drawing.Size(113, 23);
            this.totalRevenue.TabIndex = 1;
            this.totalRevenue.Text = "Total revenue";
            this.totalRevenue.UseVisualStyleBackColor = true;
            this.totalRevenue.Click += new System.EventHandler(this.totalRevenue_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Overview";
            // 
            // rent_tab
            // 
            this.rent_tab.Controls.Add(this.saveRent);
            this.rent_tab.Controls.Add(this.usedFuelInput);
            this.rent_tab.Controls.Add(this.endInput);
            this.rent_tab.Controls.Add(this.startInput);
            this.rent_tab.Controls.Add(this.damageInput);
            this.rent_tab.Controls.Add(this.label8);
            this.rent_tab.Controls.Add(this.label7);
            this.rent_tab.Controls.Add(this.label6);
            this.rent_tab.Controls.Add(this.label5);
            this.rent_tab.Controls.Add(this.label4);
            this.rent_tab.Controls.Add(this.boatInput);
            this.rent_tab.Controls.Add(this.label2);
            this.rent_tab.Location = new System.Drawing.Point(4, 25);
            this.rent_tab.Name = "rent_tab";
            this.rent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.rent_tab.Size = new System.Drawing.Size(798, 421);
            this.rent_tab.TabIndex = 1;
            this.rent_tab.Text = "Rent";
            this.rent_tab.UseVisualStyleBackColor = true;
            // 
            // saveRent
            // 
            this.saveRent.Location = new System.Drawing.Point(19, 301);
            this.saveRent.Name = "saveRent";
            this.saveRent.Size = new System.Drawing.Size(75, 23);
            this.saveRent.TabIndex = 11;
            this.saveRent.Text = "save";
            this.saveRent.UseVisualStyleBackColor = true;
            this.saveRent.Click += new System.EventHandler(this.saveRent_Click);
            // 
            // usedFuelInput
            // 
            this.usedFuelInput.Location = new System.Drawing.Point(99, 197);
            this.usedFuelInput.Name = "usedFuelInput";
            this.usedFuelInput.Size = new System.Drawing.Size(100, 22);
            this.usedFuelInput.TabIndex = 10;
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(86, 144);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(100, 22);
            this.endInput.TabIndex = 9;
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(63, 104);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(100, 22);
            this.startInput.TabIndex = 8;
            // 
            // damageInput
            // 
            this.damageInput.FormattingEnabled = true;
            this.damageInput.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.damageInput.Location = new System.Drawing.Point(130, 253);
            this.damageInput.Name = "damageInput";
            this.damageInput.Size = new System.Drawing.Size(121, 24);
            this.damageInput.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Took damage: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Used fuel: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "End: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Boat: ";
            // 
            // boatInput
            // 
            this.boatInput.FormattingEnabled = true;
            this.boatInput.Location = new System.Drawing.Point(63, 54);
            this.boatInput.Name = "boatInput";
            this.boatInput.Size = new System.Drawing.Size(121, 24);
            this.boatInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rent a boat";
            // 
            // boat_tab
            // 
            this.boat_tab.Controls.Add(this.totalBoatLabel);
            this.boat_tab.Controls.Add(this.label3);
            this.boat_tab.Controls.Add(this.boatsLabel);
            this.boat_tab.Location = new System.Drawing.Point(4, 25);
            this.boat_tab.Name = "boat_tab";
            this.boat_tab.Padding = new System.Windows.Forms.Padding(3);
            this.boat_tab.Size = new System.Drawing.Size(798, 421);
            this.boat_tab.TabIndex = 2;
            this.boat_tab.Text = "Boat";
            this.boat_tab.UseVisualStyleBackColor = true;
            // 
            // totalBoatLabel
            // 
            this.totalBoatLabel.AutoSize = true;
            this.totalBoatLabel.Location = new System.Drawing.Point(146, 13);
            this.totalBoatLabel.Name = "totalBoatLabel";
            this.totalBoatLabel.Size = new System.Drawing.Size(0, 16);
            this.totalBoatLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total boats:";
            // 
            // boatsLabel
            // 
            this.boatsLabel.AutoSize = true;
            this.boatsLabel.Location = new System.Drawing.Point(17, 52);
            this.boatsLabel.Name = "boatsLabel";
            this.boatsLabel.Size = new System.Drawing.Size(0, 16);
            this.boatsLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.rentsToolStripMenuItem,
            this.rentsToolStripMenuItem1,
            this.boatsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(138, 148);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.aboutToolStripMenuItem1.Text = "about";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // rentsToolStripMenuItem
            // 
            this.rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            this.rentsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.rentsToolStripMenuItem.Text = "overview";
            this.rentsToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // rentsToolStripMenuItem1
            // 
            this.rentsToolStripMenuItem1.Name = "rentsToolStripMenuItem1";
            this.rentsToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.rentsToolStripMenuItem1.Text = "rents";
            this.rentsToolStripMenuItem1.Click += new System.EventHandler(this.rentsToolStripMenuItem1_Click);
            // 
            // boatsToolStripMenuItem
            // 
            this.boatsToolStripMenuItem.Name = "boatsToolStripMenuItem";
            this.boatsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.boatsToolStripMenuItem.Text = "boats";
            this.boatsToolStripMenuItem.Click += new System.EventHandler(this.boatsToolStripMenuItem_Click);
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
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.overview_tab.ResumeLayout(false);
            this.overview_tab.PerformLayout();
            this.rent_tab.ResumeLayout(false);
            this.rent_tab.PerformLayout();
            this.boat_tab.ResumeLayout(false);
            this.boat_tab.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage rent_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage boat_tab;
        private System.Windows.Forms.TabPage overview_tab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label boatsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalBoatLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boatInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usedFuelInput;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.ComboBox damageInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveRent;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button leastUsedBoat;
        private System.Windows.Forms.Button percentageDamage;
        private System.Windows.Forms.Button mostConsumed;
        private System.Windows.Forms.Button totalRentTime;
        private System.Windows.Forms.Button totalRevenue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}

