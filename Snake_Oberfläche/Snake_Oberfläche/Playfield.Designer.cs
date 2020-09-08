namespace Snake_Oberfläche
{
    partial class Playfield_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Playfield_wf = new System.Windows.Forms.PictureBox();
            this.Playfieldtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Playfield_wf)).BeginInit();
            this.SuspendLayout();
            // 
            // Playfield_wf
            // 
            this.Playfield_wf.BackColor = System.Drawing.Color.Silver;
            this.Playfield_wf.Location = new System.Drawing.Point(10, 10);
            this.Playfield_wf.Name = "Playfield_wf";
            this.Playfield_wf.Size = new System.Drawing.Size(701, 501);
            this.Playfield_wf.TabIndex = 0;
            this.Playfield_wf.TabStop = false;
            // 
            // Playfieldtimer
            // 
            this.Playfieldtimer.Enabled = true;
            this.Playfieldtimer.Interval = 250;
            this.Playfieldtimer.Tick += new System.EventHandler(this.Playfield_Tick);
            // 
            // Playfield_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.Playfield_wf);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Playfield_main";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Playfield_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Playfield_wf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Playfield_wf;
        private System.Windows.Forms.Timer Playfieldtimer;
    }
}

