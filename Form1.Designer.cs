using System.Drawing;

namespace MonteCarlo
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IterationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ApproximationBox = new System.Windows.Forms.TextBox();
            this.ElapseTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IterationBox
            // 
            this.IterationBox.Location = new System.Drawing.Point(125, 14);
            this.IterationBox.Margin = new System.Windows.Forms.Padding(0);
            this.IterationBox.Name = "IterationBox";
            this.IterationBox.Size = new System.Drawing.Size(100, 22);
            this.IterationBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Approximation:";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(235, 13);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(90, 23);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Generate";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iterations:";
            // 
            // ApproximationBox
            // 
            this.ApproximationBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApproximationBox.Location = new System.Drawing.Point(549, 14);
            this.ApproximationBox.Margin = new System.Windows.Forms.Padding(0);
            this.ApproximationBox.Name = "ApproximationBox";
            this.ApproximationBox.ReadOnly = true;
            this.ApproximationBox.Size = new System.Drawing.Size(188, 22);
            this.ApproximationBox.TabIndex = 3;
            // 
            // ElapseTime
            // 
            this.ElapseTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElapseTime.Location = new System.Drawing.Point(163, 692);
            this.ElapseTime.Margin = new System.Windows.Forms.Padding(0);
            this.ElapseTime.Name = "ElapseTime";
            this.ElapseTime.ReadOnly = true;
            this.ElapseTime.Size = new System.Drawing.Size(188, 22);
            this.ElapseTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 687);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "ElapsedTime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 803);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElapseTime);
            this.Controls.Add(this.ApproximationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.IterationBox);
            this.Name = "Form1";
            this.Text = "PIMonteCarlo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApproximationBox;
        private System.Windows.Forms.TextBox ElapseTime;
        private System.Windows.Forms.Label label3;
    }
}

