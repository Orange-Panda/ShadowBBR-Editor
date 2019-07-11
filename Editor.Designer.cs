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
			this.toolbarLogo = new System.Windows.Forms.PictureBox();
			this.toolbarExit = new System.Windows.Forms.Label();
			this.toolbarLabel = new System.Windows.Forms.Label();
			this.exportLabel = new System.Windows.Forms.Label();
			this.importLabel = new System.Windows.Forms.Label();
			this.exportIcon = new System.Windows.Forms.PictureBox();
			this.importIcon = new System.Windows.Forms.PictureBox();
			this.timeline = new System.Windows.Forms.Panel();
			this.restartButton = new System.Windows.Forms.PictureBox();
			this.musicImportButton = new System.Windows.Forms.PictureBox();
			this.playButton = new System.Windows.Forms.PictureBox();
			this.titleBox = new System.Windows.Forms.TextBox();
			this.bpmBox = new System.Windows.Forms.TextBox();
			this.artistBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.artistLabel = new System.Windows.Forms.Label();
			this.bpmLabel = new System.Windows.Forms.Label();
			this.albumCover = new System.Windows.Forms.PictureBox();
			this.menu = new System.Windows.Forms.Panel();
			this.metadata = new System.Windows.Forms.Panel();
			this.metadataLabel = new System.Windows.Forms.Label();
			this.toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolbarLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exportIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.importIcon)).BeginInit();
			this.timeline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.restartButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musicImportButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumCover)).BeginInit();
			this.menu.SuspendLayout();
			this.metadata.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolbar
			// 
			this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
			this.toolbar.Controls.Add(this.toolbarLogo);
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
			// toolbarLogo
			// 
			this.toolbarLogo.Image = ((System.Drawing.Image)(resources.GetObject("toolbarLogo.Image")));
			this.toolbarLogo.Location = new System.Drawing.Point(8, 4);
			this.toolbarLogo.Name = "toolbarLogo";
			this.toolbarLogo.Size = new System.Drawing.Size(28, 28);
			this.toolbarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.toolbarLogo.TabIndex = 2;
			this.toolbarLogo.TabStop = false;
			// 
			// toolbarExit
			// 
			this.toolbarExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			// exportLabel
			// 
			this.exportLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.exportLabel.AutoSize = true;
			this.exportLabel.BackColor = System.Drawing.Color.Transparent;
			this.exportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exportLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.exportLabel.Location = new System.Drawing.Point(3, 264);
			this.exportLabel.Name = "exportLabel";
			this.exportLabel.Size = new System.Drawing.Size(104, 40);
			this.exportLabel.TabIndex = 17;
			this.exportLabel.Text = "SAVE AND \r\nEXPORT";
			this.exportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// importLabel
			// 
			this.importLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.importLabel.AutoSize = true;
			this.importLabel.BackColor = System.Drawing.Color.Transparent;
			this.importLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.importLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.importLabel.Location = new System.Drawing.Point(15, 128);
			this.importLabel.Name = "importLabel";
			this.importLabel.Size = new System.Drawing.Size(76, 20);
			this.importLabel.TabIndex = 16;
			this.importLabel.Text = "IMPORT";
			this.importLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// exportIcon
			// 
			this.exportIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.exportIcon.BackColor = System.Drawing.Color.Transparent;
			this.exportIcon.Image = ((System.Drawing.Image)(resources.GetObject("exportIcon.Image")));
			this.exportIcon.Location = new System.Drawing.Point(17, 186);
			this.exportIcon.MinimumSize = new System.Drawing.Size(72, 72);
			this.exportIcon.Name = "exportIcon";
			this.exportIcon.Size = new System.Drawing.Size(72, 72);
			this.exportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.exportIcon.TabIndex = 1;
			this.exportIcon.TabStop = false;
			// 
			// importIcon
			// 
			this.importIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.importIcon.BackColor = System.Drawing.Color.Transparent;
			this.importIcon.Image = ((System.Drawing.Image)(resources.GetObject("importIcon.Image")));
			this.importIcon.Location = new System.Drawing.Point(19, 48);
			this.importIcon.MinimumSize = new System.Drawing.Size(72, 72);
			this.importIcon.Name = "importIcon";
			this.importIcon.Size = new System.Drawing.Size(72, 72);
			this.importIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.importIcon.TabIndex = 0;
			this.importIcon.TabStop = false;
			// 
			// timeline
			// 
			this.timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
			this.timeline.Controls.Add(this.restartButton);
			this.timeline.Controls.Add(this.musicImportButton);
			this.timeline.Controls.Add(this.playButton);
			this.timeline.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.timeline.Location = new System.Drawing.Point(0, 388);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(1600, 512);
			this.timeline.TabIndex = 5;
			// 
			// restartButton
			// 
			this.restartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
			this.restartButton.Location = new System.Drawing.Point(890, 426);
			this.restartButton.Name = "restartButton";
			this.restartButton.Size = new System.Drawing.Size(64, 64);
			this.restartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.restartButton.TabIndex = 2;
			this.restartButton.TabStop = false;
			// 
			// musicImportButton
			// 
			this.musicImportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.musicImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.musicImportButton.Image = ((System.Drawing.Image)(resources.GetObject("musicImportButton.Image")));
			this.musicImportButton.Location = new System.Drawing.Point(690, 426);
			this.musicImportButton.Name = "musicImportButton";
			this.musicImportButton.Size = new System.Drawing.Size(64, 64);
			this.musicImportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.musicImportButton.TabIndex = 1;
			this.musicImportButton.TabStop = false;
			// 
			// playButton
			// 
			this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
			this.playButton.Location = new System.Drawing.Point(790, 426);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(64, 64);
			this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.playButton.TabIndex = 0;
			this.playButton.TabStop = false;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// titleBox
			// 
			this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleBox.Location = new System.Drawing.Point(338, 100);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(332, 35);
			this.titleBox.TabIndex = 0;
			// 
			// bpmBox
			// 
			this.bpmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bpmBox.Location = new System.Drawing.Point(338, 280);
			this.bpmBox.Name = "bpmBox";
			this.bpmBox.Size = new System.Drawing.Size(97, 35);
			this.bpmBox.TabIndex = 2;
			// 
			// artistBox
			// 
			this.artistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.artistBox.Location = new System.Drawing.Point(338, 190);
			this.artistBox.Name = "artistBox";
			this.artistBox.Size = new System.Drawing.Size(332, 35);
			this.artistBox.TabIndex = 1;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.Silver;
			this.titleLabel.Location = new System.Drawing.Point(332, 60);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(154, 32);
			this.titleLabel.TabIndex = 11;
			this.titleLabel.Text = "Song Title";
			// 
			// artistLabel
			// 
			this.artistLabel.AutoSize = true;
			this.artistLabel.BackColor = System.Drawing.Color.Transparent;
			this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.artistLabel.ForeColor = System.Drawing.Color.Silver;
			this.artistLabel.Location = new System.Drawing.Point(332, 150);
			this.artistLabel.Name = "artistLabel";
			this.artistLabel.Size = new System.Drawing.Size(173, 32);
			this.artistLabel.TabIndex = 12;
			this.artistLabel.Text = "Artist Name";
			// 
			// bpmLabel
			// 
			this.bpmLabel.AutoSize = true;
			this.bpmLabel.BackColor = System.Drawing.Color.Transparent;
			this.bpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bpmLabel.ForeColor = System.Drawing.Color.Silver;
			this.bpmLabel.Location = new System.Drawing.Point(332, 240);
			this.bpmLabel.Name = "bpmLabel";
			this.bpmLabel.Size = new System.Drawing.Size(79, 32);
			this.bpmLabel.TabIndex = 13;
			this.bpmLabel.Text = "BPM";
			// 
			// albumCover
			// 
			this.albumCover.Image = ((System.Drawing.Image)(resources.GetObject("albumCover.Image")));
			this.albumCover.Location = new System.Drawing.Point(58, 62);
			this.albumCover.Name = "albumCover";
			this.albumCover.Size = new System.Drawing.Size(256, 256);
			this.albumCover.TabIndex = 15;
			this.albumCover.TabStop = false;
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
			this.menu.Controls.Add(this.importIcon);
			this.menu.Controls.Add(this.importLabel);
			this.menu.Controls.Add(this.exportIcon);
			this.menu.Controls.Add(this.exportLabel);
			this.menu.Dock = System.Windows.Forms.DockStyle.Right;
			this.menu.Location = new System.Drawing.Point(1492, 36);
			this.menu.MaximumSize = new System.Drawing.Size(108, 0);
			this.menu.MinimumSize = new System.Drawing.Size(108, 352);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(108, 352);
			this.menu.TabIndex = 18;
			// 
			// metadata
			// 
			this.metadata.Controls.Add(this.metadataLabel);
			this.metadata.Controls.Add(this.albumCover);
			this.metadata.Controls.Add(this.titleLabel);
			this.metadata.Controls.Add(this.titleBox);
			this.metadata.Controls.Add(this.artistLabel);
			this.metadata.Controls.Add(this.artistBox);
			this.metadata.Controls.Add(this.bpmLabel);
			this.metadata.Controls.Add(this.bpmBox);
			this.metadata.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metadata.Location = new System.Drawing.Point(0, 36);
			this.metadata.MaximumSize = new System.Drawing.Size(1492, 352);
			this.metadata.MinimumSize = new System.Drawing.Size(1492, 352);
			this.metadata.Name = "metadata";
			this.metadata.Size = new System.Drawing.Size(1492, 352);
			this.metadata.TabIndex = 19;
			// 
			// metadataLabel
			// 
			this.metadataLabel.AutoSize = true;
			this.metadataLabel.BackColor = System.Drawing.Color.Transparent;
			this.metadataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metadataLabel.ForeColor = System.Drawing.Color.Silver;
			this.metadataLabel.Location = new System.Drawing.Point(52, 25);
			this.metadataLabel.Name = "metadataLabel";
			this.metadataLabel.Size = new System.Drawing.Size(271, 32);
			this.metadataLabel.TabIndex = 16;
			this.metadataLabel.Text = "SONG METADATA";
			// 
			// Editor
			// 
			this.AccessibleDescription = "Shadow Beat Boxing Beatmap Editor";
			this.AccessibleName = "Shadow BBR Editor";
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.metadata);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.timeline);
			this.Controls.Add(this.toolbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1600, 900);
			this.Name = "Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shadow Beat Boxing - Beatmap Editor";
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolbarLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exportIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.importIcon)).EndInit();
			this.timeline.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.restartButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musicImportButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumCover)).EndInit();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.metadata.ResumeLayout(false);
			this.metadata.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel toolbar;
		private System.Windows.Forms.Panel timeline;
		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.TextBox bpmBox;
		private System.Windows.Forms.Label toolbarLabel;
		private System.Windows.Forms.Label toolbarExit;
		private System.Windows.Forms.TextBox artistBox;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.PictureBox exportIcon;
		private System.Windows.Forms.PictureBox importIcon;
		private System.Windows.Forms.Label artistLabel;
		private System.Windows.Forms.Label bpmLabel;
		private System.Windows.Forms.PictureBox albumCover;
		private System.Windows.Forms.Label exportLabel;
		private System.Windows.Forms.Label importLabel;
		private System.Windows.Forms.PictureBox toolbarLogo;
		private System.Windows.Forms.Panel menu;
		private System.Windows.Forms.PictureBox restartButton;
		private System.Windows.Forms.PictureBox musicImportButton;
		private System.Windows.Forms.PictureBox playButton;
		private System.Windows.Forms.Panel metadata;
		private System.Windows.Forms.Label metadataLabel;
	}
}

