namespace System.Data.Entity
{
    internal class EntitySate
    {
        private static EntityState modified;

        internal static EntityState Modified { get => modified; set => modified = value; }
    }
}