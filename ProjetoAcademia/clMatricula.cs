namespace ProjetoAcademia
{
    class clMatricula
    {
        private int idMatricula;
        private System.DateTime dataMatricula;
        private int idAluno;
        private int idTurma;
        private string statusMatricula;

        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public System.DateTime DataMatricula { get => dataMatricula; set => dataMatricula = value; }
        public int IdAluno { get => idAluno; set => idAluno = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }
        public string StatusMatricula { get => statusMatricula; set => statusMatricula = value; }
    }
}
