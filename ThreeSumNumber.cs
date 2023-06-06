using System;

class Program
{
    static void Main()
    {
        // Gọi phương thức SumThreeNumbers và truyền vào 3 số
        int sum = SumThreeNumbers(1, 2, 3);

        // Xuất ra màn hình tổng của 3 số
        Console.WriteLine("Tổng của 3 số là: " + sum);
    }

    // Hàm để tính tổng của 3 số
    static int SumThreeNumbers(int num1, int num2, int num3)
    {
        // Tính tổng của 3 số và gán vào biến sum
        int sum = num1 + num2 + num3;

        // Trả về tổng của 3 số
        return sum;
    }
}
