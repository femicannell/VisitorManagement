using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorManagement.Business
{
    public class TextFileOperations : ITextFileOperations
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TextFileOperations(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<string> LoadConditionsText()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            FileInfo filepath = new FileInfo(Path.Combine(webRootPath, "ConditionsOfEntry.txt"));
            string[] lines = System.IO.File.ReadAllLines(filepath.ToString());
            return lines.ToList();
        }
    }
}
