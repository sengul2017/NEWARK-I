using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWARK_I
{
    class CtrlIds
    {
        // LOGIN VARIABLES
        public static string id_login = "loginLink";
        public static string id_username = "Email";
        public static string id_password = "Password";
        public static string xpath_loginbtn = "//html/body/section/div/div/div/div/form/button";

        //LOGOUT
        public static string linktxt_logout = "Log Out";

        //ADVANCED JOB SEARCH
        public static string linktxt_Ajs = "ADVANCED JOB SEARCH";
        public static string id_searchfor = "with_all_of_these_words";
        public static string xpath_findjobs = "//html/body/div[1]/div/div/div/form/div[10]/div/input";


        //JSA
        public static string linktxt_jsa = "JSA";
        public static string xpath_createNew = "/html/body/div/p/a";
        public static string id_emailadd = "EmailAddress";
        public static string id_keywords = "Keywords";
        public static string name_kwOption = "KeywordOption";
        public static string name_zip = "ZipCode";
        public static string name_radius = "Miles";
        public static string xpath_active = "//html/body/form/div/div/div/div/div[6]/div[2]/label";
        public static string xpath_createBtn = "//html/body/form/div/div/div/div/div[7]/div[1]/div/input";
        public static string xpath_delete = "//*[@id='example']/tbody/tr/td[5]/a[3]/i";
        public static string xpath_deleteYes = "//html/body/div/div/div/div/form/div/div[1]/div/input";
    }
}
