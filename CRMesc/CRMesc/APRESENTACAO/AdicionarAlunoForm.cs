using CRMesc.MODEL;
using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace CRMesc
{
    public partial class AdicionarEnderecoForm : Form
    {
   
        public bool btn_preencherIdClicado = false;
        public bool btn_anexarId_Clicado = false;

        public AdicionarEnderecoForm()
        {
            InitializeComponent();
        }

        private void Btn_salvarmatricula_Click(object sender, EventArgs e)
        {
            AdicionarAlunoControle adicionarAluno = new AdicionarAlunoControle();
            adicionarAluno.SalvaMatricula();
        }
        private void Button_buscaCep_Click(object sender, EventArgs e)
        {
            AdicionarAlunoControle alunoControle = new AdicionarAlunoControle();
            alunoControle.BuscarCep(mascara_cep.Text.ToString());
            //validar se tem 8 caracteres


        }
            private void Lbl_telefone_Click(object sender, EventArgs e)
        {

        }

        private void Btn_adicionarfotoaluno_Click(object sender, EventArgs e)
        {
            // buscador de imagens no pc
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Selecione a foto(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif"
            };
            OpenFileDialog opf = openFileDialog;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pctb_foto.Image = Image.FromFile(opf.FileName);
            }

        }

        private void Btn_cancelarMatricula_Click(object sender, EventArgs e)
        {
            //cancela matricula
            Close();
        }
        private void Pctb_foto_Click(object sender, EventArgs e)
        {

        }
        private void Txt_end_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btn_preencher_endereco_Click(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Button_buscaEndereco_Click(object sender, EventArgs e)
        {

 
            
        }

        private void TextBoxidEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Anexar_MouseClick(object sender, MouseEventArgs e)
        {
            //AdicionaEnderecoForm endereco = new AdicionaEnderecoForm();
            //textBoxidEndereco.Text = Convert.ToString( endereco.idEndereco);
        }

        private void Button_Anexar_Click(object sender, EventArgs e)
        {

        }

        private void Button_cadastraResponsavel_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Label_telefone_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarEnderecoForm_Load(object sender, EventArgs e)
        {
           /* mascara_cep.ValidatingType = typeof(System.DateTime);
            mascara_cep.TypeValidationCompleted += new TypeValidationEventHandler(Mascara_cep_TypeValidationCompleted);*/
            mascara_cep.Mask = "0000-0000";
            mascara_cep.MaskInputRejected += new MaskInputRejectedEventHandler(Mascara_cep_MaskInputRejected);

        }

        private void Mascara_cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.ToolTipTitle = "Invalid Input";
            tip.Show("Desculpe, são aceitos somente digitos (0-9)", mascara_cep, mascara_cep.Location,5000);
        }
    

        private void Mascara_cep_Validated(object sender, EventArgs e)
        {

        }

        private void Mascara_cep_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

        }
    }

}

    


