namespace ClubDeportivo
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
            this.FormClosing += FrmLista_FormClosing;
        }

        private void FrmLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu menuPrincipal = new(); //Instanciamos el menu principal para mostrarlo.
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }

    }
}
