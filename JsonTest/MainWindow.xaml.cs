using JsonTest.Models;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace JsonTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ParseJson();
    }

    private void ParseJson()
    {
        var jsonPath = @"C:\data.json";
        var jsonString = File.ReadAllText(jsonPath);

        var dashboard = JsonSerializer.Deserialize<Dashboard>(jsonString);

        foreach (var user in dashboard.Users)
        {
            MessageBox.Show(user.Value.Name);
        }
    }
}
