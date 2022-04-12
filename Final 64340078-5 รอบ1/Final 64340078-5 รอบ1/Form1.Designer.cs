namespace Final_64340078_5_รอบ1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.changeStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(417, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(589, 58);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(125, 27);
            this.moneyBox.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(589, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // changeStatus
            // 
            this.changeStatus.Location = new System.Drawing.Point(589, 175);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(125, 27);
            this.changeStatus.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "จ่ายเงิน";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(493, 120);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(49, 20);
            this.Status.TabIndex = 8;
            this.Status.Text = "Status";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(475, 182);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 20);
            this.label.TabIndex = 9;
            this.label.Text = "changeStatus";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "โหลด";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(133, 351);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(125, 27);
            this.totalBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "รวม";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "moneyBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox moneyBox;
        private TextBox textBox2;
        private TextBox changeStatus;
        private Button button1;
        private Button button2;
        private Label Status;
        private Label label;
        private Button button4;
        private TextBox totalBox;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Label label1;
    }
}