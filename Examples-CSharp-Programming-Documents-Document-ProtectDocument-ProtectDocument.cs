// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Document doc = new Document(inputFileName);
doc.Protect(ProtectionType.AllowOnlyFormFields, "password");
Console.WriteLine("\nDocument protected successfully.");
