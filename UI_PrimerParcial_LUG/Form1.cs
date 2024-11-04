using Entity;
using DAL;
using BLL;

namespace UI_PrimerParcial_LUG
{
    public partial class Form1 : Form
    {
        private PartidoBusiness partidoBusiness = new PartidoBusiness();
        private TipoDeporteBusiness tipoDeporteBusiness = new TipoDeporteBusiness();
        private List<Partido> borradorPartidos = new List<Partido>();

        public Form1()
        {
            InitializeComponent();
        }

        private void muestraPartidos()
        {
            DtvPartidos.DataSource = null;
            DtvPartidos.DataSource = partidoBusiness.getPartidoList();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = new Partido();
                partido.Deporte = new Deporte();
                partido.Deporte.IdTipoDeporte = Convert.ToInt32(CmbTipoDeporte.SelectedValue);
                partido.EquipoLocal = TxtEquipoLocal.Text;
                partido.EquipoVisitante = TxtEquipVisitante.Text;
                partido.FechaPartido = DatePartido.Value;
                borradorPartidos.Add(partido);
                muestraPartidos();
                MessageBox.Show("Se agregó un Partido a la lista, correctamente.");

                TxtEquipoLocal.Text = null;
                TxtEquipVisitante.Text = null;
                CmbTipoDeporte.SelectedIndex = -1;
                DatePartido.Value = DateTime.Now;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (borradorPartidos.Count == 0)
                {
                    throw new Exception("La lista esta vacia !!!");
                }
                partidoBusiness.ConfirmarPartidos(borradorPartidos);
                this.muestraPartidos();
                MessageBox.Show("Se agregaron correctamente los Partidos.");
                borradorPartidos = new List<Partido>();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            borradorPartidos = new List<Partido>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbTipoDeporte.DataSource = null;
            CmbTipoDeporte.DataSource = tipoDeporteBusiness.getAll();
            CmbTipoDeporte.ValueMember = "IdTipoDeporte";
            CmbTipoDeporte.DisplayMember = "Descripcion";
            this.muestraPartidos();
            CmbTipoDeporte.SelectedIndex = -1;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                partidoBusiness.eliminarPartido(Convert.ToInt32(TxtIdEliminar.Text));
                MessageBox.Show("Partido aliminado correctamente");
                this.muestraPartidos();
                TxtIdEliminar.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtEquipoLocal.Text = null;
            TxtEquipVisitante.Text = null;
            CmbTipoDeporte.SelectedIndex = -1;
            DatePartido.Value = DateTime.Now;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                partidoBusiness.modificaMarcador(Convert.ToInt32(TxtIdModificar.Text), Convert.ToInt32(TxtMarcadorLocal.Text), Convert.ToInt32(TxtMarcadorVisitante.Text));
                MessageBox.Show("Marcador modficado correctamente");
                this.muestraPartidos();
                TxtIdModificar.Text = null;
                TxtMarcadorLocal.Text = null;
                TxtMarcadorVisitante.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
