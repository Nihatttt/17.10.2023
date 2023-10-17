using System;

public class Car
{
    private string model;
    private int topspeed;
    private double engine;
    private double km;
    private int hp;

    public string Model
    
    {
        get { return model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 10)
            {
                Console.WriteLine("Error: Model adı boş ola bilməz və maksimum uzunluq 10 ola bilər.");
            }
            else
            {
                model = value;
            }
        }
    }

    public int TopSpeed
    {
        get { return topspeed; }
        set
        {
            if (value < 10 || value > 1000)
            {
                Console.WriteLine("Error: Top Speed minimum 10 və maksimum 1000 ola bilər.");
            }
            else
            {
                topspeed = value;
            }
        }
    }

    public int topSpeed
    {
        get { return topSpeed; }
        set
        {
            if (value < 10 || value > 1000)
            {
                Console.WriteLine("Error: Top Speed minimum 10 və maksimum 1000 ola bilər.");
            }
            else
            {
                topSpeed = value;
            }
        }
    }

    public double Km
    {
        get { return km; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: Km minimum 0 ola bilər.");
            }
            else
            {
                km = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            bmw.Model = "X5";
            bmw.TopSpeed = 280;
            bmw.engine = 3;
            bmw.Km = 280000;
            bmw.hp = 303;
            bmw.IsMpower = true;

            Mercedes mercedes = new Mercedes();
            mercedes.Model = "G 63";
            mercedes.TopSpeed = 370;
            mercedes.engine = 4;
            mercedes.Km = 0;
            mercedes.hp = 585;
            mercedes.IsAmg = true;
        }
    }


