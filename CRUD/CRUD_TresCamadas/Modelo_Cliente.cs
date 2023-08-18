namespace CRUD_TresCamadas
{
    class Modelo_Cliente
    {
        int codigo;
        string nome;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string Nome
        {
            set { nome = value; }   
            get { return nome; }
        }


    }
}
