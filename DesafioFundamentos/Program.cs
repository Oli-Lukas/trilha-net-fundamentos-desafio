﻿using DesafioFundamentos.View;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
ParkingView parking = new ParkingView(initialPrice, pricePerHour);

string option   = string.Empty;
bool   showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
  {
    case "1":
      parking.AddVehicle();
      break;

    case "2":
      parking.RemoveVehicle();
      break;

    case "3":
      parking.ListVehicles();
      break;

    case "4":
      showMenu = false;
      break;

    default:
      Console.WriteLine("Opção inválida");
      break;
  }

  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
