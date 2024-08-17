using DesafioPOO.Models;

Iphone iphone = new Iphone("iphone 1");
Nokia nokia = new Nokia("Nokia 1");


iphone.Ligar();
iphone.InstalarAplicativo("Duolingo");
iphone.ReceberLigacao();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tijolão");

