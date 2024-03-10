using Entity.Interface;

namespace DAL
{
    public class dbRepository<T> where T : class, IEntityBase, new()
    {
        public static List<T> listAll() => dbEntities.get.Set<T>().ToList();

        public static T get(Guid ide) => dbEntities.get.Set<T>().FirstOrDefault(i => i.Ide.Equals(ide)) ?? new T();

        public static void delete(Guid ide)
        {
            T obj = get(ide);
            obj.Status = -1;

            dbEntities.get.SaveChanges();
        }

        public static T update(T newObj)
        {
            T obj = get(newObj.Ide);
            dbEntities.get.SaveChanges();
            return obj;
        }
    }
}
