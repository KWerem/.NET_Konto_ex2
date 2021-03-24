using System;

namespace Konto
{
    class Account
    {
        private String _User;
        private String _Number;
        private String _Login;
        private String _Password;
        private bool logged;
        private double saldo = 1275;
        //private String pass2;

        //private double wplata = 0;
        //private double wyplata = 0;



        public Account(String user, String num, String log, String pass)
        {
            _User = user; 
            _Number = num; 
            _Password = pass;
            _Login = log;
        }

        public void Zaloguj(String log, String pass)
        {
            if ((_Login == log) && (_Password == pass)) { logged = true; }
        }

        public void Wyloguj()
        {
            if (logged == true)
            {
                logged = false;
                Console.WriteLine("\nWylogowano użytkownika: " + _User + " o numerze: " + _Number + " - stan zalogowania: " + logged);
            }
        }
        public double Wpłać(double wplata)
        {
            if (logged == true)
            {
                saldo = saldo + wplata;

                Console.WriteLine("\nWpłacono: " + wplata + "\nStan konta: " + saldo);
            }
            else { Console.WriteLine("\nUzytkownik niezalogowany!"); } 
            return saldo;
        }

        public double Wypłać(double wyplata)
        {
            if (logged == true)
            {
                saldo = saldo - wyplata;

                Console.WriteLine("\nWypłacono: " + wyplata + "\nStan konta: " + saldo);
            }
            else { Console.WriteLine("\nUzytkownik niezalogowany!"); }
            return saldo;
        }

        public void ZmieńHasło(String pass2)
        {
            if (logged == true)
            {
                _Password = pass2;

                Console.WriteLine("\nZmiana hasła zakończona sukcesem! Zaloguj się ponownie z nowymi poświadczeniami!");
                logged = false;
            }
            else { Console.WriteLine("\nUzytkownik niezalogowany!"); }
        }

        public override String ToString()
        {
            return "\nUżytkownik konta: " + _User + " o numerze: " + _Number +
            " posiada na koncie " + saldo + " stan zalogowania: "+logged;
        }
    }
}
