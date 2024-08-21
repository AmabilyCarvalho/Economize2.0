using Economize.Modelos;

namespace Controles;

public class ContasAPagarControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ContasAPagarControle() : base()
  {
    NomeDaTabela = "ContasAPagar";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idContasAPagar)
  {
    var collection = liteDB.GetCollection<ContasAPagar>(NomeDaTabela);
    return collection.FindOne(d => d.id == idContasAPagar);
  }

  //----------------------------------------------------------------------------

  public virtual List<ContasAPagar>? LerTodos()
  {
    var tabela = liteDB.GetCollection<ContasAPagar>(NomeDaTabela);
    return new List<ContasAPagar>(tabela.FindAll().OrderBy(d => d.Compra));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idContasAPagar)
  {
    var collection = liteDB.GetCollection<ContasAPagar>(NomeDaTabela);
    collection.Delete(idContasAPagar);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(ContasAPagar contasAPagar)
  {
    var collection = liteDB.GetCollection<ContasAPagar>(NomeDaTabela);
    collection.Upsert(contasAPagar);
  }

  //----------------------------------------------------------------------------
}