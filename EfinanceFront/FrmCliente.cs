using EfinanceFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace EfinanceFront
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void TxtCodigoIbge_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            GetAllCidade();
            GetAllCliente();

            LimpaTudo();
        }
        private void LimpaTudo()
        {
            txtClienteId.Text = string.Empty;
            cboCidade.Text = string.Empty;
            txtCpfCnpj.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            txtRazao.Text = string.Empty;
            txtEmail.Text = string.Empty;
            chkAtivo.Checked = false;

        }
        private async void GetAllCidade()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(txtEndPoint.Text + "/Efinance/V1/Cidade/GetAllCidade"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        cboCidade.DataSource = JsonConvert.DeserializeObject<List<Cidade>>(productJsonString).ToList();
                        cboCidade.DisplayMember = "NomeCidade";
                        cboCidade.ValueMember = "CidadeId";

                    }
                }
                //GbxRegistro.Enabled = true;
                //GbxLista.Enabled = true;
            }
        }
        private async void GetAllCliente()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(txtEndPoint.Text + "/Efinance/V1/Cliente/GetAllCliente"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        GdwCidade.DataSource = JsonConvert.DeserializeObject<List<Cliente>>(productJsonString).ToList();
                        GdwCidade.Refresh();
                        //   cboCidade.DisplayMember = "NomeCidade";
                        //  cboCidade.ValueMember = "CidadeId";

                    }
                }
                //GbxRegistro.Enabled = true;
                //GbxLista.Enabled = true;
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

            Cliente o = new Cliente();
            o.CidadeId = Convert.ToInt32(cboCidade.SelectedValue);
            //o.ClienteId = Convert.ToInt32( txtClienteId.Text);
            o.CpfCnpj = txtCpfCnpj.Text;
            o.NomeFantasia = txtFantasia.Text;
            o.RazaoSocial = txtRazao.Text;
            o.Email = txtEmail.Text;
            o.DataCadastro = Convert.ToDateTime( txtDataCadastro.Text);
            o.Ativo = chkAtivo.Checked;

            try
            {
                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(o);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    var rest = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Cliente/AddCliente", content);

                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }
                    GetAllCliente();

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

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                MessageBox.Show("um domínio é necessaria. favor forneça um endpoint na caixa de ufs");
                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;
                return;
            }

            Cliente o = new Cliente();
            o.ClienteId = Convert.ToInt32(txtClienteId.Text);
            o.CidadeId = Convert.ToInt32(cboCidade.SelectedValue);
         
            o.CpfCnpj = txtCpfCnpj.Text;
            o.NomeFantasia = txtFantasia.Text;
            o.RazaoSocial = txtRazao.Text;
            o.Email = txtEmail.Text;
            o.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
            o.Ativo = chkAtivo.Checked;
            try
            {
                //var ret = Alterar(oUf);

                using (var client = new HttpClient())

                {
                    var serializeduF = JsonConvert.SerializeObject(o);
                    var content = new StringContent(serializeduF, Encoding.UTF8, "application/json");
                    //var result = await client.PostAsync(txtEndPoint.Text + "/Efinance/V1/Uf/UpdateUf", content);
                    var rest = await client.PutAsync(String.Format("{0}{1}", txtEndPoint.Text, "/Efinance/V1/Cliente/UpdateCliente"), content);
                    if (rest.IsSuccessStatusCode == false)
                    {
                        MessageBox.Show($"ERRO: {rest} \n { rest.RequestMessage}");
                        return;
                    }

                    GetAllCliente();

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
            txtClienteId.Text = GdwCidade.CurrentRow.Cells[0].Value.ToString();
            txtCpfCnpj.Text = GdwCidade.CurrentRow.Cells[1].Value.ToString();
            cboCidade.SelectedValue = GdwCidade.CurrentRow.Cells[7].Value;
            txtFantasia.Text = GdwCidade.CurrentRow.Cells[3].Value.ToString();
            txtRazao.Text = GdwCidade.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = GdwCidade.CurrentRow.Cells[2].Value.ToString();
            txtDataCadastro.Text = GdwCidade.CurrentRow.Cells[6].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(GdwCidade.CurrentRow.Cells[5].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GbxRegistro.Enabled = true;
            GbxLista.Enabled = true;
        }

        private void GdwCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClienteId.Text))
            {
                MessageBox.Show("Um cliente deve ser selecionado na grade.");
                return;
            }

            using (var client = new HttpClient())
            {
                var id = Convert.ToInt32(txtClienteId.Text);

                Uri uri = new Uri($"{txtEndPoint.Text}{"/Efinance/V1/Cliente/RemoveCliente"}/{id}");
                var result = await client.DeleteAsync(uri);
                // https://localhost:5001/Efinance/V1/Uf/RemoveUf/7
                if (result.IsSuccessStatusCode == false)
                {
                    MessageBox.Show($"ERRO: {result} \n { result.RequestMessage}");
                    return;
                }
                GetAllCliente();

                GbxRegistro.Enabled = false;
                GbxLista.Enabled = false;

                MessageBox.Show($"Operação realizada com Sucesso: { result}");
                LimpaTudo();
            }
        }
    }
}
