namespace ProjetoAcademia
{
    class clProfessor
    {
        private int idProfessor;
        private string nome;
        private string tel;
        private string cel;
        private string email;
        private string senha;
        private string statusProfessor;

        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string StatusProfessor { get => statusProfessor; set => statusProfessor = value; }
    }
}
