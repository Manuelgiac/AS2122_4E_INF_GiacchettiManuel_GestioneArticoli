namespace AS2122_4E_INF_GiacchettiManuel_GestioneArticoli
{
    public partial class FrmMain : Form
    {
        Dictionary<string, Articolo> articoli;
        public FrmMain()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnaggiungimodicaarticoli_Click(object sender, EventArgs e)
        {
          if(articoli.ContainsKey(txtcodice.Text))
              
            {
                articoli[txtcodice.Text] = new Articolo(txtcodice.Text, cmbunitadimisura.Text, txtdescrizione.Text, Convert.ToDouble(txtprezzo.Text) );
            }
          else
            {
                articoli.Add(txtcodice.Text, new Articolo(txtcodice.Text, cmbunitadimisura.Text, txtdescrizione.Text, Convert.ToDouble(txtprezzo.Text) ));
            }
          lblArticolo.Text="Articolo(articoli.Count.ToString("+")";
        }

        private void btnvisualizza_Click(object sender, EventArgs e)
        {
            switch(cmbVisualizza.Text)
            {
            case "Visualizza Articoli":
            lstVisualizza.Items.Clear();
            foreach (KeyValuePair<string, Articolo> articoli in articoli)
            
            
            {
                lstVisualizza.Items.Add(Articolo.Value.ToString());

            }
                    break;
        }
    }
}