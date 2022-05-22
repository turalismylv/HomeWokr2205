using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Users istifadeci1 = new Users
            {
                name = "Nurlan",
                 Password = "123Nurlan!123"
            };
            Users istifadeci2 = new Users
            {
                name = "Nurlan",
                Password = "mammadov_n"

            };
            Users istifadeci3 = new Users
            {
                name = "Nurlan",
                Password = "123mammadov123"

            };
            Console.WriteLine(istifadeci1.IsPasswordValid());
            Console.WriteLine(istifadeci2.IsPasswordValid());
            Console.WriteLine(istifadeci3.IsPasswordValid());
        }
        class Users
        {

            public string name;
            public string Password;


            public bool IsPasswordValid()
            {
                if (Size() == true && Numvar() == true && NamePsw()==true )
                {
                    return true;
                }
                return false;
            }
            public bool Size()
            {
                if (Password.Length < 6)
                {
                    return false;
                }
                return true;
            }
            public bool Numvar()
            {
                string num = "0123456789";
                for (int i = 0; i < Password.Length; i++)
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (Password[i] == num[j])
                        {
                            return true;
                        }

                    }
                }
                return false;
            }

            public bool NamePsw()
            {
                string b = "";
                for (int i = 0; i < Password.Length; i++)
                {

                    for (int j = 0; j < name.Length; j++)
                    {

                        if (Password[i] == name[j])
                        {

                            b += Password[i];
                            break;
                        }
                        else if (b == name)
                        {
                            return false;
                            
                        }

                    }

                }
                return true;
            }

        }

    }
}

