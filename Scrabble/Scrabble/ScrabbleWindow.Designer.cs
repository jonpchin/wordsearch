namespace Scrabble
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.letter1 = new System.Windows.Forms.Button();
            this.letter2 = new System.Windows.Forms.Button();
            this.letter3 = new System.Windows.Forms.Button();
            this.letter4 = new System.Windows.Forms.Button();
            this.letter5 = new System.Windows.Forms.Button();
            this.letter6 = new System.Windows.Forms.Button();
            this.letter7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.board.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // board
            // 
            this.board.AllowDrop = true;
            this.board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.board.ColumnCount = 15;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666665F));
            this.board.Controls.Add(this.label60, 11, 14);
            this.board.Controls.Add(this.label59, 3, 14);
            this.board.Controls.Add(this.label58, 14, 14);
            this.board.Controls.Add(this.label57, 0, 14);
            this.board.Controls.Add(this.label56, 7, 14);
            this.board.Controls.Add(this.label55, 9, 13);
            this.board.Controls.Add(this.label54, 5, 13);
            this.board.Controls.Add(this.label53, 8, 12);
            this.board.Controls.Add(this.label52, 6, 12);
            this.board.Controls.Add(this.label51, 10, 10);
            this.board.Controls.Add(this.label50, 11, 11);
            this.board.Controls.Add(this.label49, 12, 12);
            this.board.Controls.Add(this.label48, 13, 13);
            this.board.Controls.Add(this.label47, 4, 10);
            this.board.Controls.Add(this.label46, 3, 11);
            this.board.Controls.Add(this.label45, 2, 12);
            this.board.Controls.Add(this.label44, 14, 11);
            this.board.Controls.Add(this.label43, 7, 11);
            this.board.Controls.Add(this.label42, 11, 7);
            this.board.Controls.Add(this.label41, 3, 7);
            this.board.Controls.Add(this.label40, 2, 8);
            this.board.Controls.Add(this.label39, 12, 8);
            this.board.Controls.Add(this.label38, 12, 6);
            this.board.Controls.Add(this.label37, 2, 6);
            this.board.Controls.Add(this.label36, 14, 7);
            this.board.Controls.Add(this.label35, 0, 7);
            this.board.Controls.Add(this.label34, 13, 9);
            this.board.Controls.Add(this.label33, 1, 9);
            this.board.Controls.Add(this.label32, 13, 5);
            this.board.Controls.Add(this.label31, 1, 5);
            this.board.Controls.Add(this.label30, 14, 3);
            this.board.Controls.Add(this.label29, 0, 11);
            this.board.Controls.Add(this.label28, 0, 3);
            this.board.Controls.Add(this.label27, 10, 4);
            this.board.Controls.Add(this.label26, 11, 3);
            this.board.Controls.Add(this.label25, 12, 2);
            this.board.Controls.Add(this.label24, 1, 13);
            this.board.Controls.Add(this.label23, 9, 9);
            this.board.Controls.Add(this.label22, 9, 5);
            this.board.Controls.Add(this.label21, 5, 9);
            this.board.Controls.Add(this.label20, 8, 8);
            this.board.Controls.Add(this.label19, 6, 8);
            this.board.Controls.Add(this.label18, 8, 6);
            this.board.Controls.Add(this.label17, 6, 6);
            this.board.Controls.Add(this.label16, 5, 5);
            this.board.Controls.Add(this.label1, 0, 0);
            this.board.Controls.Add(this.label2, 3, 0);
            this.board.Controls.Add(this.label3, 7, 0);
            this.board.Controls.Add(this.label4, 11, 0);
            this.board.Controls.Add(this.label5, 14, 0);
            this.board.Controls.Add(this.label6, 1, 1);
            this.board.Controls.Add(this.label7, 2, 2);
            this.board.Controls.Add(this.label8, 3, 3);
            this.board.Controls.Add(this.label9, 4, 4);
            this.board.Controls.Add(this.label10, 5, 1);
            this.board.Controls.Add(this.label11, 9, 1);
            this.board.Controls.Add(this.label12, 13, 1);
            this.board.Controls.Add(this.label13, 6, 2);
            this.board.Controls.Add(this.label14, 7, 3);
            this.board.Controls.Add(this.label15, 8, 2);
            this.board.Controls.Add(this.label61, 7, 7);
            this.board.Location = new System.Drawing.Point(240, 45);
            this.board.Name = "board";
            this.board.RowCount = 15;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.board.Size = new System.Drawing.Size(800, 800);
            this.board.TabIndex = 1;
            // 
            // letter1
            // 
            this.letter1.Location = new System.Drawing.Point(240, 871);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(50, 50);
            this.letter1.TabIndex = 2;
            this.letter1.UseVisualStyleBackColor = true;
            // 
            // letter2
            // 
            this.letter2.Location = new System.Drawing.Point(375, 871);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(50, 50);
            this.letter2.TabIndex = 3;
            this.letter2.UseVisualStyleBackColor = true;
            // 
            // letter3
            // 
            this.letter3.Location = new System.Drawing.Point(495, 871);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(50, 50);
            this.letter3.TabIndex = 4;
            this.letter3.UseVisualStyleBackColor = true;
            // 
            // letter4
            // 
            this.letter4.Location = new System.Drawing.Point(615, 871);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(50, 50);
            this.letter4.TabIndex = 5;
            this.letter4.UseVisualStyleBackColor = true;
            // 
            // letter5
            // 
            this.letter5.Location = new System.Drawing.Point(735, 871);
            this.letter5.Name = "letter5";
            this.letter5.Size = new System.Drawing.Size(50, 50);
            this.letter5.TabIndex = 6;
            this.letter5.UseVisualStyleBackColor = true;
            // 
            // letter6
            // 
            this.letter6.Location = new System.Drawing.Point(855, 871);
            this.letter6.Name = "letter6";
            this.letter6.Size = new System.Drawing.Size(50, 50);
            this.letter6.TabIndex = 7;
            this.letter6.UseVisualStyleBackColor = true;
            // 
            // letter7
            // 
            this.letter7.Location = new System.Drawing.Point(990, 871);
            this.letter7.Name = "letter7";
            this.letter7.Size = new System.Drawing.Size(50, 50);
            this.letter7.TabIndex = 8;
            this.letter7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Triple Word Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(375, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Triple Word Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(587, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "Double Letter Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(746, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "Triple Word Score";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(57, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 52);
            this.label6.TabIndex = 5;
            this.label6.Text = "Double Word Score";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(110, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 52);
            this.label7.TabIndex = 6;
            this.label7.Text = "Double Word Score";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(163, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 52);
            this.label8.TabIndex = 7;
            this.label8.Text = "Double Word Score";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(216, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 52);
            this.label9.TabIndex = 8;
            this.label9.Text = "Double Word Score";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(269, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 52);
            this.label10.TabIndex = 9;
            this.label10.Text = "Triple Letter Score";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Green;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(481, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 52);
            this.label11.TabIndex = 10;
            this.label11.Text = "Triple Letter Score";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(693, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 52);
            this.label12.TabIndex = 11;
            this.label12.Text = "Double Word Score";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DodgerBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(322, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 52);
            this.label13.TabIndex = 12;
            this.label13.Text = "Double Letter Score";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DodgerBlue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(375, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 52);
            this.label14.TabIndex = 13;
            this.label14.Text = "Double Letter Score";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DodgerBlue;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(428, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 52);
            this.label15.TabIndex = 14;
            this.label15.Text = "Double Letter Score";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Green;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(269, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 52);
            this.label16.TabIndex = 15;
            this.label16.Text = "Triple Letter Score";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DodgerBlue;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(322, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 52);
            this.label17.TabIndex = 16;
            this.label17.Text = "Double Letter Score";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DodgerBlue;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(428, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 52);
            this.label18.TabIndex = 17;
            this.label18.Text = "Double Letter Score";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DodgerBlue;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(322, 425);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 52);
            this.label19.TabIndex = 18;
            this.label19.Text = "Double Letter Score";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DodgerBlue;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(428, 425);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 52);
            this.label20.TabIndex = 19;
            this.label20.Text = "Double Letter Score";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Green;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Location = new System.Drawing.Point(269, 478);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 52);
            this.label21.TabIndex = 20;
            this.label21.Text = "Triple Letter Score";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Green;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(481, 266);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 52);
            this.label22.TabIndex = 21;
            this.label22.Text = "Triple Letter Score";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Green;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label23.Location = new System.Drawing.Point(481, 478);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 52);
            this.label23.TabIndex = 22;
            this.label23.Text = "Triple Letter Score";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Red;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label24.Location = new System.Drawing.Point(57, 690);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 52);
            this.label24.TabIndex = 23;
            this.label24.Text = "Double Word Score";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Red;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Location = new System.Drawing.Point(640, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 52);
            this.label25.TabIndex = 24;
            this.label25.Text = "Double Word Score";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Red;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(587, 160);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 52);
            this.label26.TabIndex = 25;
            this.label26.Text = "Double Word Score";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Red;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label27.Location = new System.Drawing.Point(534, 213);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 52);
            this.label27.TabIndex = 26;
            this.label27.Text = "Double Word Score";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.DodgerBlue;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label29.Location = new System.Drawing.Point(4, 584);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 52);
            this.label29.TabIndex = 28;
            this.label29.Text = "Double Letter Score";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.DodgerBlue;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label28.Location = new System.Drawing.Point(4, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 52);
            this.label28.TabIndex = 27;
            this.label28.Text = "Double Letter Score";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(163, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Double Letter Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.DodgerBlue;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label30.Location = new System.Drawing.Point(746, 160);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 52);
            this.label30.TabIndex = 29;
            this.label30.Text = "Double Letter Score";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Green;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label31.Location = new System.Drawing.Point(57, 266);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 52);
            this.label31.TabIndex = 30;
            this.label31.Text = "Triple Letter Score";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Green;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label32.Location = new System.Drawing.Point(693, 266);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 52);
            this.label32.TabIndex = 31;
            this.label32.Text = "Triple Letter Score";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Green;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label33.Location = new System.Drawing.Point(57, 478);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 52);
            this.label33.TabIndex = 32;
            this.label33.Text = "Triple Letter Score";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Green;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label34.Location = new System.Drawing.Point(693, 478);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 52);
            this.label34.TabIndex = 33;
            this.label34.Text = "Triple Letter Score";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label35.Location = new System.Drawing.Point(4, 372);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 52);
            this.label35.TabIndex = 34;
            this.label35.Text = "Triple Word Score";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label36.Location = new System.Drawing.Point(746, 372);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 52);
            this.label36.TabIndex = 35;
            this.label36.Text = "Triple Word Score";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.DodgerBlue;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label37.Location = new System.Drawing.Point(110, 319);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 52);
            this.label37.TabIndex = 36;
            this.label37.Text = "Double Letter Score";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.DodgerBlue;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label38.Location = new System.Drawing.Point(640, 319);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 52);
            this.label38.TabIndex = 37;
            this.label38.Text = "Double Letter Score";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.DodgerBlue;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label39.Location = new System.Drawing.Point(640, 425);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 52);
            this.label39.TabIndex = 38;
            this.label39.Text = "Double Letter Score";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.DodgerBlue;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label40.Location = new System.Drawing.Point(110, 425);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 52);
            this.label40.TabIndex = 39;
            this.label40.Text = "Double Letter Score";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.DodgerBlue;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label41.Location = new System.Drawing.Point(163, 372);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(46, 52);
            this.label41.TabIndex = 40;
            this.label41.Text = "Double Letter Score";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.DodgerBlue;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label42.Location = new System.Drawing.Point(587, 372);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(46, 52);
            this.label42.TabIndex = 41;
            this.label42.Text = "Double Letter Score";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.DodgerBlue;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label43.Location = new System.Drawing.Point(375, 584);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(46, 52);
            this.label43.TabIndex = 42;
            this.label43.Text = "Double Letter Score";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.DodgerBlue;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label44.Location = new System.Drawing.Point(746, 584);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 52);
            this.label44.TabIndex = 43;
            this.label44.Text = "Double Letter Score";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Red;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label45.Location = new System.Drawing.Point(110, 637);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(46, 52);
            this.label45.TabIndex = 44;
            this.label45.Text = "Double Word Score";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Red;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label46.Location = new System.Drawing.Point(163, 584);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(46, 52);
            this.label46.TabIndex = 45;
            this.label46.Text = "Double Word Score";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Red;
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label47.Location = new System.Drawing.Point(216, 531);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(46, 52);
            this.label47.TabIndex = 46;
            this.label47.Text = "Double Word Score";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Red;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label48.Location = new System.Drawing.Point(693, 690);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(46, 52);
            this.label48.TabIndex = 47;
            this.label48.Text = "Double Word Score";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Red;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label49.Location = new System.Drawing.Point(640, 637);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(46, 52);
            this.label49.TabIndex = 48;
            this.label49.Text = "Double Word Score";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Red;
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label50.Location = new System.Drawing.Point(587, 584);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(46, 52);
            this.label50.TabIndex = 49;
            this.label50.Text = "Double Word Score";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Red;
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label51.Location = new System.Drawing.Point(534, 531);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(46, 52);
            this.label51.TabIndex = 50;
            this.label51.Text = "Double Word Score";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.DodgerBlue;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label52.Location = new System.Drawing.Point(322, 637);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(46, 52);
            this.label52.TabIndex = 51;
            this.label52.Text = "Double Letter Score";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.DodgerBlue;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label53.Location = new System.Drawing.Point(428, 637);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(46, 52);
            this.label53.TabIndex = 52;
            this.label53.Text = "Double Letter Score";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Green;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label54.Location = new System.Drawing.Point(269, 690);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(46, 52);
            this.label54.TabIndex = 53;
            this.label54.Text = "Triple Letter Score";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Green;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label55.Location = new System.Drawing.Point(481, 690);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(46, 52);
            this.label55.TabIndex = 54;
            this.label55.Text = "Triple Letter Score";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label56.Location = new System.Drawing.Point(375, 743);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(46, 56);
            this.label56.TabIndex = 55;
            this.label56.Text = "Triple Word Score";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label57.Location = new System.Drawing.Point(4, 743);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(46, 56);
            this.label57.TabIndex = 56;
            this.label57.Text = "Triple Word Score";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label58.Location = new System.Drawing.Point(746, 743);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(50, 56);
            this.label58.TabIndex = 57;
            this.label58.Text = "Triple Word Score";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.DodgerBlue;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label59.Location = new System.Drawing.Point(163, 743);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(46, 56);
            this.label59.TabIndex = 58;
            this.label59.Text = "Double Letter Score";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.DodgerBlue;
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label60.Location = new System.Drawing.Point(587, 743);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(46, 56);
            this.label60.TabIndex = 59;
            this.label60.Text = "Double Letter Score";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Red;
            this.label61.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label61.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label61.Location = new System.Drawing.Point(375, 372);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(46, 52);
            this.label61.TabIndex = 60;
            this.label61.Text = "l";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.letter7);
            this.Controls.Add(this.letter6);
            this.Controls.Add(this.letter5);
            this.Controls.Add(this.letter4);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Scrabble";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Button letter1;
        private System.Windows.Forms.Button letter2;
        private System.Windows.Forms.Button letter3;
        private System.Windows.Forms.Button letter4;
        private System.Windows.Forms.Button letter5;
        private System.Windows.Forms.Button letter6;
        private System.Windows.Forms.Button letter7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
    }
}

