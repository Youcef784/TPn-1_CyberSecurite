using TPn_1_CyberSécurité;
namespace frmSecurite
{
    public partial class frmMenu : Form
    {
        List<ProfilSecurite> profil;
        public frmMenu()
        {
            InitializeComponent();
            profil = new List<ProfilSecurite>();
        }
        public void AjouterProfil()
        {
            ProfilSecurite nouveauProfil = new ProfilSecurite();
            profil.Add(nouveauProfil);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cmbIDprofil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
