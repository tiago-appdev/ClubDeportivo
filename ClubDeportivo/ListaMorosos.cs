namespace ClubDeportivo
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }


        private void volverMainMenuButton_Click(object sender, EventArgs e)
        {
            FrmMenu menuPrincipal = new FrmMenu();
            menuPrincipal.Show();
            this.Hide();
        }

    }
}
