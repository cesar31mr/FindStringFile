namespace FindStringFile
{
    public partial class Form1 : Form
    {
        private IFindStringBusiness _findStringBusiness;

        public Form1()
        {
            InitializeComponent();
            _findStringBusiness = new FindStringBusiness();
        }

        private void btnBuscarCarpeta_Click(object sender, EventArgs e)
        {
            txtCarpeta.Text = _findStringBusiness.selectDirectory();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                var files = _findStringBusiness.findFileWithFilter(txtCarpeta.Text, txtFiltro.Text);
                dgvResultado.DataSource = files;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
