using System;
class Program
{
public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    // Getter
    public DateTime StartTime => startTime;
    public DateTime EndTime => endTime;

    // Constructor không tham số
    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Start()
    public void Start()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Stop()
    public void Stop()
    {
        endTime = DateTime.Now;
    }

    // Phương thức tính thời gian trôi qua
    public long GetElapsedTime()
    {
        return (long)(endTime - startTime).TotalMilliseconds;
    }
}

    static void Main(string[] args)
    {
        // Tạo mảng 100,000 phần tử số ngẫu nhiên
        int size = 100000;
        int[] numbers = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1, 1000000);
        }

        // Tạo stopwatch
        StopWatch sw = new StopWatch();
        sw.Start(); // Bắt đầu đo

        // Thực hiện selection sort
        SelectionSort(numbers);

        sw.Stop(); // Dừng đồng hồ

        // Hiển thị thời gian đã trôi qua
        Console.WriteLine("Thời gian thực thi Selection Sort cho 100,000 phần tử là: " + sw.GetElapsedTime() + " milliseconds");
    }

    // Thuật toán Selection Sort
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Hoán đổi
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
