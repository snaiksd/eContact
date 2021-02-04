namespace eContact.Data.Entities.Core
{
    public class BaseEntity
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
