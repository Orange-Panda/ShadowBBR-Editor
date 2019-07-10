namespace ShadowBBR_Editor
{
	partial class Editor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.toolbar = new System.Windows.Forms.Panel();
			this.toolbarExit = new System.Windows.Forms.Label();
			this.toolbarLabel = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.Panel();
			this.timeline = new System.Windows.Forms.Panel();
			this.titleBox = new System.Windows.Forms.TextBox();
			this.bpmBox = new System.Windows.Forms.TextBox();
			this.artistBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.toolbar.SuspendLayout();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// toolbar
			// 
			this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.toolbar.Controls.Add(this.pictureBox4);
			this.toolbar.Controls.Add(this.toolbarExit);
			this.toolbar.Controls.Add(this.toolbarLabel);
			this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(1600, 36);
			this.toolbar.TabIndex = 1;
			this.toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseDown);
			this.toolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseMove);
			this.toolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseUp);
			// 
			// toolbarExit
			// 
			this.toolbarExit.AutoSize = true;
			this.toolbarExit.BackColor = System.Drawing.Color.Transparent;
			this.toolbarExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolbarExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.toolbarExit.Location = new System.Drawing.Point(1570, 5);
			this.toolbarExit.Name = "toolbarExit";
			this.toolbarExit.Size = new System.Drawing.Size(27, 25);
			this.toolbarExit.TabIndex = 1;
			this.toolbarExit.Text = "X";
			this.toolbarExit.Click += new System.EventHandler(this.ToolbarExit_Click);
			// 
			// toolbarLabel
			// 
			this.toolbarLabel.AutoSize = true;
			this.toolbarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.toolbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolbarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.toolbarLabel.Location = new System.Drawing.Point(37, 7);
			this.toolbarLabel.Name = "toolbarLabel";
			this.toolbarLabel.Size = new System.Drawing.Size(351, 22);
			this.toolbarLabel.TabIndex = 0;
			this.toolbarLabel.Text = "Shadow Beat Boxing - Beatmap Editor";
			this.toolbarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolbarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseDown);
			this.toolbarLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseMove);
			this.toolbarLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseUp);
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.menu.Controls.Add(this.label2);
			this.menu.Controls.Add(this.label1);
			this.menu.Controls.Add(this.pictureBox3);
			this.menu.Controls.Add(this.pictureBox2);
			this.menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.menu.Location = new System.Drawing.Point(0, 36);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(96, 864);
			this.menu.TabIndex = 0;
			// 
			// timeline
			// 
			this.timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
			this.timeline.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.timeline.Location = new System.Drawing.Point(96, 388);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(1504, 512);
			this.timeline.TabIndex = 5;
			// 
			// titleBox
			// 
			this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleBox.Location = new System.Drawing.Point(412, 118);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(332, 35);
			this.titleBox.TabIndex = 0;
			// 
			// bpmBox
			// 
			this.bpmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bpmBox.Location = new System.Drawing.Point(412, 298);
			this.bpmBox.Name = "bpmBox";
			this.bpmBox.Size = new System.Drawing.Size(97, 35);
			this.bpmBox.TabIndex = 2;
			// 
			// artistBox
			// 
			this.artistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.artistBox.Location = new System.Drawing.Point(412, 208);
			this.artistBox.Name = "artistBox";
			this.artistBox.Size = new System.Drawing.Size(332, 35);
			this.artistBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Silver;
			this.label3.Location = new System.Drawing.Point(406, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 32);
			this.label3.TabIndex = 11;
			this.label3.Text = "Song Title";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Silver;
			this.label4.Location = new System.Drawing.Point(406, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 32);
			this.label4.TabIndex = 12;
			this.label4.Text = "Artist Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Silver;
			this.label5.Location = new System.Drawing.Point(406, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "BPM";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(132, 80);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(10, 21);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(72, 72);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(10, 139);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(72, 72);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(9, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "IMPORT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.label2.Location = new System.Drawing.Point(8, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "EXPORT";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(6, 2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			// 
			// Editor
			// 
			this.AccessibleDescription = "Shadow Beat Boxing Beatmap Editor";
			this.AccessibleName = "Shadow BBR Editor";
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.artistBox);
			this.Controls.Add(this.bpmBox);
			this.Controls.Add(this.titleBox);
			this.Controls.Add(this.timeline);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.toolbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shadow Beat Boxing - Beatmap Editor";
			this.Load += new System.EventHandler(this.Editor_Load);
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel toolbar;
		private System.Windows.Forms.Panel menu;
		private System.Windows.Forms.Panel timeline;
		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.TextBox bpmBox;
		private System.Windows.Forms.Label toolbarLabel;
		private System.Windows.Forms.Label toolbarExit;
		private System.Windows.Forms.TextBox artistBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}

