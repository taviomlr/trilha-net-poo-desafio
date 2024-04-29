using System.ComponentModel;
using DesafioPOO.Models;

System.Console.WriteLine("\n");
System.Console.WriteLine("*************************************************************************");
System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(81) 9.9999-9999", modelo: "C3", imei: "121554548878", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagran");
System.Console.WriteLine("*************************************************************************");
System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(81) 9.8888-8888", modelo: "10", imei: "2254555666", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");
System.Console.WriteLine("*************************************************************************");
System.Console.WriteLine("\n");


