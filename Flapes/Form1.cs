using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flapes
{
    public partial class Flappe : Form
    {
        int dificuldade = 3,
            distanciaTubos = 130,
            nScore = 0;


        public Flappe()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Gravité
            passaro.Top = passaro.Top + 3;



            //Update Score
            score.Text = nScore.ToString();
            //+ Dificuldade
            //if (nScore == 10) dificuldade += 1;


            //Mover Tubos
            cano1b.Top = cano1t.Bottom + distanciaTubos; //Distancia entre tubos (criar variavel?)
            cano2b.Top = cano2t.Bottom + distanciaTubos;
            cano3b.Top = cano3t.Bottom + distanciaTubos;
            cano1b.Left = cano1b.Left - dificuldade; //Movendo os tubos
            cano1t.Left = cano1t.Left - dificuldade;
            cano2b.Left = cano2b.Left - dificuldade;
            cano2t.Left = cano2t.Left - dificuldade;
            cano3b.Left = cano3b.Left - dificuldade;
            cano3t.Left = cano3t.Left - dificuldade;

            //Mover fundo
            cidade1.Left = cidade1.Left - (dificuldade / 2);
            cidade2.Left = cidade2.Left - (dificuldade / 2);
            cidade3.Left = cidade3.Left - (dificuldade / 2);
            //Repeticao fundo
            if (cidade1.Right <= 0)
            {
                cidade1.Left = cidade3.Right;
            }
            else if (cidade2.Right <= 0)
            {
                cidade2.Left = cidade1.Right;
            }
            else if (cidade3.Right <= 0)
            {
                cidade3.Left = cidade2.Right;
            }


            //Se tubos chegam ao fim, voltam p comeco com posicao aleatoria
            Random rnd = new Random();
            if (cano1t.Right <= 0 && cano1b.Right <= 0)
            {
                cano1t.Top = rnd.Next(-200, 0);//Posicao topo aleatoria dos tubos
                //cano1t.Left = Flappe.Width
                cano1t.Left = 816;
                cano1b.Left = 816;
                nScore++;                
            }
            else if (cano2t.Right <= 0 && cano2b.Right <= 0)
            {
                cano1t.Top = rnd.Next(-200, 0);
                cano2t.Left = 816;
                cano2b.Left = 816;
                nScore++;
            }
            else if (cano3t.Right <= 0 && cano3b.Right <= 0)
            {
                cano1t.Top = rnd.Next(-200, 0);
                cano3t.Left = 816;
                cano3b.Left = 816;
                nScore++;
            }

            //Game over
            //passaro.Top = Flappe.height;
            if (passaro.Top + passaro.Height >= piso.Top || //NO CHAO
               //TUBO 1
                (passaro.Right >= cano1t.Left && //no meio do tubo 1 topo
                passaro.Right <= cano1t.Right &&
                passaro.Top <= cano1t.Bottom) ||
                (passaro.Right >= cano1b.Left && //no meio do tubo 1 base
                passaro.Right <= cano1b.Right &&
                passaro.Bottom >= cano1b.Top) || 
                
                //TUBO 2
                (passaro.Right >= cano2t.Left && //no meio do tubo 2 topo
                passaro.Right <= cano2t.Right &&
                passaro.Top <= cano2t.Bottom) ||
                (passaro.Right >= cano2b.Left && //no meio do tubo 2 base
                passaro.Right <= cano2b.Right &&
                passaro.Bottom >= cano2b.Top) ||

                //TUBO 3
                (passaro.Right >= cano3t.Left && //no meio do tubo 3 topo
                passaro.Right <= cano3t.Right &&
                passaro.Top <= cano2t.Bottom) ||
                (passaro.Right >= cano3b.Left && //no meio do tubo 3 base
                passaro.Right <= cano3b.Right &&
                passaro.Bottom >= cano3b.Top)
                )
            {
                GameIsOver();
            }
               
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            RestartJogo();
        }

        private void Flappe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                passaro.Top = passaro.Top - 50;
            }
        }

        private void Passaro_Click(object sender, EventArgs e)
        {

        }

        public void GameIsOver()
        {
            Buffer.Enabled     = false;
            tGameOver.Visible  = true;
            restart.Visible    = true; restart.Enabled = true;
            passaro.Visible    = false;
        }

        private void RestartJogo()
        {
            Buffer.Enabled     = true;
            tGameOver.Visible  = false;
            restart.Visible    = false; restart.Enabled = false       ;
            passaro.Visible    = true;
            dificuldade = 3;
            distanciaTubos = 130;
            nScore = 0;
            passaro.Top = 180;
            cano1t.Left = 290; cano1b.Left = 290;
            cano2t.Left = cano1t.Left + 180; cano2b.Left = cano1b.Left + 180;
            cano3t.Left = cano2t.Left + 180; cano3b.Left = cano2b.Left + 180;
        }

    }
}


/*Fazer:
 Quizz musica
 dever matematica
     
     
     */