using AdaFood.Models;
using AdaFood.RequestModels;

namespace AdaFood.Repositorio
{
    public interface IEntregadorRepository
    {
        public List<Entregador> GetAll();
        public void Add(EntregadorRequest entregador);

        public Entregador GetByCPF(string cpf);

    }
}
