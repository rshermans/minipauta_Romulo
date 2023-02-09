using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minipauta_Romulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ColonizarGrid()
        {
            //dgvPauta.Columns.Add("Nome",) ;

            dgvPauta.Rows.Add("1", "Ana Rita Cunha", "Gualtar", "1950", 'F', "10", "11", "12", "10", "11", "12", "10", "11", "12", "11", "--", "--");
            dgvPauta.Rows.Add("2", "Bela Costa Silva", "Maximinos", "1999", "F", "15", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("3", "Carlos Alberto Costa", "Aveleda", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "19", "12", "12", "--", "--");
            dgvPauta.Rows.Add("4", "Carlos Daniel Ferreira", "Gualtar", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("5", "Daniel Bastos Gomes", "Maximinos", "2001", "M", "10", "11", "8", "10", "11", "12", "10", "11", "12", "18", "--", "--");
            dgvPauta.Rows.Add("6", "Daniel Silva Ferraz", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "7", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("7", "Elvira Gomes Pendes", "Maximinos", "2002", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("8", "Fernanda Maria Silva", "Aveleda", "2001", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("9", "Fernando Gomes Barros", "Gualtar", "1997", "M", "7", "11", "12", "10", "9", "12", "10", "11", "12", "16", "--", "--");
            dgvPauta.Rows.Add("10", "Guilherme Alexandre Barros", "Aveleda", "1997", "M", "10", "11", "19", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("11", "Hilda Fonseca Silva", "Maximinos", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("12", "José Manuel Carvalho", "Sé", "2001", "M", "10", "11", "16", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("13", "José Alberto Gomes", "Maximinos", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("14", "Maria Silvéria Bastos", "Lovios", "2001", "F", "10", "11", "12", "16", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("15", "Anabela Bastos Torres", "Ferreiros", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "14", "--", "--");
            dgvPauta.Rows.Add("16", "Rui Vasco Santos", "Maximinos", "2001", "M", "10", "11", "12", "10", "15", "12", "10", "11", "12", "5", "--", "--");
            dgvPauta.Rows.Add("17", "Otávio Ferreira", "Gualtar", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("18", "Silvério Silva Teixeira", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("19", "Teodoro Armando Matos", "Maximinos", "2004", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("20", "Zacarias Alexandre Sampaio", "Sequeira", "1995", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");


        }

        public void ContarNegativas()
        {
            double linhastotais = dgvPauta.Rows.Count - 1;
            double Negativas = 0;

            for (int i = 0; i < linhastotais; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    if (Convert.ToDouble(dgvPauta.Rows[i].Cells[j].Value) < 10)
                    {
                        Negativas++;
                    }

                }
                dgvPauta.Rows[i].Cells[16].Value = Negativas;
                Negativas = 0;
            }

        }


        public void CalculaMedia()

        { double media = 0;
            double soma = 0;
            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    soma = soma + (Convert.ToDouble(dgvPauta.Rows[i].Cells[j].Value));
                }

                media = soma / 10;
                dgvPauta.Rows[i].Cells[15].Value = Convert.ToString(media);
                soma = 0;
            }
        }

        //private bool Aprovado(double[] notas)
        //{
        //    int contagemNotasNegativas = 0;

        //    foreach (double nota in notas)
        //    {
        //        if (nota < 0)
        //        {
        //            contagemNotasNegativas++;
        //        }
        //    }

        //    if (contagemNotasNegativas >= (notas.Length / 2))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public void contargenerosF()

        {
            double quantosrapazes = 0;
            double quantasraparigas = 0;
            double quantosoutros = 0;

            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    quantasraparigas++;
                }
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "M")
                {
                    quantosrapazes++;
                }
                else
                {
                    quantosoutros++;
                }

            }
            txtRespostasDe1a5.Text = "";
            txtRespostasDe1a5.Text = Convert.ToString(quantasraparigas);


        }

        public void rapazesVivemEmMaximinios()
        {
            double rapazesDeMaximinios = 0;
            double vivemEmOutros = 0;
            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) != "F")
                {
                    if (Convert.ToString(dgvPauta.Rows[i].Cells[2].Value) == "Maximinos")
                    {
                        rapazesDeMaximinios++;
                    }
                    
                }
                else
                    {
                        vivemEmOutros++;
                    }
            }
            txtRespostasDe1a5.Text = "";
            txtRespostasDe1a5.Text = Convert.ToString(rapazesDeMaximinios);

        }

        public void maisRaparigasOuRapazes()

        {
            double quantosrapazes = 0;
            double quantasraparigas = 0;
            double quantosoutros = 0;

            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    quantasraparigas++;
                }
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "M")
                {
                    quantosrapazes++;
                }
                else
                {
                    quantosoutros++;
                }

            }
            if (quantasraparigas>quantosrapazes)
            {
                txtRespostasDe1a5.Text = "";
                txtRespostasDe1a5.Text = "Raparigas";
            }
            else
            {
                txtRespostasDe1a5.Text = "";
                txtRespostasDe1a5.Text = ("Rapazes");
            }
            
        }

        public void oMaisVelho()

        {
            string oNomeMaisVelho = Convert.ToString(dgvPauta.Rows[1].Cells[1].Value);
            double oAnoDoMaisVelho = Convert.ToInt64(dgvPauta.Rows[1].Cells[3].Value);

            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                if (oAnoDoMaisVelho > Convert.ToInt64(dgvPauta.Rows[i].Cells[3].Value))
                {
                    oAnoDoMaisVelho = Convert.ToInt64(dgvPauta.Rows[i].Cells[3].Value);
                    oNomeMaisVelho = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                }
                
                else
                {
                    ;
                }

            }
           
            txtRespostasDe1a5.Text = "";
            txtRespostasDe1a5.Text = Convert.ToString(oNomeMaisVelho);
           

        }

        public void reprovadosMediaMaiorQueDoze()

        {
            double reprovadosMediaMaior = 0;
            double linhastotais = dgvPauta.Rows.Count - 1;

            for (int i = 0; i < linhastotais; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > 12)
                {
                    if (Convert.ToDouble(dgvPauta.Rows[i].Cells[16].Value)>1)
                    {
                        reprovadosMediaMaior++;
                    }
                }
            }
            MessageBox.Show(Convert.ToString(reprovadosMediaMaior));
            txtRespostasDe1a5.Text = "";
            txtRespostasDe1a5.Text = Convert.ToString(reprovadosMediaMaior);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColonizarGrid();
            ContarNegativas();
            CalculaMedia();
        }

        private void lblQuantasRaparigas_Click(object sender, EventArgs e)
        {
            contargenerosF();
        }

        private void lblRapazesVivemEmMaximinios_Click(object sender, EventArgs e)
        {
            rapazesVivemEmMaximinios();
        } 
        private void lblMaisRapazesOuRaparigas_Click(object sender, EventArgs e)
        {
            maisRaparigasOuRapazes();
        }

        private void lblOmaisVelho_Click(object sender, EventArgs e)
        {
            oMaisVelho();
        }

        private void lblReprovadosTemMediaSuperiorDoze_Click(object sender, EventArgs e)
        {
            
            reprovadosMediaMaiorQueDoze();
        }
    }
}
