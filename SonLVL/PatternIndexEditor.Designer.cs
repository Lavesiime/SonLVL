﻿namespace SonicRetro.SonLVL
{
	partial class PatternIndexEditor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			this.xFlip = new System.Windows.Forms.CheckBox();
			this.yFlip = new System.Windows.Forms.CheckBox();
			this.tileList = new SonicRetro.SonLVL.API.TileList();
			this.priority = new System.Windows.Forms.CheckBox();
			this.palette = new System.Windows.Forms.NumericUpDown();
			this.tile = new System.Windows.Forms.NumericUpDown();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.palette)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tile)).BeginInit();
			this.SuspendLayout();
			// 
			// xFlip
			// 
			this.xFlip.AutoSize = true;
			this.xFlip.Location = new System.Drawing.Point(3, 3);
			this.xFlip.Name = "xFlip";
			this.xFlip.Size = new System.Drawing.Size(52, 17);
			this.xFlip.TabIndex = 0;
			this.xFlip.Text = "X Flip";
			this.xFlip.UseVisualStyleBackColor = true;
			this.xFlip.CheckedChanged += new System.EventHandler(this.xFlip_CheckedChanged);
			// 
			// yFlip
			// 
			this.yFlip.AutoSize = true;
			this.yFlip.Location = new System.Drawing.Point(61, 3);
			this.yFlip.Name = "yFlip";
			this.yFlip.Size = new System.Drawing.Size(52, 17);
			this.yFlip.TabIndex = 1;
			this.yFlip.Text = "Y Flip";
			this.yFlip.UseVisualStyleBackColor = true;
			this.yFlip.CheckedChanged += new System.EventHandler(this.yFlip_CheckedChanged);
			// 
			// tileList
			// 
			this.tileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tileList.BackColor = System.Drawing.SystemColors.Window;
			this.tileList.Location = new System.Drawing.Point(3, 78);
			this.tileList.Name = "tileList";
			this.tileList.ScrollValue = 0;
			this.tileList.SelectedIndex = -1;
			this.tileList.Size = new System.Drawing.Size(175, 203);
			this.tileList.TabIndex = 3;
			this.tileList.SelectedIndexChanged += new System.EventHandler(this.tileList_SelectedIndexChanged);
			// 
			// priority
			// 
			this.priority.AutoSize = true;
			this.priority.Location = new System.Drawing.Point(119, 3);
			this.priority.Name = "priority";
			this.priority.Size = new System.Drawing.Size(57, 17);
			this.priority.TabIndex = 4;
			this.priority.Text = "Priority";
			this.priority.UseVisualStyleBackColor = true;
			this.priority.CheckedChanged += new System.EventHandler(this.priority_CheckedChanged);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 28);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(43, 13);
			label1.TabIndex = 5;
			label1.Text = "Palette:";
			// 
			// palette
			// 
			this.palette.Location = new System.Drawing.Point(52, 26);
			this.palette.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.palette.Name = "palette";
			this.palette.Size = new System.Drawing.Size(37, 20);
			this.palette.TabIndex = 6;
			this.palette.ValueChanged += new System.EventHandler(this.palette_ValueChanged);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(3, 54);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(27, 13);
			label2.TabIndex = 7;
			label2.Text = "Tile:";
			// 
			// tile
			// 
			this.tile.Hexadecimal = true;
			this.tile.Location = new System.Drawing.Point(36, 52);
			this.tile.Maximum = new decimal(new int[] {
            2047,
            0,
            0,
            0});
			this.tile.Name = "tile";
			this.tile.Size = new System.Drawing.Size(53, 20);
			this.tile.TabIndex = 8;
			this.tile.ValueChanged += new System.EventHandler(this.tile_ValueChanged);
			// 
			// PatternIndexEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tile);
			this.Controls.Add(label2);
			this.Controls.Add(this.palette);
			this.Controls.Add(label1);
			this.Controls.Add(this.priority);
			this.Controls.Add(this.tileList);
			this.Controls.Add(this.yFlip);
			this.Controls.Add(this.xFlip);
			this.Name = "PatternIndexEditor";
			this.Size = new System.Drawing.Size(181, 284);
			this.Load += new System.EventHandler(this.PatternIndexEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.palette)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tile)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox xFlip;
		private System.Windows.Forms.CheckBox yFlip;
		private API.TileList tileList;
		private System.Windows.Forms.CheckBox priority;
		private System.Windows.Forms.NumericUpDown palette;
		private System.Windows.Forms.NumericUpDown tile;
	}
}