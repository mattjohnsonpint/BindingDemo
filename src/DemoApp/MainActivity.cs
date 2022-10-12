using DemoLib;

namespace DemoApp;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        int result = Demo.Add(1, 2);
        Console.WriteLine($"Result: {result}");
    }
}