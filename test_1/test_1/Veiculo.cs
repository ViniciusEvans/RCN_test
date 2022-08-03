namespace Hello_world
{
    class Veiculo
    {
        public Veiculo() { }

        public string Nome { get; private set; }
        public string Tipo { get; private set; }

        public Veiculo(string nome, string tipo)
        {
            Tipo = tipo;
            Nome = nome;
        }
      

    }

}
