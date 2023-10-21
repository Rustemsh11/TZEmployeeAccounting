using Contracts;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly IRepositoryManager _repositoryManager;
        public Form1(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
        }

        private  void Form1_Load(object sender, EventArgs e)
        {

        }


        private void çàïëîíèòüÁàçóÄàííûõToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fillForm = new FillEmployeeForms(_repositoryManager);
            fillForm.ShowDialog();

        }

        private void ñîòğóäíèêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empForm = new EmployeeForm(_repositoryManager);
            empForm.ShowDialog();
        }

        private void ïîäğàçäåëåíèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var depForm = new DepartmentsForm(_repositoryManager);
            depForm.Show();
        }
    }
}