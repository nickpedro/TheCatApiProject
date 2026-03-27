using System;
using System.Windows.Forms;
using TheCatApiProject.Controllers;

namespace TheCatApiProject
{
    public partial class Frm1 : Form
    {
        private readonly CatController _controller = new CatController();

        public Frm1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
          
            try
            {
                var cat = await _controller.BuscarGato();

                txtUrl.Text = cat.url;
                picCat.Load(cat.url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                
            }
        }

      
    }
}