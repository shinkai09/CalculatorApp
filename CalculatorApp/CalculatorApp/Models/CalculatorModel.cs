namespace CalculatorApp.Models
{
    public class CalculatorModel
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    public string? Operation { get; set; }
    public double Result { get; set; }

 
    public void Calculate()
    {
        switch (Operation)
        {
            case "Add":
                Result = FirstNumber + SecondNumber;
                break;
            case "Subtract":
                Result = FirstNumber - SecondNumber;
                break;
            case "Multiply":
                Result = FirstNumber * SecondNumber;
                break;
            case "Divide":
                Result = SecondNumber != 0 ? FirstNumber / SecondNumber : double.NaN;
                break;
            default:
                Result = 0;
                break;
        }
    }
}
    }