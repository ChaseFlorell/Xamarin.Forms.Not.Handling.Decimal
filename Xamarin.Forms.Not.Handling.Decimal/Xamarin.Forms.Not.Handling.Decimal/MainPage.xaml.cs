namespace Xamarin.Forms.Not.Handling.Decimal
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		    BindingContext = this;
		}

	    public static readonly BindableProperty BrokenBindingProperty = BindableProperty.Create(nameof(BrokenBinding),
	        typeof(decimal),
	        typeof(MainPage),
	        default(decimal));

	    /// <summary>
	    /// BrokenBinding summary. This is a bindable property.
	    /// </summary>
	    public decimal BrokenBinding
	    {
	        get => (decimal) GetValue(BrokenBindingProperty);
	        set => SetValue(BrokenBindingProperty, value);
	    }

	    public static readonly BindableProperty WorkingBindingProperty = BindableProperty.Create(nameof(WorkingBinding),
	        typeof(decimal),
	        typeof(MainPage),
	        default(decimal));

	    /// <summary>
	    /// WorkingBinding summary. This is a bindable property.
	    /// </summary>
	    public decimal WorkingBinding
	    {
	        get => (decimal) GetValue(WorkingBindingProperty);
	        set => SetValue(WorkingBindingProperty, value);
	    }
	}
}
