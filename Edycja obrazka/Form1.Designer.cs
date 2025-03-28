namespace Edycja_obrazka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.rdo90 = new System.Windows.Forms.RadioButton();
            this.rdo180 = new System.Windows.Forms.RadioButton();
            this.rdo270 = new System.Windows.Forms.RadioButton();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnUpsideDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(271, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(282, 360);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(115, 264);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.IndianRed;
            this.btnRotate.Location = new System.Drawing.Point(115, 110);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(84, 34);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // rdo90
            // 
            this.rdo90.AutoSize = true;
            this.rdo90.BackColor = System.Drawing.Color.IndianRed;
            this.rdo90.Location = new System.Drawing.Point(115, 22);
            this.rdo90.Name = "rdo90";
            this.rdo90.Size = new System.Drawing.Size(69, 24);
            this.rdo90.TabIndex = 3;
            this.rdo90.TabStop = true;
            this.rdo90.Text = "90 st";
            this.rdo90.UseVisualStyleBackColor = false;
            // 
            // rdo180
            // 
            this.rdo180.AutoSize = true;
            this.rdo180.BackColor = System.Drawing.Color.IndianRed;
            this.rdo180.Location = new System.Drawing.Point(115, 50);
            this.rdo180.Name = "rdo180";
            this.rdo180.Size = new System.Drawing.Size(78, 24);
            this.rdo180.TabIndex = 4;
            this.rdo180.TabStop = true;
            this.rdo180.Text = "180 st";
            this.rdo180.UseVisualStyleBackColor = false;
            // 
            // rdo270
            // 
            this.rdo270.AutoSize = true;
            this.rdo270.BackColor = System.Drawing.Color.IndianRed;
            this.rdo270.Location = new System.Drawing.Point(115, 80);
            this.rdo270.Name = "rdo270";
            this.rdo270.Size = new System.Drawing.Size(78, 24);
            this.rdo270.TabIndex = 5;
            this.rdo270.TabStop = true;
            this.rdo270.Text = "270 st";
            this.rdo270.UseVisualStyleBackColor = false;
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInvert.Location = new System.Drawing.Point(81, 150);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(138, 33);
            this.btnInvert.TabIndex = 6;
            this.btnInvert.Text = "Invert Colors";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnUpsideDown
            // 
            this.btnUpsideDown.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpsideDown.Location = new System.Drawing.Point(81, 189);
            this.btnUpsideDown.Name = "btnUpsideDown";
            this.btnUpsideDown.Size = new System.Drawing.Size(138, 32);
            this.btnUpsideDown.TabIndex = 7;
            this.btnUpsideDown.Text = "Upside Down";
            this.btnUpsideDown.UseVisualStyleBackColor = false;
            this.btnUpsideDown.Click += new System.EventHandler(this.btnUpsideDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpsideDown);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.rdo270);
            this.Controls.Add(this.rdo180);
            this.Controls.Add(this.rdo90);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.RadioButton rdo90;
        private System.Windows.Forms.RadioButton rdo180;
        private System.Windows.Forms.RadioButton rdo270;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnUpsideDown;
    }
}

