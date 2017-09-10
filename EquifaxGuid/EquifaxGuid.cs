namespace Equifax
{
    public static class Guid
    {
        public static System.Guid NewGuid ()
        {
            // use UTC so IDs are globally consistent (greater uniqueness)
            var t = System.DateTime.UtcNow;
            return new System.Guid(
                "00000000-0000-0000-0000-00" +
                $"{t.Month:00}{t.Day:00}{t.Year % 100:00}{t.Hour:00}{t.Minute:00}");
        }
    }
}