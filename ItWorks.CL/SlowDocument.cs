namespace ItWorks.CL
{
    using System.IO;

    using Base;

    public class SlowDocument : Document
    {
        public int NumberOfCopies { get; set; }

        public int Delay { get; set; } = 5;

        public override MemoryStream Print()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    for (var x = 0; x < NumberOfCopies; x++)
                    {
                        streamWriter.WriteLine($"{Name}: {Content}");

                        System.Threading.Thread.Sleep(1000 * Delay);
                    }

                    streamWriter.Flush();
                }

                return memoryStream;
            }
        }
    }
}