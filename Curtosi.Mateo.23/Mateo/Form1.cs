using Curtosi.Mateo._23;
namespace Mateo

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {

            if (lstMedicos.SelectedIndex != -1 && lstPacientes.SelectedIndex != -1)
            {
                string auxNombre = lstPacientes.Text;
                MessageBox.Show($"se ha atendido a {auxNombre} ", "atencion finalizada", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("debe seleccionar un Medico y un Paciente para poder continuar", "error en los datos");
            }
        }

        private void rtbinfoMedico_TextChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedIndex != -1)
            {
                PersonalMedico medicoSeleccionado = (PersonalMedico)lstMedicos.SelectedItem;
                string infomedico = medicoSeleccionado.FichaPersonal(medicoSeleccionado);
                rtbinfoMedico.Text = medicoSeleccionado.FichaPersonal(medicoSeleccionado);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("seguro desas salir?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
