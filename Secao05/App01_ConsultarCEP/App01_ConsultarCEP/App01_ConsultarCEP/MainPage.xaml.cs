using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            txtCep.Text = "";
            txtResultado.Text = "";

            btnBuscar.Clicked += BtnBuscar_Clicked;
        }

        private void BtnBuscar_Clicked(object sender, EventArgs e)
        {

            //Logica do Programa

            string cep = txtCep.Text.Trim();
            if (isValidCEP(cep))
            {
                try
                {
                    //Busca na web
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        txtResultado.Text = string.Format("Endereco : {0} {1}, {2} - {3}/{4}", end.logradouro, end.complemento, end.bairro, end.localidade, end.uf);
                    }
                    else
                    {
                        DisplayAlert("Error", "O Endereção não foi encontrado CEP inválido!!!", "OK");
                        txtCep.Text = "";
                    }
                } catch (Exception ex)
                {
                    DisplayAlert("Error Critico", ex.Message, "OK");
                }
            }

        } 

        private bool isValidCEP(string cep)
        {
            bool _retorno = true;
            try
            {
                if(cep.Length != 8)
                {
                    DisplayAlert("Erro", "CEP Invalido! O CEP deve conter 8 caractares", "OK");
                    _retorno = false;
                }
                int NovoCEP = 0;
                if (!int.TryParse(cep, out NovoCEP))
                {
                    DisplayAlert("Erro", "CEP Invalido! O CEP deve ser composto apenas por números", "OK");
                    _retorno = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _retorno;
        }
    }
}