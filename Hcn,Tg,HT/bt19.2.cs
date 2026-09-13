using System;

class HinhTron
{
    public double r;

    public double DienTich()
    {
        return Math.PI * r * r;
    }
}

class HinhTamGiac
{
    public double a, b, c;

    public double ChuVi()
    {
        return a + b + c;
    }
}

class HinhChuNhat
{
    public double dai, rong;

    public double DienTich()
    {
        return dai * rong;
    }
}

class Program
{
    static void Main()
    {
        HinhTron tron = new HinhTron();
        tron.r = 5;
        Console.WriteLine("Dien tich hinh tron: " + tron.DienTich());

        HinhTamGiac tamgiac = new HinhTamGiac();
        tamgiac.a = 3;
        tamgiac.b = 4;
        tamgiac.c = 5;
        Console.WriteLine("Chu vi tam giac: " + tamgiac.ChuVi());

        HinhChuNhat chunhat = new HinhChuNhat();
        chunhat.dai = 10;
        chunhat.rong = 5;
        Console.WriteLine("Dien tich chu nhat: " + chunhat.DienTich());
    }
}
