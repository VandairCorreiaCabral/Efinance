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
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

      

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            GetAllUf();
            GetAllCit();

            LimpaTudo();
        }

        private void LimpaTudo()
        {
            txtCidadeId.Text = string.Empty;
            cboEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
           
        }
        private async void GetAllUf()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(txtEndPoint.Text + "/Efinance/V1/Uf/GetAllUf"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        cboEstado.DataSource = JsonConvert.DeserializeObject<List<Uf>>(productJsonString).ToList();
                        cboEstado.DisplayMember = "Estado";
                        cboEstado.ValueMember = "UfId";

                    }
                }
                //GbxRegistro.Enabled = true;
                //GbxLista.Enabled = true;
            }
        }
        private async void GetAllCit()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(txtEndPoint.Text + "/Efinance/V1/Cidade/GetAllCidade"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                         GdwCidade.DataSource = JsonConvert.DeserializeObject<List<Cidade>>(productJsonString).ToList();
                        GdwCidade.Refresh();
                        //   cboCidade.DisplayMember = "NomeCidade";
                        //  cboCidade.ValueMember = "CidadeId";

                    }
                }
                //GbxRegistro.Enabled = true;
                //GbxLista.Enabled = true;
            }
        }
        private async void GetOneCit( int id)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync( $"{txtEndPoint.Text}{"/Efinance/V1/Cidade/GetOneCidade/"}{id}" ))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                       Cidade cidade =  JsonConvert.DeserializeObject<Cidade>(productJsonString);

                        txtCidadeId.Text = cidade.CidadeId.ToString();
                        txtCidade.Text = cidade.NomeCidade;
                    }
                }
               
            }
           
        }

       

        private async void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                //MessageBox.Show("Uma uri é necessaria. favor forneça um endpoint na caixa de ufs");
                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;
                return;
            }

            Cidade o = new Cidade();
            o.UfId = Convert.ToInt32(cboEstado.SelectedValue);
            o.NomeCidade = txtCidade.Text;
           
            try
            {
                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(o);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    var rest = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Cidade/AddCidade", content);

                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }
                    GetAllCit();

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
            GbxRegistro.Enabled = true;
            GbxLista.Enabled = true;
        }

        private void GdwCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GdwCidade_Click(object sender, EventArgs e)
        {
            txtCidadeId.Text = GdwCidade.CurrentRow.Cells[0].Value.ToString();
            txtCidade.Text = GdwCidade.CurrentRow.Cells[2].Value.ToString();
            cboEstado.SelectedValue = GdwCidade.CurrentRow.Cells[1].Value;
           
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

            Cidade o = new Cidade();
            o.CidadeId= Convert.ToInt32( txtCidadeId.Text);
            o.UfId = Convert.ToInt32(cboEstado.SelectedValue);
            o.NomeCidade = txtCidade.Text;
            try
            {
                //var ret = Alterar(oUf);

                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(o);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    //var result = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Uf/UpdateUf", content);
                    var rest = await client.PutAsync(String.Format("{0}{1}", txtEndPoint.Text, "/Efinance/V1/Cidade/UpdateCidade"), content);
                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }

                    GetAllCit();
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

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCidadeId.Text))
            {
                MessageBox.Show("Uma cidade deve ser selecionado na grade.");
                return;
            }

            using (var client = new HttpClient())
            {
                var id = Convert.ToInt32(txtCidadeId.Text);

                Uri uri = new Uri($"{txtEndPoint.Text}{"/Efinance/V1/Cidade/RemoveCidade"}/{id}");
                var result = await client.DeleteAsync(uri);
                // https://localhost:5001/Efinance/V1/Uf/RemoveUf/7
                if (result.IsSuccessStatusCode == false)
                {
                    MessageBox.Show($"ERRO: {result} \n { result.RequestMessage}");
                    return;
                }
                GetAllCit();

                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;

                MessageBox.Show($"Operação realizada com Sucesso: { result}");
                LimpaTudo();
            }
        }
    }
}
