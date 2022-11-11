//using ETicaretAPI.Application.Services;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ETicaretAPI.Infrastructure.Services
//{
//    public class FileService : IFileService
//    {
//        readonly IWebHostEnvironment _webHostEnvironment;

//        public FileService(IWebHostEnvironment webHostEnvironment)
//        {
//            _webHostEnvironment = webHostEnvironment;
//        }

//        public async Task<bool> copyFileAsync(string path, IFormFile files)
//        {
//            try
//            {
//                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
//                await files.CopyToAsync(fileStream);
//                await fileStream.FlushAsync();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                //todo log
//                throw ex;
//            }

//        }

//        //async Task<string> FileRenameAsync(string path, string fileName)
//        //{   
//        //    await Task.Run(async())=>
//        //        {
//        //        string extention = Path.GetExtension(fileName);
//        //        string oldName = Path.GetFileName(fileName);
//        //        string newName = $"{NameOperaion}"
//        //    });

//        //}

//        //public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
//        //{
//        //    string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
//        //    if (!Directory.Exists(uploadPath))
//        //        Directory.CreateDirectory(uploadPath);

//        //    List<(string fileName, string path)> datas = new();
//        //    List<bool> results = new();
//        //    foreach (IFormFile file in files)
//        //    {
                
//        //        string fileNewName= await FileRenameAsync(file.FileName);

//        //        bool result= await copyFileAsync($"{uploadPath}\\{fileNewName}", file);
//        //        datas.Add((fileNewName, $"{uploadPath}\\{fileNewName}"));
//        //        results.Add(result);
//        //    }

//        //    if (results.TrueForAll(r => r.Equals(true)))
//        //        return datas;

//        //    //Todo if geçerli değilse dosyaların sunucuda yüklenirken hata alındığına dair bir exeption oluşturulup fırlatılmalı.
//        //    return null; 
//        //}

//        Task<List<(string fileName, string path)>> IFileService.UploadAsync(string path, IFormFileCollection files)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
