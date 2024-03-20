namespace iOSCollectionViewBug;

public partial class MainPage : ContentPage
{
    private List<Item> _items;
	public List<Item> Items
	{
		get { return _items; }
		set { _items = value; OnPropertyChanged(); }
	}

	public MainPage()
	{
		InitializeComponent();

        BindingContext = this;

		Items = new List<Item>()
		{
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" },
            new Item() { Content = "Some text" }
        };
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Items[0].Content = "Some much much much much much much much much much much much much much much much much longer text";
        Items[2].Content = "Some much much much much much much much much much much much much much much much much longer text";
        Items[4].Content = "Some much much much much much much much much much much much much much much much much longer text";
    }
}