
namespace ErianFizzBuzz
{
    partial class FrmFizz
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
            this.lbxFizz = new System.Windows.Forms.ListBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.bttnGaan = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxFizz
            // 
            this.lbxFizz.FormattingEnabled = true;
            this.lbxFizz.Location = new System.Drawing.Point(12, 21);
            this.lbxFizz.Name = "lbxFizz";
            this.lbxFizz.Size = new System.Drawing.Size(275, 303);
            this.lbxFizz.TabIndex = 0;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(75, 336);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(40, 13);
            this.lblAantal.TabIndex = 1;
            this.lblAantal.Text = "Aantal:";
            // 
            // bttnGaan
            // 
            this.bttnGaan.Location = new System.Drawing.Point(119, 388);
            this.bttnGaan.Name = "bttnGaan";
            this.bttnGaan.Size = new System.Drawing.Size(75, 23);
            this.bttnGaan.TabIndex = 2;
            this.bttnGaan.Text = "Gaan";
            this.bttnGaan.UseVisualStyleBackColor = true;
            this.bttnGaan.Click += new System.EventHandler(this.bttnGaan_Click);
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(119, 333);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAantal.Size = new System.Drawing.Size(79, 20);
            this.txtAantal.TabIndex = 4;
            // 
            // FrmFizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.bttnGaan);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lbxFizz);
            this.Name = "FrmFizz";
            this.Text = "Fizzbuzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFizz;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button bttnGaan;
        private System.Windows.Forms.TextBox txtAantal;
    }
}

