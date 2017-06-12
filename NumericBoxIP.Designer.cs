namespace NewControls
{
    partial class NumericBoxIP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipBoxFieldA = new System.Windows.Forms.TextBox();
            this.ipBoxFieldB = new System.Windows.Forms.TextBox();
            this.ipBoxFieldC = new System.Windows.Forms.TextBox();
            this.ipBoxFieldD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ipBoxFieldA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ipBoxFieldB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ipBoxFieldC, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ipBoxFieldD, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(145, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(92, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ipBoxFieldA
            // 
            this.ipBoxFieldA.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipBoxFieldA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ipBoxFieldA.Location = new System.Drawing.Point(3, 3);
            this.ipBoxFieldA.MaxLength = 0;
            this.ipBoxFieldA.Name = "ipBoxFieldA";
            this.ipBoxFieldA.Size = new System.Drawing.Size(30, 20);
            this.ipBoxFieldA.TabIndex = 0;
            this.ipBoxFieldA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBoxFieldA.WordWrap = false;
            this.ipBoxFieldA.TextChanged += new System.EventHandler(this.ipBoxField_TextChanged);
            this.ipBoxFieldA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipBoxField_KeyPress);
            // 
            // ipBoxFieldB
            // 
            this.ipBoxFieldB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipBoxFieldB.Location = new System.Drawing.Point(56, 3);
            this.ipBoxFieldB.MaxLength = 0;
            this.ipBoxFieldB.Name = "ipBoxFieldB";
            this.ipBoxFieldB.Size = new System.Drawing.Size(30, 20);
            this.ipBoxFieldB.TabIndex = 1;
            this.ipBoxFieldB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBoxFieldB.TextChanged += new System.EventHandler(this.ipBoxField_TextChanged);
            this.ipBoxFieldB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipBoxField_KeyPress);
            // 
            // ipBoxFieldC
            // 
            this.ipBoxFieldC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipBoxFieldC.Location = new System.Drawing.Point(109, 3);
            this.ipBoxFieldC.MaxLength = 0;
            this.ipBoxFieldC.Name = "ipBoxFieldC";
            this.ipBoxFieldC.Size = new System.Drawing.Size(30, 20);
            this.ipBoxFieldC.TabIndex = 2;
            this.ipBoxFieldC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBoxFieldC.TextChanged += new System.EventHandler(this.ipBoxField_TextChanged);
            this.ipBoxFieldC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipBoxField_KeyPress);
            // 
            // ipBoxFieldD
            // 
            this.ipBoxFieldD.Location = new System.Drawing.Point(162, 3);
            this.ipBoxFieldD.MaxLength = 0;
            this.ipBoxFieldD.Name = "ipBoxFieldD";
            this.ipBoxFieldD.Size = new System.Drawing.Size(30, 20);
            this.ipBoxFieldD.TabIndex = 3;
            this.ipBoxFieldD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBoxFieldD.TextChanged += new System.EventHandler(this.ipBoxField_TextChanged);
            this.ipBoxFieldD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipBoxField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NumericBoxIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NumericBoxIP";
            this.Size = new System.Drawing.Size(195, 26);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ipBoxFieldA;
        private System.Windows.Forms.TextBox ipBoxFieldB;
        private System.Windows.Forms.TextBox ipBoxFieldD;
        private System.Windows.Forms.TextBox ipBoxFieldC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
