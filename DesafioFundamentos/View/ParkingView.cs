using System.Diagnostics;
using DesafioFundamentos.Models;

namespace DesafioFundamentos.View
{
  public class ParkingView
  {
    private Parking parking;

    public ParkingView(decimal initialPrice, decimal finalPrice)
    {
      this.parking = new Parking(initialPrice, finalPrice);
    }

    public void AddVehicle()
    {
      string vehiclePlate;

      Console.Write("Digite a placa do veículo para estacionar: ");
      vehiclePlate = Console.ReadLine();

      this.parking.AddVehicle(vehiclePlate);
    }

    public void RemoveVehicle()
    {
      string vehiclePlate;

      Console.Write("Digite a placa do veículo para remover: ");
      vehiclePlate = Console.ReadLine();

      try
      {
        this.parking.RemoveVehicle(vehiclePlate);
      }
      catch(VehiclePlateNotFoundException e)
      {
        Console.WriteLine(e.Message);
      }
      
      Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
      int hoursParked = int.Parse(Console.ReadLine());

      decimal priceToPay = this.parking.CalculatePriceToPay(hoursParked);
      Console.WriteLine($"O veículo {vehiclePlate} foi removido e o preço total foi de: {priceToPay:C}");
    }

    public void ListVehicles()
    {
      List<string> vehiclePlates = this.parking.GetVehiclePlates();

      if (vehiclePlates.Count == 0)
        Console.WriteLine("Não há veículos estacionados.");
      else
      {
        foreach (var vehiclePlate in vehiclePlates)
          Console.WriteLine($"{vehiclePlate} Estacionado!");
      }
    }
  }
}