using LiteDB;

namespace Economize.Modelos;

    public class Devedor : Registro
    {
 [BsonId]
        public int id { get; set; }
        public string Nome { get; set; }

        public string ValorDivida { get; set; }
    }
