using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palito
{
    public partial class Formpalito : Form
    { private int quantpali, resto, palitos ,bandeira=0,progressao;

        private void richTextBoxmostratudo_TextChanged(object sender, EventArgs e)
        {
            richTextBoxmostratudo.ScrollToCaret();
        }

        public Formpalito()
        {
            InitializeComponent();
            maskedTextBoxpalitos.Visible = false;//inicia invisel.
            labelretirada.Visible = false;//inicia invisel. 
            buttonretiradapali.Visible = false;//inicia invisel. 
        }
        private void buttonretiradapali_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxpalitos.Text.Equals(String.Empty))//para mostrar mensagem caso o usuário não digite nenhum numero.
            {
                MessageBox.Show("preenchimento obrigatório,voce deve preencher com numero de palitos","ATENÇÃO");
                return;
            }         
            palitos = Convert.ToInt16(maskedTextBoxpalitos.Text);// faz a conversão para inteiro.       
            maskedTextBoxpalitos.Text = string.Empty;// limpa o masked.
            if (palitos != 1 && palitos != 2 && palitos != 3)//mandar msg caso tente digitar outro numero
            {
                MessageBox.Show("são permtidos retirar de 1 a 3 palitos", "ATENÇÃO");
                return;
            }
            if (quantpali < palitos)//para que o usuário não possa retirar mais do que existe.
            {
                MessageBox.Show("voce não pode retirar esta quantidade de palitos", "ATENÇÃO");
                bandeira = 1;//para ele não retirar os palitos.
            }          
            if (quantpali == palitos)//quando for igual ele irá perder.                       
            {
                MessageBox.Show("voce perdeu", "EASY EASY");
                bandeira = 2;//para entrar no if de fim de jogo que coloquei lá em baixo.
            }                                     
            if (bandeira == 0)//serve para evitar o usuário não digitar nada diferente do que deveria!ex:só tem 1 palito e ele tirar 3
            {
                quantpali = quantpali - palitos;//retira o numero de palitos que usuário informou 
                richTextBoxmostratudo.AppendText("eu retiro " + palitos.ToString() + " palitos. (JOGADOR)"+ Environment.NewLine);              
                richTextBoxmostratudo.AppendText("restam " + quantpali.ToString() + " palitos. "+ Environment.NewLine);
                progressao = progressao - 4;// é o valor que ele precisa ficar para que eu possa sempre ganhar(PC)
                palitos = quantpali - progressao;//É o valor de palitos que  preciso tirar para tirar 
                if (palitos == 4)//para não retirar mais do que o permitido
                {
                    palitos = 3;
                }
                quantpali = quantpali - palitos;//retirar a quantia de palitos que o PC informou             
                if (quantpali >= 1)//para saber se o PC não perdeu
                {
                    richTextBoxmostratudo.AppendText("eu retiro " + palitos.ToString() + " palitos. (PC)"+ Environment.NewLine);
                    richTextBoxmostratudo.AppendText("sua vez... " + Environment.NewLine);
                    richTextBoxmostratudo.AppendText("restam " + quantpali.ToString() + " palitos."+ Environment.NewLine);                                          
                }
                else
                {
                    MessageBox.Show("eu perdi(PC)", "IMPOSSIVEL");
                    bandeira = 2;//para entrar no if de fim de jogo que coloquei lá em baixo
                }
            }
            if (bandeira == 1)//para na próxima rodada ele retornar o valor original 
                bandeira = 0;            
            if (bandeira == 2)//if de fim de jogo
            {
                 MessageBoxButtons botao = MessageBoxButtons.YesNo;//cria os botoes sim ou não
                 DialogResult resultado = MessageBox.Show("voce deseja jogar novamente?", "fim de jogo", botao);//cria a janela
                 if (resultado == DialogResult.Yes)
                 {
                      maskedTextBoxpalitos.Visible = false;//torna invisivel
                      labelretirada.Visible = false;//||
                      buttonretiradapali.Visible = false;//||
                      buttonjogar.Enabled = true;//volta a ligar o botão
                      numericUpDownquantpali.Enabled = true;//volta a ligar o botão
                      richTextBoxmostratudo.Text = string.Empty;//limpa o richtext
                      bandeira = 0;//para ele não entrar no mesmo if caso eu reinicie o jogo
                 }
                 else
                 {
                      this.Close();//fecha a aplicação
                 }
            }          
            maskedTextBoxpalitos.Focus();//fica o cursor no masked
        }
        private void buttonjogar_Click(object sender, EventArgs e)
        {
            buttonjogar.Enabled = false;//desliga para não poder clicar.
            numericUpDownquantpali.Enabled = false;//desliga para não poder clicar.
            maskedTextBoxpalitos.Visible = true;//torna visivel para poder jogar.
            labelretirada.Visible = true;//torna visivel para poder jogar.
            buttonretiradapali.Visible = true;//torna visivel para poder jogar.
            quantpali = (int)numericUpDownquantpali.Value;//converte para inteiro.        
            progressao = (int)numericUpDownquantpali.Value;
            resto = quantpali % 4;// resto da divisao para usar nos if abaixo.
            if (resto == 0)//retira uma quantidade pré determinada.
                palitos = 3;//quantidade de palitos que irá retirar.                    
            if (resto == 1)
            {
                palitos = 3;
                progressao = progressao - 1;//NESTE caso a progressao recebe um valor diferente.
            }
            if (resto == 2)           
                 palitos = 1;                    
            if (resto == 3)     
                palitos = 2;                              
            quantpali = quantpali - palitos;//retira os palitos. 
            progressao = progressao - palitos;//progressao retirando os valores pré determinados 
            richTextBoxmostratudo.AppendText("eu começo (PC)"+ Environment.NewLine);           
            richTextBoxmostratudo.AppendText("eu retiro " + palitos.ToString() + " palitos. (PC)"+ Environment.NewLine);
            richTextBoxmostratudo.AppendText("sua vez... " + Environment.NewLine);
            richTextBoxmostratudo.AppendText("restam " + quantpali.ToString() + " palitos. "+ Environment.NewLine);           
            maskedTextBoxpalitos.Focus();//fica o cursor no masked
        }
    }
}
