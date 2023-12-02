namespace DesafioFundamentos.Models
{
  public class Parking
  {
    private List<string> VehiclePlates = new List<string>();

    private decimal InitialPrice = 0;
    private decimal PricePerHour = 0;

    public Parking(decimal initialPrice, decimal pricePerHour)
    {
      this.InitialPrice = initialPrice;
      this.PricePerHour = pricePerHour;
    }

    public void AddVehicle(string vehiclePlate)
    {
      this.VehiclePlates.Add(vehiclePlate);
    }

    public void RemoveVehicle(string vehiclePlate)
    {
      if (!this.IsVehicleParked(vehiclePlate))
        throw new VehiclePlateNotFoundException("Esse Veículo não está estacionado!");
      
      this.VehiclePlates.Remove(vehiclePlate);
    }

    public List<string> GetVehiclePlates()
    {
      return this.VehiclePlates;
    }

    public bool IsVehicleParked(string vehiclePlate)
    {
      return this.VehiclePlates.Any(x => x.ToUpper() == vehiclePlate.ToUpper());
    }

    public decimal CalculatePriceToPay(int hoursParked)
    {
      return this.InitialPrice + (hoursParked * this.PricePerHour);
    }
  }
}
