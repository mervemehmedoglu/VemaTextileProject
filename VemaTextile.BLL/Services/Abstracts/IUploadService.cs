using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VemaTextile.BLL.Services.Abstracts
{
    public interface IUploadService
    {
        //string Upload(HttpPostedFileBase file);
        string Upload(HttpPostedFileBase file, int width, int height);
    }
}
