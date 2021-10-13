using EfinanceFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfinanceFront
{
    public partial class FrmEstado : Form
    {
        public FrmEstado()
        {
            InitializeComponent();
        }






        private async void GetAll()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(txtEndPoint.Text + "/Efinance/V1/Uf/GetAllUf"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        GdwCidade.DataSource = JsonConvert.DeserializeObject<List<Uf>>(productJsonString).ToList();


                    }
                }
                GbxRegistro.Enabled = true;
                GbxLista.Enabled = true;
            }
        }

        private void LimpaTudo()
        {
            txtId.Text = string.Empty;
            txtIbge.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtSigla.Text = string.Empty;
            txtBacen.Text = string.Empty;
            txtPais.Text = string.Empty;
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                MessageBox.Show("um domínio é necessaria. favor forneça um endpoint na caixa de ufs");
                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;
                return;
            }

            Uf oUf = new Uf();
            oUf.UfId = int.Parse(txtId.Text);
            oUf.CodigoIBGE = txtIbge.Text;
            oUf.Estado = txtEstado.Text;
            oUf.Sigla = txtSigla.Text;
            oUf.CodigoBacen = txtBacen.Text;
            oUf.Pais = txtPais.Text;
            try
            {
                //var ret = Alterar(oUf);

                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(oUf);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    //var result = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Uf/UpdateUf", content);
                    var rest = await client.PutAsync(String.Format("{0}{1}", txtEndPoint.Text, "/Efinance/V1/Uf/UpdateUf"), content);
                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }

                    GetAll();
                    GbxRegistro.Enabled = true;
                    GbxLista.Enabled = true;
                    MessageBox.Show($"Operação realizada com Sucesso: { rest}");
                    LimpaTudo();
                }





            }
            catch (Exception err)
            {

                MessageBox.Show("ERRO:" + err.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                 MessageBox.Show("Um . favor forneça um endpoint na caixa de ufs");
                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;
                return;
            }
            try
            {
                GetAll();
                LimpaTudo();
            }
            catch (Exception err)
            {

                MessageBox.Show("ERRO: " + err.Message);
            }
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                //MessageBox.Show("Uma uri é necessaria. favor forneça um endpoint na caixa de ufs");
                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;
                return;
            }

            Uf oUf = new Uf();
            oUf.CodigoIBGE = txtIbge.Text;
            oUf.Estado = txtEstado.Text;
            oUf.Sigla = txtSigla.Text;
            oUf.CodigoBacen = txtBacen.Text;
            oUf.Pais = txtPais.Text;
            try
            {
                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(oUf);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    var rest = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Uf/AddUf", content);

                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }
                    GetAll();

                    GbxRegistro.Enabled = true;
                    GbxLista.Enabled = true;

                    MessageBox.Show($"Operação realizada com Sucesso: { rest}");
                    LimpaTudo();

                }




            }
            catch (Exception err)
            {

                MessageBox.Show("ERRO:" + err.Message);
            }
        }

        private void GdwCidade_Click(object sender, EventArgs e)
        {
            txtId.Text = GdwCidade.CurrentRow.Cells[0].Value.ToString();
            txtIbge.Text = GdwCidade.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = GdwCidade.CurrentRow.Cells[2].Value.ToString();
            txtSigla.Text = GdwCidade.CurrentRow.Cells[3].Value.ToString();
            txtBacen.Text = GdwCidade.CurrentRow.Cells[4].Value.ToString();
            txtPais.Text = GdwCidade.CurrentRow.Cells[5].Value.ToString();

        }

        private void GdwCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Um estado deve ser selecionado na grade.");
                return;
            }

            using (var client = new HttpClient())
            {
                var id = Convert.ToInt32(txtId.Text);

                Uri uri = new Uri($"{txtEndPoint.Text}{"/Efinance/V1/Uf/RemoveUf"}/{id}");
                var result = await client.DeleteAsync(uri);
                // https://localhost:5001/Efinance/V1/Uf/RemoveUf/7
                if (result.IsSuccessStatusCode == false)
                {
                    MessageBox.Show($"ERRO: {result} \n { result.RequestMessage}");
                    return;
                }
                GetAll();

                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;

                MessageBox.Show($"Operação realizada com Sucesso: { result}");
                LimpaTudo();
            }
        }
    }
}
