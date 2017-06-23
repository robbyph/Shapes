namespace Shapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandColor = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numupdownSize = new System.Windows.Forms.NumericUpDown();
            this.picboxSize = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(16, 47);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(720, 480);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "(L)ine, (O)val, (R)ectangle, (T)rails, (C)lear, R(a)ndom Colors, (U)ser selected " +
    "color, Ea(z)y Undo\r\n\r\n\r\n";
            // 
            // btnRandColor
            // 
            this.btnRandColor.Location = new System.Drawing.Point(743, 47);
            this.btnRandColor.Name = "btnRandColor";
            this.btnRandColor.Size = new System.Drawing.Size(104, 51);
            this.btnRandColor.TabIndex = 2;
            this.btnRandColor.Text = "Toggle Random Colors";
            this.btnRandColor.UseVisualStyleBackColor = true;
            this.btnRandColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(743, 114);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(104, 39);
            this.btnChooseColor.TabIndex = 3;
            this.btnChooseColor.Text = "Choose A Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Brush Size";
            // 
            // numupdownSize
            // 
            this.numupdownSize.Location = new System.Drawing.Point(742, 193);
            this.numupdownSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numupdownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdownSize.Name = "numupdownSize";
            this.numupdownSize.Size = new System.Drawing.Size(115, 20);
            this.numupdownSize.TabIndex = 7;
            this.numupdownSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numupdownSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numupdownSize.ValueChanged += new System.EventHandler(this.numupdownSize_ValueChanged);
            // 
            // picboxSize
            // 
            this.picboxSize.Location = new System.Drawing.Point(747, 219);
            this.picboxSize.Name = "picboxSize";
            this.picboxSize.Size = new System.Drawing.Size(100, 28);
            this.picboxSize.TabIndex = 9;
            this.picboxSize.TabStop = false;
            this.picboxSize.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxSize_Paint_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(742, 295);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(115, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Box";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(747, 346);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(43, 25);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(804, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 25);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Trails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(804, 378);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(43, 23);
            this.btnFill.TabIndex = 16;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(859, 541);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.picboxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numupdownSize);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.btnRandColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Shapes";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numupdownSize;
        private System.Windows.Forms.PictureBox picboxSize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFill;
    }
}

