using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string _currentDirectory = Environment.CurrentDirectory + @"\wwwroot";
        public static string _imagesDirectory = @"\Images\";
        public static string _defaultLogoPath = _currentDirectory + _imagesDirectory + "defaultLogo.png";
        public static IResult Add(IFormFile file)
        {
            string path = _defaultLogoPath;
            CheckDirectory();

            if (file != null)
            {
                var fileType = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid().ToString();
                path = _currentDirectory + _imagesDirectory + imageName + fileType;
                using (FileStream fs = File.Create(path))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                    return new SuccessResult(path);
                }
            }
            return new SuccessResult(path);
        }

        public static IResult Update(string oldImagePath, IFormFile file)
        {
            //CheckDirectory();
            DeleteOldFile(oldImagePath);

            return Add(file);
        }

        public static IResult Delete(string path)
        {
            if (!File.Exists(path))
            {
                return new ErrorResult();
            }

            File.Delete(path);
            return new SuccessResult();
        }

        private static void CheckDirectory()
        {
            if (!Directory.Exists(_currentDirectory + _imagesDirectory))
            {
                Directory.CreateDirectory(_currentDirectory + _imagesDirectory);
            }
        }

        private static void DeleteOldFile(string path)
        {
            File.Delete(path);
        }
    }
}
