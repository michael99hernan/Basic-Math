namespace BasicMath
{
    partial class mathForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sNum = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.fNum = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.sNum, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sign, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fNum, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sNum
            // 
            this.sNum.AutoSize = true;
            this.sNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sNum.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNum.Location = new System.Drawing.Point(359, 0);
            this.sNum.Name = "sNum";
            this.sNum.Size = new System.Drawing.Size(173, 111);
            this.sNum.TabIndex = 2;
            this.sNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sign.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(181, 0);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(172, 111);
            this.sign.TabIndex = 1;
            this.sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fNum
            // 
            this.fNum.AutoSize = true;
            this.fNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fNum.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNum.Location = new System.Drawing.Point(3, 0);
            this.fNum.Name = "fNum";
            this.fNum.Size = new System.Drawing.Size(172, 111);
            this.fNum.TabIndex = 0;
            this.fNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(241, 146);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 153);
            this.res.TabIndex = 1;
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(597, 276);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 276);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.res);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "mathForm";
            this.Text = "Practice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sNum;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label fNum;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button backButton;
    }
}