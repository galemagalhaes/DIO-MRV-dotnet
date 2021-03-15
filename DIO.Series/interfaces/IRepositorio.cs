using System.Collections.Generic;

namespace DIO.Series.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int Id);
        void Insere(T entidade);
        void Excluir(int Id);
        void Atualiza(int Id, T entidade);
        int ProximoId();

    }
}