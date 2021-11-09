using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider: Concept
    {
        private string password;
        private string confirmPassword;



        public static void SetIsApproved(out bool x, Provider p)
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

        public static void SetIsApproved(string password, string confirmPassword, out bool isApproved)
        {
            isApproved = password == confirmPassword;
        }

        //public bool Login(string password, string username)
        //{            
        //    return this.password == password && this.UserName == username;            
        //}
        public bool Login(string password, string username, string email=null)
        {
            if (email == null)
                return this.password == password && this.UserName == username;
            else
                return this.password == password && this.UserName == username && this.Email==email;
        }

        public void Max(params int[] list)
        {
            foreach (var i in list)
            {
                Console.WriteLine("***"+i);
            }
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
        public IList<Product> Products { get; set; }



        public IEnumerable<Product> GetProducts(string filterType, string filterValue)
        {
           // IList<Product> list = new List<Product>();
            foreach (var item in Products)
            {
                //    switch (filterType)
                //    {
                //        case "DateProd":
                //            DateTime x;
                //            DateTime.TryParse(filterValue, out x);
                //            if (item.DateProd == x)
                //            {
                //                list.Add(item);
                //            }
                //            break;
                //        case "Price":
                //            double y;
                //            double.TryParse(filterValue, out y);
                //            if (item.Price == y)
                //            {
                //                list.Add(item);
                //            }
                //            break;

                //    }


                if (filterType == "DateProd")
                {
                    DateTime x;
                    DateTime.TryParse(filterValue, out x);
                    if (item.DateProd == x)
                    {
                        yield return item;
                    }
                }

                if (filterType == "Price")
                {
                    double x;
                    double.TryParse(filterValue, out x);
                    if (item.Price == x)
                    {
                        yield return item;
                    }
                }

            }

            yield return null;
        }

        public override void GetDetails()
        {
            //Console.WriteLine
            //    ("Username= " + UserName+ " Email= "+ Email + " DateCreation = " + DateCreation);
            Console.WriteLine($"Username {UserName} Email = {Email}  DateCreation = {DateCreation}");
            Console.WriteLine("Liste products");
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
