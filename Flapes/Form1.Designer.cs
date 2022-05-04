namespace Flapes
{
    partial class Flappe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappe));
            this.passaro = new System.Windows.Forms.PictureBox();
            this.Buffer = new System.Windows.Forms.Timer(this.components);
            this.cano1b = new System.Windows.Forms.Panel();
            this.cano1t = new System.Windows.Forms.Panel();
            this.cano2b = new System.Windows.Forms.Panel();
            this.cano2t = new System.Windows.Forms.Panel();
            this.cano3b = new System.Windows.Forms.Panel();
            this.cano3t = new System.Windows.Forms.Panel();
            this.piso = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.tGameOver = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.cidade1 = new System.Windows.Forms.PictureBox();
            this.cidade2 = new System.Windows.Forms.PictureBox();
            this.cidade3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade3)).BeginInit();
            this.SuspendLayout();
            // 
            // passaro
            // 
            this.passaro.BackColor = System.Drawing.Color.Transparent;
            this.passaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passaro.Image = ((System.Drawing.Image)(resources.GetObject("passaro.Image")));
            this.passaro.InitialImage = ((System.Drawing.Image)(resources.GetObject("passaro.InitialImage")));
            this.passaro.Location = new System.Drawing.Point(61, 177);
            this.passaro.Name = "passaro";
            this.passaro.Size = new System.Drawing.Size(70, 40);
            this.passaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passaro.TabIndex = 0;
            this.passaro.TabStop = false;
            this.passaro.Click += new System.EventHandler(this.Passaro_Click);
            // 
            // Buffer
            // 
            this.Buffer.Enabled = true;
            this.Buffer.Interval = 10;
            this.Buffer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cano1b
            // 
            this.cano1b.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano1b.Location = new System.Drawing.Point(286, 316);
            this.cano1b.Name = "cano1b";
            this.cano1b.Size = new System.Drawing.Size(50, 276);
            this.cano1b.TabIndex = 1;
            // 
            // cano1t
            // 
            this.cano1t.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano1t.Location = new System.Drawing.Point(286, -76);
            this.cano1t.Name = "cano1t";
            this.cano1t.Size = new System.Drawing.Size(50, 276);
            this.cano1t.TabIndex = 1;
            // 
            // cano2b
            // 
            this.cano2b.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano2b.Location = new System.Drawing.Point(511, 283);
            this.cano2b.Name = "cano2b";
            this.cano2b.Size = new System.Drawing.Size(50, 276);
            this.cano2b.TabIndex = 1;
            // 
            // cano2t
            // 
            this.cano2t.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano2t.Location = new System.Drawing.Point(511, -109);
            this.cano2t.Name = "cano2t";
            this.cano2t.Size = new System.Drawing.Size(50, 276);
            this.cano2t.TabIndex = 1;
            // 
            // cano3b
            // 
            this.cano3b.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano3b.Location = new System.Drawing.Point(726, 356);
            this.cano3b.Name = "cano3b";
            this.cano3b.Size = new System.Drawing.Size(50, 276);
            this.cano3b.TabIndex = 1;
            // 
            // cano3t
            // 
            this.cano3t.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cano3t.Location = new System.Drawing.Point(726, -36);
            this.cano3t.Name = "cano3t";
            this.cano3t.Size = new System.Drawing.Size(50, 276);
            this.cano3t.TabIndex = 1;
            // 
            // piso
            // 
            this.piso.BackColor = System.Drawing.Color.Gray;
            this.piso.Location = new System.Drawing.Point(-5, 429);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(815, 24);
            this.piso.TabIndex = 1;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(94, 39);
            this.score.TabIndex = 2;
            this.score.Text = "label1";
            // 
            // tGameOver
            // 
            this.tGameOver.AutoSize = true;
            this.tGameOver.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tGameOver.Location = new System.Drawing.Point(175, 115);
            this.tGameOver.Name = "tGameOver";
            this.tGameOver.Size = new System.Drawing.Size(468, 117);
            this.tGameOver.TabIndex = 2;
            this.tGameOver.Text = "Game Over";
            this.tGameOver.Visible = false;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.restart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restart.Location = new System.Drawing.Point(370, 235);
            this.restart.Name = "restart";
            this.restart.Padding = new System.Windows.Forms.Padding(3, 0, 0, 7);
            this.restart.Size = new System.Drawing.Size(67, 67);
            this.restart.TabIndex = 3;
            this.restart.Text = "⟳";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // cidade1
            // 
            this.cidade1.BackColor = System.Drawing.Color.Transparent;
            this.cidade1.Image = ((System.Drawing.Image)(resources.GetObject("cidade1.Image")));
            this.cidade1.Location = new System.Drawing.Point(-5, 180);
            this.cidade1.Name = "cidade1";
            this.cidade1.Size = new System.Drawing.Size(417, 273);
            this.cidade1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cidade1.TabIndex = 4;
            this.cidade1.TabStop = false;
            // 
            // cidade2
            // 
            this.cidade2.BackColor = System.Drawing.Color.Transparent;
            this.cidade2.Image = ((System.Drawing.Image)(resources.GetObject("cidade2.Image")));
            this.cidade2.Location = new System.Drawing.Point(392, 180);
            this.cidade2.Name = "cidade2";
            this.cidade2.Size = new System.Drawing.Size(417, 273);
            this.cidade2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cidade2.TabIndex = 4;
            this.cidade2.TabStop = false;
            // 
            // cidade3
            // 
            this.cidade3.Image = ((System.Drawing.Image)(resources.GetObject("cidade3.Image")));
            this.cidade3.Location = new System.Drawing.Point(799, 180);
            this.cidade3.Name = "cidade3";
            this.cidade3.Size = new System.Drawing.Size(417, 273);
            this.cidade3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cidade3.TabIndex = 4;
            this.cidade3.TabStop = false;
            // 
            // Flappe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.tGameOver);
            this.Controls.Add(this.score);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.cano3t);
            this.Controls.Add(this.cano2t);
            this.Controls.Add(this.cano1t);
            this.Controls.Add(this.cano3b);
            this.Controls.Add(this.cano2b);
            this.Controls.Add(this.cano1b);
            this.Controls.Add(this.passaro);
            this.Controls.Add(this.cidade3);
            this.Controls.Add(this.cidade2);
            this.Controls.Add(this.cidade1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flappe";
            this.Text = "Flappe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flappe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidade3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox passaro;
        private System.Windows.Forms.Timer Buffer;
        private System.Windows.Forms.Panel cano1b;
        private System.Windows.Forms.Panel cano1t;
        private System.Windows.Forms.Panel cano2b;
        private System.Windows.Forms.Panel cano2t;
        private System.Windows.Forms.Panel cano3b;
        private System.Windows.Forms.Panel cano3t;
        private System.Windows.Forms.Panel piso;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label tGameOver;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.PictureBox cidade1;
        private System.Windows.Forms.PictureBox cidade2;
        private System.Windows.Forms.PictureBox cidade3;
    }
}

