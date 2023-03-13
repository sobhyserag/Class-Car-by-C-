using System;
using System.Linq;

namespace Task_1_OOP;
public class car {
// Attributes
public string make;
public string model;
public int year;
public double price;
public bool is_Electric;
public bool is_Automatic;
public int num_of_doors;
public string color;

// Constructors
public car()
{
	make = "";
	model = "";
	year = 0;
	price = 0.0;
	is_Electric = false;
	is_Automatic = false;
	num_of_doors = 0;
	color = "";
}
public car(string make,string model,int year)
{
	this.make=make;
	this.model=model;
	this.year=year;
}
public car(string make,string model,int year,double price)
{
	this.make=make;
	this.model=model;
	this.year=year;
	this.price=price;
}
public car(string make,string model,int year,double price,bool is_Electric)
{
	this.make=make;
	this.model=model;
	this.year=year;
	this.price=price;
    this.is_Electric=is_Electric;
}
public car(string make,string model,int year,double price,bool is_Electric,bool is_Automatic)
{
	this.make=make;
	this.model=model;
	this.year=year;
	this.price=price;
    this.is_Electric=is_Electric;
	this.is_Automatic=is_Automatic;
}

public car(string make,string model,int year,double price,bool is_Electric,bool is_Automatic,int num_of_doors,string color)
{
	this.make=make;
	this.model=model;
	this.year=year;
	this.price=price;
    this.is_Electric=is_Electric;
	this.is_Automatic=is_Automatic;
	if(num_of_doors>0 && num_of_doors<7)
	{
		this.num_of_doors=num_of_doors;
	}
	else
	{
		Console.WriteLine("Invalid number of doors beacuse the defualt number of door = 4");
		num_of_doors=4;
	}
	if(color!="")
	{
		this.color=color;
	}
	else
	{
		Console.WriteLine("Invalid color");
		color = "black"; //defualt color
	}
}
   //Methods
   public void StartEngine()
   {
   	Console.WriteLine("The car engine has started");
   }
   public void StopEngine()
   {
   	Console.WriteLine("The car engine has stoped");
   }
   public void brake()
   {
   	Console.WriteLine("The car is braking");
   }
   public void broke()
   {
   	Console.WriteLine("The car is broken");
   }
   public void turnleft()
   {
   	Console.WriteLine("The car is turned left");
   }
   public void turnright()
   {
   	Console.WriteLine("The car is turned right");
   }

public static class Program
 {
	public static void Main()
	{

	} 
 }