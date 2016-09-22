namespace ItWorks.CL
{
    using System.IO;

    using Base;

    public class StandardDocument : Document
    {
        public int NumberOfCopies { get; set; }

        public override MemoryStream Print()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    for (var x = 0; x < NumberOfCopies; x++)
                    {
                        streamWriter.WriteLine($"{Name}: {Content}");
                    }

                    streamWriter.Flush();
                }

                return memoryStream;
            }
        }
    }
}