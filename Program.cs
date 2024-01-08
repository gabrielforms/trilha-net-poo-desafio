﻿using DesafioPOO.Models;

class Program
{
    static void Main() 
    {
        Nokia nokiaPhone = new Nokia(numero: "95012001", modelo: "Nokia GC60", imei: "IMEI2011", memoria: 256);
        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();
        nokiaPhone.InstalarAplicativo("Github");

        Iphone iphone = new Iphone("88912419", "iPhone 14", "IMEI5512", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("StackOverflow");
    }

}