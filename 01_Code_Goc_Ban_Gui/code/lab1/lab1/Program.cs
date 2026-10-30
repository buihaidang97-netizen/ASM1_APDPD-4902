String Myname = "Hai Dang";
int Age = 20;
String MyAddess = "Ha Noi";
if (Age > 18)
{
    Console.WriteLine("Ban con qua tre.");
}
else if (Age > 26)
{
    Console.WriteLine("Ban da truong thanh.");
}
else
{
    Console.WriteLine("Ban dang o do tuoi dep nhat");
}
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Gia tri cua i la: {i}");
}
int j = 1;
while (j <= 5)
{
    Console.WriteLine($"Gia tri cua j la: {j}");
    j++;
}

//**************//
// to chuc chuong trinh thanh cac ham con (module) de giai quyet van de
// co the tai su dung ham (function) 
// vi du: vir ham tinh tong 2 so nguyen

int SumNumbers(int a, int b)
{
    return a + b;
}
// int: yeu cau ham tra ve kieu du lieu la so nguyen trung binh
//SumNumbers: ten ham do LTV tu dinh nghia
// (int a, int b): tham so dau vao cua ham do LTV tu dinh nghia
// return a + b: yeu cau ham tra ve gia tri tong cua 2 so nguyen a va b
// goi ham ra su dung
int result = SumNumbers(5, 10);
Console.WriteLine($"Tong cua 5 va 10 la: {result}"); 
// viet ham in ra loi chao theo cac ngon ngu khac nhau 
void SayHello(string message)
{
    Console.WriteLine(message);
}

// void: khong dung tu khoa return tra du lieu ve cho ham 
// goi ham ra su dung
SayHello("Xin chao cac ban!");
SayHello("Hello everyone!");
// viet ham kiem tra 1 nam duong lich co phai la nam nhuan hay khong
bool IsLeapYear(int year)
{
    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool checkingLeapYear = IsLeapYear(2028);
if (checkingLeapYear)
{
    Console.WriteLine("Nam 2020 la nam nhuan.");
}
else
{
    Console.WriteLine("Nam 2020 khong phai la nam nhuan.");
}
