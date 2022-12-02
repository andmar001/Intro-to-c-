using System;
using System.Collections.Generic;

//1-Validar si es usuario existente o se debe registrar
//2-El programa debe ser capa de darle la bienvenida a un usuario existente si en efecto existe
//3-Else programa debe repetirse hasta que se registren las 10 personas

namespace intro_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = new string[5] {"","", "", "", ""};
            int arrayCurrentIndex = 1; //a partir de que posicion guardar el nombre
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world");

            while (arrayCurrentIndex < 5)
            {
                Console.WriteLine("\n \nAre you a registered user? Write true, or write false to register: ");
                userType = Convert.ToBoolean(Console.ReadLine()); //conversion a valor booleano
                if (userType == true)
                {
                    Console.WriteLine("Hello you are a registered user, please enter you username");
                    string userToSearch = Convert.ToString(Console.ReadLine()); //variable inline, solo se usan una vez
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    //user in array
                    int index = Array.IndexOf(usernames, userToSearch); //buscar elemento dentro del arreglo
                    if (index == -1)//si no existe
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it is a pleasure to give you food", usernames[index]);
                    }
                }
                else if (userType == false)
                {
                    Console.WriteLine("Please write and remember you username");
                    usernames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("you user has been saved successfully \n" +"Your username is {0}", usernames[arrayCurrentIndex] );
                    arrayCurrentIndex++;//para que no se sobreescriba el valor de array current index
                }  
            }
            
            Console.WriteLine("The restaurant is full, try again next year\n These are the guest to the dinner");
            int auxIndex = 0;
            foreach (string username in usernames)
            {
                Console.WriteLine("User number {0} and username {1}", auxIndex+1, usernames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);  //sacarnos una vez termine la ejecucion
        }
    }
}
