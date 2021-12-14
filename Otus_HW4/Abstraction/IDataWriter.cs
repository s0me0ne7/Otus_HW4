namespace Otus_HW4.IO
{
    public interface IDataWriter
    {
        public void Write(string text);

        public void Clear();

        public void NextLine();
    }
}
