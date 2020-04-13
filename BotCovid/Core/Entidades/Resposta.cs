namespace BotCovid.Core.Entidades
{
    public class Resposta
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public Resposta(int id, string codigo, string descricao)
        {
            Id = id;
            Codigo = codigo;
            Descricao = descricao;
        }

        public virtual bool ValidarValor(string valor)
        {
            return Codigo == valor;
        }
    }

    public class RespostaCEP: Resposta
    {
        public RespostaCEP(int id, string codigo, string descricao): base(id, codigo, descricao)
        {

        }

        public override bool ValidarValor(string valor)
        {
            if (valor == "0")
            {
                return true;
            }
            return valor.Replace("-","").Replace(".","").Length == 8;
        }
    }
}