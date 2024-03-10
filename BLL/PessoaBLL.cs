using Entity;
using DAL;

namespace BLL
{
    public class PessoaBLL
    {
        public static List<Pessoa> list()
        {
            return PessoaDAL.listAll();
        }

        public static Pessoa get(Guid ide)
        {
            return PessoaDAL.get(ide);
        }
    }
}
