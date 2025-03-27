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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(225, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(209, 272);
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
            this.btnRotate.Location = new System.Drawing.Point(115, 110);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(84, 34);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // rdo90
            // 
            this.rdo90.AutoSize = true;
            this.rdo90.Location = new System.Drawing.Point(115, 22);
            this.rdo90.Name = "rdo90";
            this.rdo90.Size = new System.Drawing.Size(69, 24);
            this.rdo90.TabIndex = 3;
            this.rdo90.TabStop = true;
            this.rdo90.Text = "90 st";
            this.rdo90.UseVisualStyleBackColor = true;
            // 
            // rdo180
            // 
            this.rdo180.AutoSize = true;
            this.rdo180.Location = new System.Drawing.Point(115, 50);
            this.rdo180.Name = "rdo180";
            this.rdo180.Size = new System.Drawing.Size(78, 24);
            this.rdo180.TabIndex = 4;
            this.rdo180.TabStop = true;
            this.rdo180.Text = "180 st";
            this.rdo180.UseVisualStyleBackColor = true;
            // 
            // rdo270
            // 
            this.rdo270.AutoSize = true;
            this.rdo270.Location = new System.Drawing.Point(115, 80);
            this.rdo270.Name = "rdo270";
            this.rdo270.Size = new System.Drawing.Size(78, 24);
            this.rdo270.TabIndex = 5;
            this.rdo270.TabStop = true;
            this.rdo270.Text = "270 st";
            this.rdo270.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

