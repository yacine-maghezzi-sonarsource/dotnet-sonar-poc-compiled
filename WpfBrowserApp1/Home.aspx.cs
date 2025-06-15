using System;


public partial class Home : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "=== Math Demo Output ===";

        int a = 10;
        int b = 5;
        double x = 3.14;

        Label2.Text = "1. Addition: Adding " + a + " and " + b + " gives " + (a + b);
        Label3.Text = "2. Subtraction: Subtracting " + b + " from " + a + " gives " + (a - b);
        Label4.Text = "3. Multiplication: Multiplying " + a + " by " + b + " gives " + (a * b);
        Label5.Text = "4. Division: Dividing " + a + " by " + b + " gives " + ((double)a / b);

        double power = Math.Pow(a, b);
        Label6.Text = "5. Power: " + a + " raised to the power of " + b + " is " + power;

        double sqrt = Math.Sqrt(a);
        Label7.Text = "6. Square Root: The square root of " + a + " is " + sqrt;

        double sin = Math.Sin(x);
        double cos = Math.Cos(x);
        double tan = Math.Tan(x);
        Label8.Text = "7. Trigonometry: For x = " + x;
        Label9.Text = "   - sin(" + x + ") = " + sin;
        Label10.Text = "   - cos(" + x + ") = " + cos;
        Label11.Text = "   - tan(" + x + ") = " + tan;

        // Factorial of 5
        int factorial = 1;
        for (int i = 2; i <= 5; i++)
        {
            factorial *= i;
        }
        Label12.Text = "8. Factorial: The factorial of 5 (5!) is " + factorial;

        // Random number
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 100);
        Label13.Text = "9. Random Number: A random number between 1 and 100 is " + randomNumber;

        Label14.Text = "=== End of Demo ===";

    }
}