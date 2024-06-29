using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia
{
    class clTurma
    {

        private int idTurma;
        private string descricao;
        private TimeSpan horarioinicio;
        private TimeSpan horariotermino;
        private int idProfessor;
        private string statusTurma;

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public TimeSpan Horarioinicio { get => horarioinicio; set => horarioinicio = value; }
        public TimeSpan Horariotermino { get => horariotermino; set => horariotermino = value; }
        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
        public string StatusTurma { get => statusTurma; set => statusTurma = value; }
    }
}
