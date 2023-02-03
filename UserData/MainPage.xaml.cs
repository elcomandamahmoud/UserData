using System.Text.RegularExpressions;
namespace UserData;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void CheckName_Clicked(object sender, EventArgs e)
    {
        try
        {
            Regex regName = new Regex(@"^[a-z]+(\s[a-z]+){3}$");
            if (regName.IsMatch(TXTName.Text.Trim()))
            {
                DisplayAlert("Congratulations", "Welcome " + TXTName.Text.Split(" "[0]), "Done");
            }
            else
            {
                DisplayAlert("Erorr", "This name is not valid", "Done");
            }
        }
        catch (Exception x)
        {
            DisplayAlert("", x.Message, "Ok");
        }
    }

    private void CheckE_Mail_Clicked(object sender, EventArgs e)
    {
        try
        {
            Regex regE_Mail = new Regex(@"^[a-zA-Z0-9]+([_.-][a-zA-Z0-9]+)*@[a-zA-Z]+([_.-][a-zA-Z]+)*\.[a-z]+$");
            if (regE_Mail.IsMatch(TXTE_Mail.Text.Trim()))
            {
                DisplayAlert("Congratulations", "Your E-Mail is: " + TXTE_Mail.Text.Trim() + " and it is valid", "Done");
            }
            else
            {
                DisplayAlert("Erorr", "This E-Mail is not valid", "Done");
            }
        }
        catch (Exception x)
        {
            DisplayAlert("", x.Message, "Ok");
        }
    }

    private void CheckPhone_Clicked(object sender, EventArgs e)
    {
        try
        {
            Regex regPhone = new Regex(@"^(010|011|012|015)\d{8}    $");
            if (regPhone.IsMatch(TXTPhone.Text.Trim()))
            {
                DisplayAlert("Congratulations", "Your phone is: " + TXTPhone.Text.Trim() + " and it is valid", "Done");
            }
            else
            {
                DisplayAlert("Erorr", "This phone is not valid", "Done");
            }
        }
        catch (Exception x)
        {
            DisplayAlert("", x.Message, "Ok");
        }
    }
}