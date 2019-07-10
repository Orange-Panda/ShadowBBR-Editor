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
			this.toolbar = new System.Windows.Forms.Panel();
			this.menu = new System.Windows.Forms.Panel();
			this.timeline = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.toolbarLabel = new System.Windows.Forms.Label();
			this.toolbarExit = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolbar.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolbar
			// 
			this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.toolbar.Controls.Add(this.toolbarExit);
			this.toolbar.Controls.Add(this.toolbarLabel);
			this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(1600, 28);
			this.toolbar.TabIndex = 1;
			this.toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseDown);
			this.toolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseMove);
			this.toolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseUp);
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.menu.Controls.Add(this.label2);
			this.menu.Controls.Add(this.label1);
			this.menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.menu.Location = new System.Drawing.Point(0, 28);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(60, 872);
			this.menu.TabIndex = 0;
			// 
			// timeline
			// 
			this.timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
			this.timeline.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.timeline.Location = new System.Drawing.Point(60, 388);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(1540, 512);
			this.timeline.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(103, 94);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(332, 35);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "SongName";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(103, 146);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(332, 35);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "SongResourceName";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(103, 204);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(332, 35);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "BPM";
			// 
			// toolbarLabel
			// 
			this.toolbarLabel.AutoSize = true;
			this.toolbarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.toolbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolbarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.toolbarLabel.Location = new System.Drawing.Point(3, 5);
			this.toolbarLabel.Name = "toolbarLabel";
			this.toolbarLabel.Size = new System.Drawing.Size(316, 20);
			this.toolbarLabel.TabIndex = 0;
			this.toolbarLabel.Text = "Shadow Beat Boxing - Beatmap Editor";
			this.toolbarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseDown);
			this.toolbarLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseMove);
			this.toolbarLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Toolbar_MouseUp);
			// 
			// toolbarExit
			// 
			this.toolbarExit.AutoSize = true;
			this.toolbarExit.BackColor = System.Drawing.Color.Transparent;
			this.toolbarExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolbarExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.toolbarExit.Location = new System.Drawing.Point(1577, 5);
			this.toolbarExit.Name = "toolbarExit";
			this.toolbarExit.Size = new System.Drawing.Size(21, 20);
			this.toolbarExit.TabIndex = 1;
			this.toolbarExit.Text = "X";
			this.toolbarExit.Click += new System.EventHandler(this.ToolbarExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Import";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
			this.label2.Location = new System.Drawing.Point(2, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Export";
			// 
			// Editor
			// 
			this.AccessibleDescription = "Shadow Beat Boxing Beatmap Editor";
			this.AccessibleName = "Shadow BBR Editor";
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.timeline);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.toolbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel toolbar;
		private System.Windows.Forms.Panel menu;
		private System.Windows.Forms.Panel timeline;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label toolbarLabel;
		private System.Windows.Forms.Label toolbarExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

