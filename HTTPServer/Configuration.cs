﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    static class Configuration
    {
        public static string ServerHTTPVersion = "HTTP/1.1";
        public static string ServerType = "FCISServer";
        public static Dictionary<string, string> RedirectionRules = new Dictionary<string, string>();
        public static string RootPath = "E:\\Collage projects\\HTTP Server\\webpages";
        public static string RedirectionDefaultPageName = "/Redirect.html";
        public static string BadRequestDefaultPageName = "/BadRequest.html";
        public static string NotFoundDefaultPageName = "/NotFound.html";
        public static string InternalErrorDefaultPageName = "/InternalError.html";
        public static string[] message = new string[100];
        public static int count = 0;
    }
}
