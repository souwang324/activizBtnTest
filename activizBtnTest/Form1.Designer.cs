namespace activizBtnTest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnPoints = new System.Windows.Forms.RadioButton();
            this.radioBtnWire = new System.Windows.Forms.RadioButton();
            this.radioBtnSurf = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1220, 673);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPoints);
            this.groupBox1.Controls.Add(this.radioBtnWire);
            this.groupBox1.Controls.Add(this.radioBtnSurf);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1229, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 673);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // radioBtnPoints
            // 
            this.radioBtnPoints.AutoSize = true;
            this.radioBtnPoints.Location = new System.Drawing.Point(28, 265);
            this.radioBtnPoints.Name = "radioBtnPoints";
            this.radioBtnPoints.Size = new System.Drawing.Size(70, 19);
            this.radioBtnPoints.TabIndex = 0;
            this.radioBtnPoints.TabStop = true;
            this.radioBtnPoints.Text = "Points";
            this.radioBtnPoints.UseVisualStyleBackColor = true;
            this.radioBtnPoints.CheckedChanged += new System.EventHandler(this.radioBtnPoints_CheckedChanged);
            // 
            // radioBtnWire
            // 
            this.radioBtnWire.AutoSize = true;
            this.radioBtnWire.Location = new System.Drawing.Point(28, 178);
            this.radioBtnWire.Name = "radioBtnWire";
            this.radioBtnWire.Size = new System.Drawing.Size(92, 19);
            this.radioBtnWire.TabIndex = 0;
            this.radioBtnWire.TabStop = true;
            this.radioBtnWire.Text = "Wireframe";
            this.radioBtnWire.UseVisualStyleBackColor = true;
            this.radioBtnWire.CheckedChanged += new System.EventHandler(this.radioBtnWire_CheckedChanged);
            // 
            // radioBtnSurf
            // 
            this.radioBtnSurf.AutoSize = true;
            this.radioBtnSurf.Checked = true;
            this.radioBtnSurf.Location = new System.Drawing.Point(28, 92);
            this.radioBtnSurf.Name = "radioBtnSurf";
            this.radioBtnSurf.Size = new System.Drawing.Size(78, 19);
            this.radioBtnSurf.TabIndex = 0;
            this.radioBtnSurf.TabStop = true;
            this.radioBtnSurf.Text = "Surface";
            this.radioBtnSurf.UseVisualStyleBackColor = true;
            this.radioBtnSurf.CheckedChanged += new System.EventHandler(this.radioBtnSurf_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.32194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.67806F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1404, 679);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnPoints;
        private System.Windows.Forms.RadioButton radioBtnWire;
        private System.Windows.Forms.RadioButton radioBtnSurf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

