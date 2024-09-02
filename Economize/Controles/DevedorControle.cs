using Economize.Modelos;

namespace Controles;

public class DevedorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public DevedorControle() : base()
  {
    NomeDaTabela = "Devedor";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idDevedor)
  {
    var collection = liteDB.GetCollection<Devedor>(NomeDaTabela);
    return collection.FindOne(d => d.id == idDevedor);
  }

  //----------------------------------------------------------------------------

  public virtual List<Devedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Devedor>(NomeDaTabela);
    return new List<Devedor>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idDevedor)
  {
    var collection = liteDB.GetCollection<Devedor>(NomeDaTabela);
    collection.Delete(idDevedor);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Devedor d)
  {
    var collection = liteDB.GetCollection<Devedor>(NomeDaTabela);
    collection.Upsert(d);
  }

  //----------------------------------------------------------------------------
}