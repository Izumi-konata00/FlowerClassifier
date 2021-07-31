
namespace FlowerClassfier
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
            this.pickButton = new System.Windows.Forms.Button();
            this.flower_name = new System.Windows.Forms.Label();
            this.Confidence = new System.Windows.Forms.Label();
            this.flower = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flower)).BeginInit();
            this.SuspendLayout();
            // 
            // pickButton
            // 
            this.pickButton.Location = new System.Drawing.Point(25, 188);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(142, 43);
            this.pickButton.TabIndex = 0;
            this.pickButton.Text = "pickfile";
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // flower_name
            // 
            this.flower_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flower_name.Location = new System.Drawing.Point(25, 65);
            this.flower_name.Name = "flower_name";
            this.flower_name.Size = new System.Drawing.Size(142, 42);
            this.flower_name.TabIndex = 1;
            // 
            // Confidence
            // 
            this.Confidence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Confidence.Location = new System.Drawing.Point(25, 124);
            this.Confidence.Name = "Confidence";
            this.Confidence.Size = new System.Drawing.Size(142, 42);
            this.Confidence.TabIndex = 2;
            this.Confidence.Text = "0%";
            // 
            // flower
            // 
            this.flower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flower.Location = new System.Drawing.Point(211, 65);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(257, 166);
            this.flower.TabIndex = 3;
            this.flower.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 289);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.Confidence);
            this.Controls.Add(this.flower_name);
            this.Controls.Add(this.pickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FlowerClassifier";
            ((System.ComponentModel.ISupportInitialize)(this.flower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.Label flower_name;
        private System.Windows.Forms.Label Confidence;
        private System.Windows.Forms.PictureBox flower;
    }
}

