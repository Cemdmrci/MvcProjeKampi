﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous] //Burayı muaf tutmuş olurum

    public class LoginController : Controller
    {
        WriterLoginManager wm = new WriterLoginManager(new EfWriterDal());
        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminuserinfo = context.Admins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName; //Session oturum yönetme
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
            [HttpGet]
            public ActionResult WriterLogin()
            {
                return View();
            }
            [HttpPost]
            public ActionResult WriterLogin(Writer writer)
            {
                //Context context = new Context();
                //var writeruserinfo = context.Writers.FirstOrDefault(x =>x.WriterMail  == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
                var writeruserinfo = wm.GetWriter(writer.WriterMail, writer.WriterPassword);
                if (writeruserinfo != null)
                {
                    FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
                    Session["WriterMail"] = writeruserinfo.WriterMail;
                    return RedirectToAction("MyContent", "WriterPanelContent");
                }
                else
                {
                    return RedirectToAction("WriterLogin");
                }

            }
            public ActionResult LogOut()
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
                return RedirectToAction("Headings", "Default");
            }
        }

    }