namespace Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Total.Text = (int.Parse(Atual.Text) - int.Parse(Nascimento.Text)).ToString();
        }
    }
}