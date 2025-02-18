#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapElement : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZIndex
		{
			get
			{
				return (int)this.GetValue(ZIndexProperty);
			}
			set
			{
				this.SetValue(ZIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Visible
		{
			get
			{
				return (bool)this.GetValue(VisibleProperty);
			}
			set
			{
				this.SetValue(VisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MapTabIndex
		{
			get
			{
				return (int)this.GetValue(MapTabIndexProperty);
			}
			set
			{
				this.SetValue(MapTabIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Tag
		{
			get
			{
				return (object)this.GetValue(TagProperty);
			}
			set
			{
				this.SetValue(TagProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string MapStyleSheetEntryState
		{
			get
			{
				return (string)this.GetValue(MapStyleSheetEntryStateProperty);
			}
			set
			{
				this.SetValue(MapStyleSheetEntryStateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string MapStyleSheetEntry
		{
			get
			{
				return (string)this.GetValue(MapStyleSheetEntryProperty);
			}
			set
			{
				this.SetValue(MapStyleSheetEntryProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEnabled
		{
			get
			{
				return (bool)this.GetValue(IsEnabledProperty);
			}
			set
			{
				this.SetValue(IsEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty VisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Visible), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ZIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ZIndex), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MapTabIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MapTabIndex), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MapStyleSheetEntryProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MapStyleSheetEntry), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MapStyleSheetEntryStateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MapStyleSheetEntryState), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TagProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Tag), typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapElement() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapElement", "MapElement.MapElement()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapElement()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.ZIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.ZIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.Visible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.Visible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapTabIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapTabIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryState.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryState.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.Tag.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.Tag.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.IsEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.IsEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.IsEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryStateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.TagProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.MapTabIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.ZIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapElement.VisibleProperty.get
	}
}
