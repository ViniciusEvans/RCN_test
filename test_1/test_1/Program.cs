using System;
using System.Collections.Generic;

namespace Hello_world
{
    internal class Program

    {
        static List<Veiculo> veiculos;
        static void Main(string[] args)
        {
            veiculos = new List<Veiculo>(); 
            veiculos.Add(new Veiculo("voyage", "carro"));
            veiculos.Add(new Veiculo("uno", "carro"));
            veiculos.Add(new Veiculo("savero", "carro"));
            veiculos.Add(new Veiculo("marea", "carro"));
            veiculos.Add(new Veiculo("Yamaha MT-09", "moto"));
            veiculos.Add(new Veiculo("Honda CB 100R", "moto"));
            veiculos.Add(new Veiculo("Ducati Diavel", "moto"));
            veiculos.Add(new Veiculo("Caloi Andes", "bicicleta"));
            veiculos.Add(new Veiculo("Houston Foxer Hammer", "bicicleta"));
            veiculos.Add(new Veiculo("Aluminum Raider", "bicicleta"));


            Moto moto = new Moto();
            Carro carro = new Carro();
            Bicicleta bicicleta = new Bicicleta();

            veiculos.ForEach(delegate (Veiculo veiculo)
            {
                if (veiculo.Tipo == "carro")
                {
                    Console.WriteLine(carro.Emplacar(veiculo.Nome));
                    Console.WriteLine(carro.LigarMotor(veiculo.Nome));
                    Console.WriteLine(carro.Acelerar(veiculo.Nome));
                    Console.WriteLine(carro.Frear(veiculo.Nome));
                    return;
                }
                if (veiculo.Tipo == "moto")
                {
                    Console.WriteLine(moto.Emplacar(veiculo.Nome));
                    Console.WriteLine(moto.LigarMotor(veiculo.Nome));
                    Console.WriteLine(moto.Acelerar(veiculo.Nome));
                    Console.WriteLine(moto.Frear(veiculo.Nome));
                    return;
                }

                Console.WriteLine(bicicleta.Acelerar(veiculo.Nome));
                Console.WriteLine(bicicleta.Frear(veiculo.Nome));
                return;
            });
        }
            
    }
}
