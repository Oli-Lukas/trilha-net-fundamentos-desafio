using System;

public class VehiclePlateNotFoundException : Exception
{
  public VehiclePlateNotFoundException(string message): base(message)
  {}
}