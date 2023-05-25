using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine(Litres(11.80));

static int Litres(double time){
    int zips = (int) Math.Floor(time*0.5);
    return zips;
}
