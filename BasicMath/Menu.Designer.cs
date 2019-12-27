﻿namespace BasicMath
{
    partial class Menu
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.MULT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(660, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Practice Math";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(250, 56);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(194, 47);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "Addition";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // SUB
            // 
            this.SUB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SUB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SUB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUB.Location = new System.Drawing.Point(250, 109);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(194, 47);
            this.SUB.TabIndex = 2;
            this.SUB.Text = "Subtraction";
            this.SUB.UseVisualStyleBackColor = false;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // MULT
            // 
            this.MULT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MULT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MULT.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULT.Location = new System.Drawing.Point(250, 162);
            this.MULT.Name = "MULT";
            this.MULT.Size = new System.Drawing.Size(194, 47);
            this.MULT.TabIndex = 3;
            this.MULT.Text = "Multiplication";
            this.MULT.UseVisualStyleBackColor = false;
            this.MULT.Click += new System.EventHandler(this.MULT_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.MULT);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "Menu";
            this.Text = "Practice Math";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.Button MULT;
    }
}

