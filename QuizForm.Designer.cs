namespace QuizApp
{
    partial class QuizApp
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
            this.panel1DArray = new System.Windows.Forms.Panel();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNames = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn1DArray = new System.Windows.Forms.Button();
            this.btn2DArray = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.panel2DArray = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2DArray = new System.Windows.Forms.TextBox();
            this.label2DArray = new System.Windows.Forms.Label();
            this.panelContains = new System.Windows.Forms.Panel();
            this.lblContains = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1DArray.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2DArray.SuspendLayout();
            this.panelContains.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1DArray
            // 
            this.panel1DArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1DArray.Controls.Add(this.textBoxNames);
            this.panel1DArray.Controls.Add(this.label1);
            this.panel1DArray.Controls.Add(this.btnNames);
            this.panel1DArray.Controls.Add(this.lblName);
            this.panel1DArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1DArray.Location = new System.Drawing.Point(0, 0);
            this.panel1DArray.Name = "panel1DArray";
            this.panel1DArray.Size = new System.Drawing.Size(1361, 679);
            this.panel1DArray.TabIndex = 0;
            this.panel1DArray.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxNames
            // 
            this.textBoxNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNames.Location = new System.Drawing.Point(555, 146);
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(289, 22);
            this.textBoxNames.TabIndex = 4;
            this.textBoxNames.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(550, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(880, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "One-Dimensional Array";
            // 
            // btnNames
            // 
            this.btnNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNames.BackColor = System.Drawing.Color.Black;
            this.btnNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNames.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNames.Location = new System.Drawing.Point(594, 210);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(196, 48);
            this.btnNames.TabIndex = 1;
            this.btnNames.Text = "Display Names";
            this.btnNames.UseVisualStyleBackColor = false;
            this.btnNames.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(550, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "List of Names";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.Btn1DArray);
            this.flowLayoutPanel1.Controls.Add(this.btn2DArray);
            this.flowLayoutPanel1.Controls.Add(this.btnContains);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 679);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1361, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Btn1DArray
            // 
            this.Btn1DArray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn1DArray.BackColor = System.Drawing.Color.Black;
            this.Btn1DArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1DArray.Location = new System.Drawing.Point(28, 3);
            this.Btn1DArray.Name = "Btn1DArray";
            this.Btn1DArray.Size = new System.Drawing.Size(268, 67);
            this.Btn1DArray.TabIndex = 0;
            this.Btn1DArray.Text = "One-Dimensional Array";
            this.Btn1DArray.UseVisualStyleBackColor = false;
            this.Btn1DArray.Click += new System.EventHandler(this.Btn1DArray_Click);
            // 
            // btn2DArray
            // 
            this.btn2DArray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2DArray.BackColor = System.Drawing.Color.Black;
            this.btn2DArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2DArray.Location = new System.Drawing.Point(302, 3);
            this.btn2DArray.Name = "btn2DArray";
            this.btn2DArray.Size = new System.Drawing.Size(268, 67);
            this.btn2DArray.TabIndex = 1;
            this.btn2DArray.Text = "Two-Dimensional Array";
            this.btn2DArray.UseVisualStyleBackColor = false;
            this.btn2DArray.Click += new System.EventHandler(this.btn2DArray_Click);
            // 
            // btnContains
            // 
            this.btnContains.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContains.BackColor = System.Drawing.Color.Black;
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContains.Location = new System.Drawing.Point(576, 3);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(268, 67);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // panel2DArray
            // 
            this.panel2DArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2DArray.Controls.Add(this.button1);
            this.panel2DArray.Controls.Add(this.textBox2DArray);
            this.panel2DArray.Controls.Add(this.label2DArray);
            this.panel2DArray.Location = new System.Drawing.Point(0, 0);
            this.panel2DArray.Name = "panel2DArray";
            this.panel2DArray.Size = new System.Drawing.Size(10, 679);
            this.panel2DArray.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(-100, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Display Array";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2DArray
            // 
            this.textBox2DArray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2DArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2DArray.Location = new System.Drawing.Point(-99, 113);
            this.textBox2DArray.Name = "textBox2DArray";
            this.textBox2DArray.Size = new System.Drawing.Size(280, 30);
            this.textBox2DArray.TabIndex = 4;
            this.textBox2DArray.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2DArray
            // 
            this.label2DArray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2DArray.AutoSize = true;
            this.label2DArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2DArray.Location = new System.Drawing.Point(-675, 0);
            this.label2DArray.Name = "label2DArray";
            this.label2DArray.Padding = new System.Windows.Forms.Padding(550, 15, 0, 0);
            this.label2DArray.Size = new System.Drawing.Size(879, 47);
            this.label2DArray.TabIndex = 3;
            this.label2DArray.Text = "Two-Dimensional Array";
            // 
            // panelContains
            // 
            this.panelContains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelContains.Controls.Add(this.lblContains);
            this.panelContains.Controls.Add(this.txtCheck);
            this.panelContains.Controls.Add(this.btnCheck);
            this.panelContains.Location = new System.Drawing.Point(224, 590);
            this.panelContains.Name = "panelContains";
            this.panelContains.Padding = new System.Windows.Forms.Padding(550, 15, 0, 0);
            this.panelContains.Size = new System.Drawing.Size(1137, 89);
            this.panelContains.TabIndex = 5;
            this.panelContains.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.lblContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContains.Location = new System.Drawing.Point(0, 0);
            this.lblContains.Name = "lblContains";
            this.lblContains.Padding = new System.Windows.Forms.Padding(600, 15, 0, 0);
            this.lblContains.Size = new System.Drawing.Size(735, 47);
            this.lblContains.TabIndex = 7;
            this.lblContains.Text = "Contains";
            this.lblContains.Click += new System.EventHandler(this.lblContains_Click);
            // 
            // txtCheck
            // 
            this.txtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck.Location = new System.Drawing.Point(530, 77);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(280, 30);
            this.txtCheck.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheck.Location = new System.Drawing.Point(567, 135);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(212, 48);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // QuizApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1361, 779);
            this.Controls.Add(this.panelContains);
            this.Controls.Add(this.panel2DArray);
            this.Controls.Add(this.panel1DArray);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "QuizApp";
            this.Text = "Quiz App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1DArray.ResumeLayout(false);
            this.panel1DArray.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2DArray.ResumeLayout(false);
            this.panel2DArray.PerformLayout();
            this.panelContains.ResumeLayout(false);
            this.panelContains.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1DArray;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn1DArray;
        private System.Windows.Forms.Button btn2DArray;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2DArray;
        private System.Windows.Forms.Label label2DArray;
        private System.Windows.Forms.TextBox textBox2DArray;
        private System.Windows.Forms.TextBox textBoxNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContains;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Label lblContains;
    }
}

