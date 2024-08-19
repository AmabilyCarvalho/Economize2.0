using Economize.Modelos;

namespace Controles;

public class AReceberControle : BaseControle
{
  //----------------------------------------------------------------------------

  public AReceberControle() : base()
  {
    NomeDaTabela = "AReceber";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idAReceber)
  {
    var collection = liteDB.GetCollection<AReceber>(NomeDaTabela);
    return collection.FindOne(d => d.id == idAReceber);
  }

  //----------------------------------------------------------------------------

  public virtual List<AReceber>? LerTodos()
  {
    var tabela = liteDB.GetCollection<AReceber>(NomeDaTabela);
    return new List<AReceber>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idAReceber)
  {
    var collection = liteDB.GetCollection<AReceber>(NomeDaTabela);
    collection.Delete(idAReceber);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(AReceber areceber)
  {
    var collection = liteDB.GetCollection<AReceber>(NomeDaTabela);
    collection.Upsert(areceber);
  }

  //----------------------------------------------------------------------------
}