﻿class Program{
    
    static void Main(string[] args){
        int[] vector = new int[5];
        Vector v = new Vector();

        v.vec(vector);

        string palabra = "hola";
        Console.WriteLine($"La palabra {palabra} al reves es: {v.palabraAlReves(palabra)}");

        string palabra2 = "holaalo";

        if(v.capicua(palabra2)){
            Console.WriteLine("es");
        }else{
            Console.WriteLine("no es");
        }

        Console.WriteLine(v.rellenoEntre(palabra));

    }
}
