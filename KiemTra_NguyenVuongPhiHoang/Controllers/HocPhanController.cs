using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTra_NguyenVuongPhiHoang.Models;

namespace KiemTra_NguyenVuongPhiHoang.Controllers
{
    public class HocPhanController : Controller
    {
        DataDataContext data = new DataDataContext();
        // GET: HocPhan
        public ActionResult ListHocPhan()
        {
            var all_hocphan = from hp in data.HocPhans select hp;
            return View(all_hocphan);
        }
    }
}