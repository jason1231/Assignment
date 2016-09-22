namespace ItWorks.CL.Base
{
    using System.IO;

    public abstract class Document
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public virtual MemoryStream Print()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    streamWriter.Write($"{Name}: {Content}");

                    streamWriter.Flush();
                }

                return memoryStream;
            }
        }

        public string PrintString()
        {
            return System.Text.Encoding.UTF8.GetString(Print().ToArray());
        }
    }
}
