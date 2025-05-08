namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Another Hello from Us\n");

            const double PI = 3.14;
            const double PIN = Math.PI;
            double radius = 1.5;

            radius = 22.5;

           // PI = 1.5;
            double area = PI * radius * radius; 
            Console.WriteLine("The area of the circle for radius "
                + radius + " is "+area);

            Console.Write("Enter the value for the Radius of the Circle: ");
            double radiusInput = double.Parse(Console.ReadLine());
            //double radii = (double)(Console.ReadLine());
            area = PI * radiusInput * radiusInput;
            int castInt = (int)radius;
            Console.WriteLine("The area of the circle for radius "
                + radiusInput + " is " + area);
            //Python radius = (int)(input("Enter the value:"))
            //Scanner input = new Scanner(System.in);
            //double radius = input.nextDouble();
        }
    }
}
