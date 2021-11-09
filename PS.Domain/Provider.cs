using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider
    {
        private string password;
        private string confirmPassword;



        public static void SetIsApproved(bool x, Provider p)
        {
            //p.IsApproved = p.ConfirmPassword == p.password ? true : false;
            x = p.ConfirmPassword.Equals( p.password);
            Console.WriteLine("+++ "+x);
            //if (p.ConfirmPassword == p.password)
            //{
            //    p.IsApproved = true;
            //}
            //else
            //{
            //    p.IsApproved = false;
            //}
        }
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value.Equals( Password))
                {
                    confirmPassword = value;
                }
                else { Console.WriteLine("confirmPassword!=password"); }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value?.Length >= 5 && value?.Length < 20)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password >20");
                }
            }
        }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
