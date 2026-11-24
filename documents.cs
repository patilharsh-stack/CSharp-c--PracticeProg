//using System;
//using System.IO;

//public interface IUpload
//{
//    void Upload(string path);
//}

//public interface IDelete
//{
//    void Delete(string path);
//}

//public interface IValidate
//{
//    bool Validate(string path);
//}
//public class DocumentService : IUpload, IDelete, IValidate
//{
//    public void Upload(string path)
//    {
//        Console.WriteLine("Document Uploaded Successfully");
//    }

//    public void Delete(string path)
//    {
//        if (File.Exists(path))
//        {
//            File.Delete(path);
//            Console.WriteLine("Document Deleted Successfully");
//        }
//    }

//    public bool Validate(string path)
//    {
//        return File.Exists(path);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        DocumentService doc = new DocumentService();

//        string path = @"C:\Test\Aadhar.pdf";

//        if (doc.Validate(path))
//        {
//            doc.Upload(path);
//            doc.Delete(path);
//        }
//        else
//        {
//            Console.WriteLine("Document Not Found");
//        }
//    }
//}




////using System;

////class UploadService
////{
////    public void Upload()
////    {
////        Console.WriteLine("Document Uploaded");
////    }
////}

////class DeleteService
////{
////    public void Delete()
////    {
////        Console.WriteLine("Document Deleted");
////    }
////}

////// This is INVALID in C#
////class DocumentService : UploadService, DeleteService
////{
////}