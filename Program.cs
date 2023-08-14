using System;

namespace TPFinal_Trejo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            // A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no
            //  y que devuelva true o false según corresponda.

            int n1, MayorPar=0, ContImpar=0, MenorPrimo=0;
            bool Bpar = false, Bprimo = false;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            
            while (n1 != 0){
                
                if(par(n1)){
                    if (Bpar){
                        MayorPar = n1;
                        Bpar = true;
                    }else{
                        if (n1 > MayorPar){
                            MayorPar = n1;
                        }
                    }
                }else{
                    ContImpar++;
                }

                if (primo(n1)){
                    if (Bprimo == false){
                        MenorPrimo = n1;
                        Bprimo = true;
                    }else{
                        if (n1 < MenorPrimo){
                            MenorPrimo = n1;
                        }
                    }
                }

                Console.WriteLine("Ingrese otro numero o cero para terminar");
                n1 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("El mayor de los numeros pares introducido es el " + MayorPar);
            Console.WriteLine("El numero total de numeros impares ingresados es de " + ContImpar);
            Console.WriteLine("El menor de los numeros primos metidos es el " + MenorPrimo);

            Console.WriteLine("Fin del programa!!!!!!!!!!");

        }
        static bool par (int n1){
            if (n1%2 == 0)
                return true;
            else
                return false;
        }
        static bool primo(int n1){
            int cont = 0;
            for (int x = 1; x <= n1; x++){
                if(n1%x == 0)
                    cont++;
            }
            if (cont == 2){
                return true;
            }else{
                return false;
            }
        }
    }
}
