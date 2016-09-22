namespace ItWorks.Web.Logic
{
    using CL;
    using Common;

    using Models;

    public class DocumentLogic
    {
        public string ProcessDocument(DocumentViewModel model)
        {
            switch (model.DocumentType)
            {
                case DocumentTypes.QuickDocument:
                    var quickDocument = new QuickDocument
                    {
                        Name = model.Name,
                        Content = model.Content
                    };
                    return quickDocument.PrintString();
                case DocumentTypes.StandardDocument:
                    var standardDocument = new StandardDocument
                    {
                        Name = model.Name,
                        Content = model.Content,
                        NumberOfCopies = model.NumberOfCopies
                    };
                    return standardDocument.PrintString();
                case DocumentTypes.SlowDocument:
                    var slowDocument = new SlowDocument
                    {
                        Name = model.Name,
                        Content = model.Content,
                        NumberOfCopies = model.NumberOfCopies
                    };
                    return slowDocument.PrintString();
                default:
                    return "Error processing document";
            }
        }
    }
}
